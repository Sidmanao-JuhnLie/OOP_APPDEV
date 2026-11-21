using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Controls
{
    /// <summary>
    /// Vertical timeline (History page): date on the left, a dot on a vertical line,
    /// then a bold name with a status pill. Scrolls by itself when there are many entries.
    /// Fill it with Clear() and AddItem(date, title, status). Sizes scale with the display DPI.
    /// </summary>
    public class TimelineControl : Panel
    {
        private sealed class Entry
        {
            public string Date = "";
            public string Title = "";
            public string Status = "";
        }

        private readonly List<Entry> _entries = new List<Entry>();
        private string _emptyText = "No borrower history yet";

        public TimelineControl()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            AutoScroll = true;
            BackColor = Color.White;
        }

        [Category("Appearance")]
        [DefaultValue("No borrower history yet")]
        public string EmptyText
        {
            get => _emptyText;
            set { _emptyText = value ?? ""; Invalidate(); }
        }

        public void Clear()
        {
            _entries.Clear();
            UpdateScrollSize();
            Invalidate();
        }

        /// <summary>Adds an entry below the existing ones (newest first is the caller's order).</summary>
        public void AddItem(string date, string title, string status)
        {
            _entries.Add(new Entry { Date = date ?? "", Title = title ?? "", Status = status ?? "" });
            UpdateScrollSize();
            Invalidate();
        }

        private float Scale => DeviceDpi / 96f;

        private void UpdateScrollSize()
        {
            int height = _entries.Count == 0 ? 0 : (int)Math.Ceiling((8 + _entries.Count * 75 + 8) * Scale);
            AutoScrollMinSize = new Size(0, height);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateScrollSize();
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            UpdateScrollSize();
        }

        private static Color DotColor(string status)
        {
            switch (status.Trim().ToLowerInvariant())
            {
                case "approved":
                case "available": return Theme.Approved;
                case "pending": return Theme.Pending;
                case "rejected":
                case "broken": return Theme.Rejected;
                case "in use": return Theme.InUse;
                case "under repair": return Theme.UnderRepair;
                default: return Theme.Returned;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float s = Scale;
            const TextFormatFlags plain = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix
                                        | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter;

            if (_entries.Count == 0)
            {
                TextRenderer.DrawText(g, _emptyText, Theme.Caption,
                    new Rectangle((int)(24 * s), (int)(8 * s), Math.Max(0, Width - (int)(48 * s)), (int)(24 * s)),
                    Theme.InkMuted, plain | TextFormatFlags.Left);
                return;
            }

            float itemHeight = 75 * s;
            float top = AutoScrollPosition.Y + 8 * s;
            float lineX = 138 * s;
            float dot = 12 * s;

            // The vertical line, from the first dot to the last dot
            if (_entries.Count > 1)
            {
                using (var pen = new Pen(Theme.Line, 2f * s))
                {
                    g.DrawLine(pen, lineX, top + 10 * s, lineX, top + (_entries.Count - 1) * itemHeight + 10 * s);
                }
            }

            for (int i = 0; i < _entries.Count; i++)
            {
                var entry = _entries[i];
                float y = top + i * itemHeight;
                if (y + itemHeight < 0 || y > Height) continue;   // not visible

                // date (right aligned, left of the line)
                var dateRect = new Rectangle(0, (int)y, (int)(lineX - 20 * s), (int)(20 * s));
                TextRenderer.DrawText(g, entry.Date, Theme.Caption, dateRect, Theme.InkMuted, plain | TextFormatFlags.Right);

                // dot
                using (var brush = new SolidBrush(DotColor(entry.Status)))
                {
                    g.FillEllipse(brush, lineX - dot / 2f, y + 10 * s - dot / 2f, dot, dot);
                }

                // name + status pill
                float textX = lineX + 22 * s;
                var nameRect = new Rectangle((int)textX, (int)y, Math.Max(0, Width - (int)textX - (int)(16 * s)), (int)(20 * s));
                TextRenderer.DrawText(g, entry.Title, Theme.BodyBold, nameRect, Theme.Ink, plain | TextFormatFlags.Left);

                var pillArea = new Rectangle((int)textX, (int)(y + 26 * s), (int)(160 * s), (int)(26 * s));
                UiHelper.DrawStatusPill(g, pillArea, entry.Status, 0, s);
            }
        }
    }
}
