using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// A filled circle with centered text (avatar initials, notification count)
    /// or a Segoe MDL2 Assets glyph. With neither it is a plain colored dot.
    /// </summary>
    public class CircleBadge : Control
    {
        private Color _fillColor = Theme.Brand;
        private string _glyph = "";

        public CircleBadge()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = Theme.BodyBold;
            TabStop = false;
            Size = new Size(40, 40);
        }

        [Category("Appearance")]
        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; Invalidate(); }
        }

        private bool ShouldSerializeFillColor() => _fillColor != Theme.Brand;
        private void ResetFillColor() => FillColor = Theme.Brand;

        [Category("Appearance")]
        [DefaultValue("")]
        [Description("Optional Segoe MDL2 Assets character drawn instead of Text.")]
        public string Glyph
        {
            get => _glyph;
            set { _glyph = value ?? ""; Invalidate(); }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new SolidBrush(_fillColor))
            {
                g.FillEllipse(brush, 0, 0, Width, Height);
            }

            const TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                                        | TextFormatFlags.NoPadding | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix;

            if (_glyph.Length > 0)
            {
                using (var glyphFont = new Font("Segoe MDL2 Assets", Height * 0.40f, FontStyle.Regular, GraphicsUnit.Pixel))
                {
                    TextRenderer.DrawText(g, _glyph, glyphFont, ClientRectangle, ForeColor, flags);
                }
            }
            else if (!string.IsNullOrEmpty(Text))
            {
                TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor, flags);
            }
        }
    }
}
