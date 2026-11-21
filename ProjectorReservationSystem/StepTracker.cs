using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// Horizontal progress timeline: Submitted - Under Review - Approved - Picked Up - Returned.
    /// Steps before CurrentStep are green with a check mark, CurrentStep is highlighted,
    /// later steps are gray. CurrentStep is 1-based; a value above the step count means "all done".
    /// </summary>
    public class StepTracker : Control
    {
        private static readonly Font CurrentLabelFont = new Font("Segoe UI Semibold", 9f);

        private string[] _steps = { "Submitted", "Under Review", "Approved", "Picked Up", "Returned" };
        private int _currentStep = 1;
        private Color _currentColor = Theme.Brand;

        public StepTracker()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TabStop = false;
            Size = new Size(500, 64);
        }

        /// <summary>The step names, left to right. Set from code; the defaults match the mockup.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string[] Steps
        {
            get => _steps;
            set { _steps = value ?? System.Array.Empty<string>(); Invalidate(); }
        }

        [Category("Behavior")]
        [DefaultValue(1)]
        public int CurrentStep
        {
            get => _currentStep;
            set { _currentStep = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Color of the current step's circle (purple normally, red for a rejected request).")]
        public Color CurrentColor
        {
            get => _currentColor;
            set { _currentColor = value; Invalidate(); }
        }

        private bool ShouldSerializeCurrentColor() => _currentColor != Theme.Brand;
        private void ResetCurrentColor() => CurrentColor = Theme.Brand;

        protected override void OnPaint(PaintEventArgs e)
        {
            int n = _steps.Length;
            if (n == 0 || Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            const int d = 28;
            float slot = Width / (float)n;
            float cy = d / 2f;

            // Connecting lines (drawn first so the circles sit on top)
            for (int k = 1; k < n; k++)
            {
                float x1 = slot * (k - 0.5f) + d / 2f;
                float x2 = slot * (k + 0.5f) - d / 2f;
                Color lineColor = k < _currentStep ? Theme.Success : Theme.BarGray;
                using (var pen = new Pen(lineColor, 3f))
                {
                    g.DrawLine(pen, x1, cy, x2, cy);
                }
            }

            const TextFormatFlags centered = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                                           | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine;

            for (int k = 1; k <= n; k++)
            {
                float cx = slot * (k - 0.5f);
                var circle = new RectangleF(cx - d / 2f, 0, d, d);
                bool done = k < _currentStep;
                bool current = k == _currentStep;

                Color fill = done ? Theme.Success : current ? _currentColor : Theme.BarGray;
                using (var brush = new SolidBrush(fill))
                {
                    g.FillEllipse(brush, circle);
                }

                Rectangle textRect = Rectangle.Round(circle);
                if (done)
                {
                    using (var glyphFont = new Font("Segoe MDL2 Assets", 11f, FontStyle.Regular, GraphicsUnit.Pixel))
                    {
                        TextRenderer.DrawText(g, "", glyphFont, textRect, Color.White, centered);   // check mark
                    }
                }
                else
                {
                    TextRenderer.DrawText(g, k.ToString(), Theme.BodyBold, textRect,
                        current ? Color.White : Theme.InkMuted, centered);
                }

                var labelRect = new Rectangle((int)(slot * (k - 1)), d + 8, (int)slot, 20);
                TextRenderer.DrawText(g, _steps[k - 1], current ? CurrentLabelFont : Theme.Caption, labelRect, Theme.Ink,
                    centered | TextFormatFlags.EndEllipsis);
            }
        }
    }
}
