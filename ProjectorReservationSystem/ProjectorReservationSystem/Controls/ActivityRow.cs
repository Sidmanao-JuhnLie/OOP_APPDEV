using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    public enum ActivityKind
    {
        Approved,
        Rejected,
        Returned
    }

    /// <summary>
    /// One row of the "Recent decisions" list (and the notification popup):
    /// colored icon circle, title, subtitle and an optional right-aligned time stamp.
    /// Sizes scale with the display DPI.
    /// </summary>
    public class ActivityRow : Control
    {
        private ActivityKind _kind = ActivityKind.Approved;
        private string _title = "";
        private string _subtitle = "";
        private string _timeText = "";

        public ActivityRow()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TabStop = false;
            Size = new Size(252, 56);
        }

        [Category("Appearance")]
        [DefaultValue(ActivityKind.Approved)]
        public ActivityKind Kind
        {
            get => _kind;
            set { _kind = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Title
        {
            get => _title;
            set { _title = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Subtitle
        {
            get => _subtitle;
            set { _subtitle = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TimeText
        {
            get => _timeText;
            set { _timeText = value ?? ""; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float s = DeviceDpi / 96f;

            const TextFormatFlags plain = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix
                                        | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis;

            // Icon circle
            Color fill;
            string glyph;
            switch (_kind)
            {
                case ActivityKind.Rejected: fill = Theme.Danger;   glyph = ""; break;   // cancel
                case ActivityKind.Returned: fill = Theme.Returned; glyph = ""; break;   // undo
                default:                    fill = Theme.Success;  glyph = ""; break;   // accept (check)
            }

            int d = Math.Min((int)Math.Round(40 * s), Height);
            int circleY = (Height - d) / 2;
            using (var brush = new SolidBrush(fill))
            {
                g.FillEllipse(brush, 0, circleY, d, d);
            }
            using (var glyphFont = new Font("Segoe MDL2 Assets", d * 0.38f, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                TextRenderer.DrawText(g, glyph, glyphFont, new Rectangle(0, circleY, d, d), Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.SingleLine);
            }

            // Time (right aligned, vertically centered)
            int timeWidth = 0;
            if (_timeText.Length > 0)
            {
                timeWidth = TextRenderer.MeasureText(g, _timeText, Theme.Caption, new Size(int.MaxValue, int.MaxValue), plain).Width;
                TextRenderer.DrawText(g, _timeText, Theme.Caption,
                    new Rectangle(Width - timeWidth, 0, timeWidth, Height), Theme.InkMuted,
                    plain | TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }

            // Title + subtitle
            int textX = d + (int)Math.Round(12 * s);
            int textWidth = Math.Max(0, Width - textX - timeWidth - (int)Math.Round(8 * s));
            int mid = Height / 2;
            int titleHeight = (int)Math.Round(19 * s);
            int subtitleHeight = (int)Math.Round(17 * s);

            TextRenderer.DrawText(g, _title, Theme.BodyBold,
                new Rectangle(textX, mid - titleHeight - (int)Math.Round(1 * s), textWidth, titleHeight), Theme.Ink,
                plain | TextFormatFlags.Left | TextFormatFlags.Bottom);
            TextRenderer.DrawText(g, _subtitle, Theme.Caption,
                new Rectangle(textX, mid + (int)Math.Round(1 * s), textWidth, subtitleHeight), Theme.InkMuted,
                plain | TextFormatFlags.Left | TextFormatFlags.Top);
        }
    }
}
