using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectorReservationSystem.Controls;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Forms
{
    /// <summary>
    /// The notification card from mockup page 5: a white rounded card on a lavender frame with one row per
    /// notification (green check = approved, red cross = rejected, gray arrow = returned).
    /// It is shown under the bell button and closes itself when it loses focus or Esc is pressed.
    /// Fill it with AddNotification(...) before showing it.
    /// </summary>
    public partial class NotificationPopup : Form
    {
        private int _count;
        private Control? _anchor;

        public NotificationPopup()
        {
            InitializeComponent();
            Deactivate += (s, e) => Close();
            FitToContent();
        }

        /// <summary>Number of notifications currently in the popup.</summary>
        public int Count => _count;

        /// <summary>
        /// Adds one notification row. Unread rows get the light purple highlight.
        /// Example: AddNotification(ActivityKind.Approved, "PJ-03 request approved", "2 min ago", true)
        /// </summary>
        public void AddNotification(ActivityKind kind, string text, string timeAgo, bool unread = false)
        {
            var row = new RoundedPanel
            {
                CornerRadius = 12,
                BackColor = unread ? Theme.BrandSoft : Theme.Surface,
                Size = new Size(LogicalToDeviceUnits(336), LogicalToDeviceUnits(64)),
                Margin = new Padding(0, 0, 0, LogicalToDeviceUnits(4))
            };

            var item = new ActivityRow
            {
                Kind = kind,
                Title = text,
                Subtitle = timeAgo,
                Location = new Point(LogicalToDeviceUnits(10), LogicalToDeviceUnits(4)),
                Size = new Size(LogicalToDeviceUnits(316), LogicalToDeviceUnits(56))
            };

            row.Controls.Add(item);
            flpItems.Controls.Add(row);
            _count++;
            FitToContent();
        }

        /// <summary>Shows the popup with its top-right corner just below the given control (e.g. the bell button).</summary>
        public void ShowBelow(Form owner, Control anchor)
        {
            _anchor = anchor;
            Show(owner);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FitToContent();   // sizes are final after DPI scaling

            if (_anchor != null)
            {
                Point p = _anchor.PointToScreen(new Point(_anchor.Width, _anchor.Height + LogicalToDeviceUnits(8)));
                Location = new Point(p.X - Width, p.Y);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FitToContent()
        {
            lblEmpty.Visible = _count == 0;

            int rowsHeight = _count == 0
                ? LogicalToDeviceUnits(40)
                : _count * LogicalToDeviceUnits(68);
            int cardHeight = lblTitle.Height + flpItems.Padding.Vertical + rowsHeight;
            int maxHeight = LogicalToDeviceUnits(520);

            ClientSize = new Size(ClientSize.Width, Math.Min(Padding.Vertical + cardHeight, maxHeight));
        }
    }
}
