using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// Paired bar chart (e.g. this week vs last week) with title, legend, gridlines and category labels.
    /// Feed it with SetData(labels, seriesA, seriesB). It holds no data of its own beyond what you give it.
    /// Margins, bar sizes and legend spacing scale with the display DPI.
    /// </summary>
    public class BarChart : Control
    {
        private string[] _labels = Array.Empty<string>();
        private double[] _seriesA = Array.Empty<double>();
        private double[] _seriesB = Array.Empty<double>();
        private string _title = "";
        private string _seriesAName = "This week";
        private string _seriesBName = "Last week";
        private Color _seriesAColor = Theme.Brand;
        private Color _seriesBColor = Theme.BarGray;

        public BarChart()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TabStop = false;
            Size = new Size(340, 280);
        }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Title
        {
            get => _title;
            set { _title = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue("This week")]
        public string SeriesAName
        {
            get => _seriesAName;
            set { _seriesAName = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue("Last week")]
        public string SeriesBName
        {
            get => _seriesBName;
            set { _seriesBName = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        public Color SeriesAColor
        {
            get => _seriesAColor;
            set { _seriesAColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color SeriesBColor
        {
            get => _seriesBColor;
            set { _seriesBColor = value; Invalidate(); }
        }

        private bool ShouldSerializeSeriesAColor() => _seriesAColor != Theme.Brand;
        private void ResetSeriesAColor() => SeriesAColor = Theme.Brand;
        private bool ShouldSerializeSeriesBColor() => _seriesBColor != Theme.BarGray;
        private void ResetSeriesBColor() => SeriesBColor = Theme.BarGray;

        /// <summary>Replaces the chart data. The arrays are copied.</summary>
        public void SetData(string[] labels, double[] seriesA, double[] seriesB)
        {
            _labels = (string[])(labels ?? Array.Empty<string>()).Clone();
            _seriesA = (double[])(seriesA ?? Array.Empty<double>()).Clone();
            _seriesB = (double[])(seriesB ?? Array.Empty<double>()).Clone();
            Invalidate();
        }

        private static double ValueAt(double[] values, int index) => index < values.Length ? values[index] : 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float s = DeviceDpi / 96f;

            const TextFormatFlags plain = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine;

            // Title (left) and legend (right)
            if (_title.Length > 0)
            {
                TextRenderer.DrawText(g, _title, Theme.CardTitle, new Point(0, 0), Theme.Ink, plain);
            }

            int x = Width;
            DrawLegendItem(g, ref x, _seriesBName, _seriesBColor, s);
            DrawLegendItem(g, ref x, _seriesAName, _seriesAColor, s);

            // Plot area
            int top = (int)Math.Round(52 * s);
            int bottom = Height - (int)Math.Round(30 * s);
            if (bottom - top < 20 * s || _labels.Length == 0) return;

            double max = 1;
            for (int i = 0; i < _labels.Length; i++)
            {
                max = Math.Max(max, Math.Max(ValueAt(_seriesA, i), ValueAt(_seriesB, i)));
            }

            using (var gridPen = new Pen(Theme.Line, 1f))
            {
                for (int i = 0; i < 4; i++)
                {
                    float y = top + (bottom - top) * i / 3f;
                    g.DrawLine(gridPen, 0, y, Width, y);
                }
            }

            float slotWidth = Width / (float)_labels.Length;
            float barWidth = Math.Min(slotWidth * 0.26f, 22f * s);
            float gap = 4f * s;
            int radius = (int)Math.Round(4 * s);

            using (var brushA = new SolidBrush(_seriesAColor))
            using (var brushB = new SolidBrush(_seriesBColor))
            {
                for (int i = 0; i < _labels.Length; i++)
                {
                    float centerX = slotWidth * (i + 0.5f);
                    DrawBar(g, brushA, centerX - gap / 2f - barWidth, barWidth, bottom, (bottom - top), ValueAt(_seriesA, i) / max, radius);
                    DrawBar(g, brushB, centerX + gap / 2f, barWidth, bottom, (bottom - top), ValueAt(_seriesB, i) / max, radius);

                    var labelRect = new Rectangle((int)(slotWidth * i), bottom + (int)Math.Round(6 * s), (int)slotWidth, (int)Math.Round(20 * s));
                    TextRenderer.DrawText(g, _labels[i], Theme.Caption, labelRect, Theme.InkMuted,
                        plain | TextFormatFlags.HorizontalCenter | TextFormatFlags.Top);
                }
            }
        }

        private static void DrawBar(Graphics g, Brush brush, float x, float width, int bottom, int plotHeight, double ratio, int radius)
        {
            float height = (float)(plotHeight * ratio);
            if (height < 1f) return;

            var rect = Rectangle.Round(new RectangleF(x, bottom - height, width, height));
            using (var path = RoundedPanel.RoundedRect(rect, radius))
            {
                g.FillPath(brush, path);
            }
        }

        private void DrawLegendItem(Graphics g, ref int x, string name, Color color, float s)
        {
            if (name.Length == 0) return;

            const TextFormatFlags plain = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine;
            Size size = TextRenderer.MeasureText(g, name, Theme.Caption, new Size(int.MaxValue, int.MaxValue), plain);

            x -= size.Width;
            TextRenderer.DrawText(g, name, Theme.Caption, new Point(x, (int)Math.Round(3 * s)), Theme.InkMuted, plain);

            int dot = (int)Math.Round(8 * s);
            x -= (int)Math.Round(14 * s);
            using (var brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, (int)Math.Round(8 * s), dot, dot);
            }
            x -= (int)Math.Round(14 * s);   // space before the next legend item
        }
    }
}
