using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// A flat Button with rounded corners, hover color, optional border and optional icon.
    /// Version 2: adds IconGlyph / IconSize (a Segoe MDL2 Assets character) so it can be used for
    /// sidebar navigation items (icon + left-aligned text) and icon-only buttons (bell, gear, close).
    /// Still a real Button: Click, Enabled, TabStop, AcceptButton etc. all behave normally.
    /// </summary>
    public class RoundedButton : Button
    {
        private int _cornerRadius = 12;
        private Color _hoverColor = Theme.BrandHover;
        private Color _borderColor = Color.Empty;
        private string _iconGlyph = "";
        private float _iconSize = 12f;
        private bool _hover;
        private bool _pressed;

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Theme.Brand;
            ForeColor = Color.White;
            Font = Theme.BodyBold;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }

        [Category("Appearance")]
        [DefaultValue(12)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Fill color while the mouse is over the button.")]
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        private bool ShouldSerializeHoverColor() => _hoverColor != Theme.BrandHover;
        private void ResetHoverColor() => HoverColor = Theme.BrandHover;

        [Category("Appearance")]
        [Description("Color of the 1px border. Empty = no border.")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private bool ShouldSerializeBorderColor() => _borderColor != Color.Empty;
        private void ResetBorderColor() => BorderColor = Color.Empty;

        [Category("Appearance")]
        [DefaultValue("")]
        [Description("A Segoe MDL2 Assets character, e.g. \\uE713. With no Text the icon is centered; with Text it is drawn on the left.")]
        public string IconGlyph
        {
            get => _iconGlyph;
            set { _iconGlyph = value ?? ""; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(12f)]
        public float IconSize
        {
            get => _iconSize;
            set { _iconSize = Math.Max(6f, value); Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs mevent) { _pressed = true; Invalidate(); base.OnMouseDown(mevent); }
        protected override void OnMouseUp(MouseEventArgs mevent) { _pressed = false; Invalidate(); base.OnMouseUp(mevent); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent?.BackColor ?? SystemColors.Control);

            if (Width <= 0 || Height <= 0) return;

            Color fillColor = !Enabled ? Theme.BarGray
                            : (_hover || _pressed) ? _hoverColor
                            : BackColor;
            Color textColor = Enabled ? ForeColor : Theme.InkMuted;

            using (var path = RoundedPanel.RoundedRect(new Rectangle(0, 0, Width, Height), _cornerRadius))
            using (var brush = new SolidBrush(fillColor))
            {
                g.FillPath(brush, path);
            }

            if (_borderColor != Color.Empty)
            {
                using (var path = RoundedPanel.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), _cornerRadius))
                using (var pen = new Pen(_borderColor, 1f))
                {
                    g.DrawPath(pen, path);
                }
            }

            bool hasIcon = _iconGlyph.Length > 0;
            bool hasText = !string.IsNullOrEmpty(Text);
            const TextFormatFlags iconFlags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                                            | TextFormatFlags.NoPadding | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix;

            if (hasIcon && !hasText)
            {
                using (var iconFont = new Font("Segoe MDL2 Assets", _iconSize, FontStyle.Regular, GraphicsUnit.Point))
                {
                    TextRenderer.DrawText(g, _iconGlyph, iconFont, ClientRectangle, textColor, iconFlags);
                }
                return;
            }

            int textX = Padding.Left;
            if (hasIcon)
            {
                using (var iconFont = new Font("Segoe MDL2 Assets", _iconSize, FontStyle.Regular, GraphicsUnit.Point))
                {
                    var iconRect = new Rectangle(Padding.Left, 0, 24, Height);
                    TextRenderer.DrawText(g, _iconGlyph, iconFont, iconRect, textColor, iconFlags);
                }
                textX += 36;
            }

            var textRect = new Rectangle(
                textX, Padding.Top,
                Math.Max(0, Width - textX - Padding.Right),
                Math.Max(0, Height - Padding.Vertical));

            TextRenderer.DrawText(g, Text, Font, textRect, textColor, GetTextFlags());
        }

        private TextFormatFlags GetTextFlags()
        {
            var flags = TextFormatFlags.VerticalCenter
                      | TextFormatFlags.SingleLine
                      | TextFormatFlags.EndEllipsis
                      | TextFormatFlags.NoPrefix;

            switch (TextAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    flags |= TextFormatFlags.Left;
                    break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Right;
                    break;
                default:
                    flags |= TextFormatFlags.HorizontalCenter;
                    break;
            }
            return flags;
        }
    }
}
