using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// A rounded panel filled with a purple gradient. Used for the single "hero" card on the Dashboard.
    /// Labels placed inside should use BackColor = Transparent so the gradient shows through.
    /// </summary>
    public class GradientPanel : RoundedPanel
    {
        private Color _colorStart = Theme.Brand;
        private Color _colorEnd = Theme.BrandLight;
        private float _angle = 45f;

        [Category("Appearance")]
        public Color ColorStart
        {
            get => _colorStart;
            set { _colorStart = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ColorEnd
        {
            get => _colorEnd;
            set { _colorEnd = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(45f)]
        public float Angle
        {
            get => _angle;
            set { _angle = value; Invalidate(); }
        }

        private bool ShouldSerializeColorStart() => _colorStart != Theme.Brand;
        private void ResetColorStart() => ColorStart = Theme.Brand;
        private bool ShouldSerializeColorEnd() => _colorEnd != Theme.BrandLight;
        private void ResetColorEnd() => ColorEnd = Theme.BrandLight;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width, Height);

            using (var path = RoundedRect(rect, ScaledCornerRadius))
            using (var brush = new LinearGradientBrush(rect, _colorStart, _colorEnd, _angle))
            {
                g.FillPath(brush, path);
            }
        }
    }
}
