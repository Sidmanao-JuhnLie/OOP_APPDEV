using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// A Panel with rounded corners and an optional 1px border.
    /// BackColor is the fill color; the pixels outside the corners show the parent's BackColor.
    /// Used for cards, the lavender hero panel and the rounded text-box wrappers.
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 16;
        private Color _borderColor = Color.Empty;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
        }

        [Category("Appearance")]
        [DefaultValue(16)]
        [Description("Radius of the rounded corners in pixels.")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Color of the 1px border. Empty = no border.")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private bool ShouldSerializeBorderColor() => _borderColor != Color.Empty;

        /// <summary>CornerRadius scaled to the current display DPI (100% = unchanged).</summary>
        protected int ScaledCornerRadius => (int)Math.Round(_cornerRadius * DeviceDpi / 96f);
        private void ResetBorderColor() => BorderColor = Color.Empty;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Paint what is *behind* the card so the corners look transparent.
            e.Graphics.Clear(Parent?.BackColor ?? SystemColors.Control);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = RoundedRect(new Rectangle(0, 0, Width, Height), ScaledCornerRadius))
            using (var fill = new SolidBrush(BackColor))
            {
                g.FillPath(fill, path);
            }

            if (_borderColor != Color.Empty)
            {
                using (var path = RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), ScaledCornerRadius))
                using (var pen = new Pen(_borderColor, 1f))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        /// <summary>Builds a rounded-rectangle path. Radius is clamped so it never exceeds half the shortest side.</summary>
        public static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new GraphicsPath();
            int d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            if (d <= 0)
            {
                path.AddRectangle(r);
                return path;
            }

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
