using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// The monitor-with-bars illustration from the mockups (login hero, sidebar footer).
    /// Drawn with GDI+ so it needs no image file and stays sharp at any size / DPI.
    /// Keep the control's aspect ratio near 205 : 155; it scales and centers itself.
    /// </summary>
    public class ProjectorIllustration : Control
    {
        private const float DesignWidth = 205f;
        private const float DesignHeight = 155f;

        public ProjectorIllustration()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TabStop = false;
            Size = new Size(205, 155);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            float scale = Math.Min(Width / DesignWidth, Height / DesignHeight);
            if (scale <= 0f) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TranslateTransform((Width - DesignWidth * scale) / 2f, (Height - DesignHeight * scale) / 2f);
            g.ScaleTransform(scale, scale);

            // Stand (neck + base)
            using (var gray = new SolidBrush(Theme.BarGray))
            {
                g.FillRectangle(gray, 86, 128, 33, 18);
                using (var basePath = RoundedPanel.RoundedRect(new Rectangle(52, 145, 101, 10), 5))
                {
                    g.FillPath(gray, basePath);
                }
            }

            // Screen frame
            using (var frame = RoundedPanel.RoundedRect(new Rectangle(3, 3, 199, 124), 14))
            using (var pen = new Pen(Theme.Brand, 6f) { LineJoin = LineJoin.Round })
            {
                g.DrawPath(pen, frame);
            }

            // Bars: x, top, color (all bottom-aligned at y = 108, width 20)
            DrawBar(g, 36, 71, Theme.Brand);
            DrawBar(g, 73, 51, Theme.BrandLight);
            DrawBar(g, 109, 35, Theme.Brand);
            DrawBar(g, 146, 61, Theme.BarGray);
        }

        private static void DrawBar(Graphics g, int x, int top, Color color)
        {
            using (var path = RoundedPanel.RoundedRect(new Rectangle(x, top, 20, 108 - top), 4))
            using (var brush = new SolidBrush(color))
            {
                g.FillPath(brush, path);
            }
        }
    }
}
