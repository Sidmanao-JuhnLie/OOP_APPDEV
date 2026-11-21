using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// A thin pill-shaped progress bar (the standard WinForms ProgressBar cannot be recolored or rounded).
    /// Used for the Pending / Approved / Rejected bars on the Dashboard.
    /// </summary>
    public class RoundedProgress : Control
    {
        private int _value;
        private int _maximum = 100;
        private Color _barColor = Theme.Brand;
        private Color _trackColor = Theme.Line;

        public RoundedProgress()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TabStop = false;
            Size = new Size(200, 8);
        }

        [Category("Behavior")]
        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set { _value = Math.Max(0, Math.Min(value, _maximum)); Invalidate(); }
        }

        [Category("Behavior")]
        [DefaultValue(100)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = Math.Max(1, value);
                _value = Math.Min(_value, _maximum);
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BarColor
        {
            get => _barColor;
            set { _barColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color TrackColor
        {
            get => _trackColor;
            set { _trackColor = value; Invalidate(); }
        }

        private bool ShouldSerializeBarColor() => _barColor != Theme.Brand;
        private void ResetBarColor() => BarColor = Theme.Brand;
        private bool ShouldSerializeTrackColor() => _trackColor != Theme.Line;
        private void ResetTrackColor() => TrackColor = Theme.Line;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int radius = Height / 2;

            using (var path = RoundedPanel.RoundedRect(new Rectangle(0, 0, Width, Height), radius))
            using (var brush = new SolidBrush(_trackColor))
            {
                g.FillPath(brush, path);
            }

            if (_value <= 0) return;

            int fillWidth = (int)Math.Round(Width * (double)_value / _maximum);
            fillWidth = Math.Max(fillWidth, Height);   // never thinner than a dot
            fillWidth = Math.Min(fillWidth, Width);

            using (var path = RoundedPanel.RoundedRect(new Rectangle(0, 0, fillWidth, Height), radius))
            using (var brush = new SolidBrush(_barColor))
            {
                g.FillPath(brush, path);
            }
        }
    }
}
