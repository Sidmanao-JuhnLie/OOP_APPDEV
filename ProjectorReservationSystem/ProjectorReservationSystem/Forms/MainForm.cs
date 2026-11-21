using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectorReservationSystem.Controls;
using ProjectorReservationSystem.Helpers;
using ProjectorReservationSystem.Pages;

namespace ProjectorReservationSystem.Forms
{
    public partial class MainForm : Form
    {
        private readonly RoundedButton[] _navButtons;
        private readonly Dictionary<Type, UserControl> _pages = new Dictionary<Type, UserControl>();

        /// <summary>
        /// Raised when the user clicks "Log out". Subscribe to it from wherever the LoginForm is created
        /// (e.g. show a new LoginForm). If nobody subscribes, the main window simply closes.
        /// </summary>
        public event EventHandler? LogoutRequested;

        /// <summary>
        /// Raised when the bell is clicked, before the notification popup is shown. A subscriber fills the popup
        /// with real notifications via popup.AddNotification(...). If nobody subscribes, sample notifications
        /// from the mockup are shown instead (TODO: remove AddSampleNotifications when real data exists).
        /// </summary>
        public event EventHandler<NotificationPopup>? NotificationsOpening;

        private NotificationPopup? _popup;
        private long _popupClosedTick;

        public MainForm()
        {
            InitializeComponent();
            _navButtons = new[] { btnNavDashboard, btnNavReservations, btnNavEquipment, btnNavHistory };
        }

        // ---------------------------------------------------------------------
        // Public API used by the rest of the application to fill the right panel.
        // The Designer shows sample values from the mockup ("Alex Rivera", counts, decisions);
        // replace them by calling these once the real data / logged-in user is available.
        // ---------------------------------------------------------------------

        public void SetCurrentUser(string fullName, string role)
        {
            lblUserName.Text = fullName;
            lblUserRole.Text = role;
            badgeAvatar.Text = GetInitials(fullName);
        }

        public void SetMyRequests(int pending, int approved)
        {
            lblMyPendingVal.Text = pending.ToString();
            lblMyApprovedVal.Text = approved.ToString();
        }

        public void SetUnreadNotifications(int count)
        {
            badgeNotif.Text = count.ToString();
            badgeNotif.Visible = count > 0;
        }

        private static string GetInitials(string name)
        {
            var parts = (name ?? "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpperInvariant();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpperInvariant();
        }

        // ---------------------------------------------------------------------
        // Navigation
        // ---------------------------------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowPage<DashBoardPage>(btnNavDashboard, "Overview");
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowPage<DashBoardPage>(btnNavDashboard, "Overview");
        }

        private void btnNavReservations_Click(object sender, EventArgs e)
        {
            ShowPage<ReservationsPage>(btnNavReservations, "Reservations");
        }

        private void btnNavEquipment_Click(object sender, EventArgs e)
        {
            ShowPage<EquipmentPage>(btnNavEquipment, "Equipment");
        }

        private void btnNavHistory_Click(object sender, EventArgs e)
        {
            ShowPage<HistoryPage>(btnNavHistory, "History");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var handler = LogoutRequested;
            if (handler == null)
            {
                Close();
            }
            else
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------------------------------------------------------------------
        // Notifications popup (mockup page 5)
        // ---------------------------------------------------------------------

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            // Clicking the bell while the popup is open: the popup already closed itself when it lost focus
            // (mouse-down), so ignore the click that follows, which makes the bell behave like a toggle.
            if (_popup != null && !_popup.IsDisposed)
            {
                _popup.Close();
                return;
            }
            if (Environment.TickCount64 - _popupClosedTick < 300)
            {
                return;
            }

            var popup = new NotificationPopup();
            var handler = NotificationsOpening;
            if (handler != null)
            {
                handler(this, popup);
            }
            else
            {
                AddSampleNotifications(popup);
            }

            popup.FormClosed += (s, args) =>
            {
                _popupClosedTick = Environment.TickCount64;
                _popup = null;
            };
            _popup = popup;
            popup.ShowBelow(this, btnNotifications);
        }

        private static void AddSampleNotifications(NotificationPopup popup)
        {
            popup.AddNotification(ActivityKind.Approved, "PJ-03 request approved", "2 min ago", true);
            popup.AddNotification(ActivityKind.Rejected, "PJ-07 request rejected", "1 hour ago", true);
            popup.AddNotification(ActivityKind.Returned, "PJ-05 marked as returned", "Yesterday", false);
        }

        /// <summary>Shows a page inside the center canvas (each page is created once and reused).</summary>
        private void ShowPage<T>(RoundedButton activeNav, string title) where T : UserControl, new()
        {
            if (!_pages.TryGetValue(typeof(T), out var page))
            {
                page = new T { Dock = DockStyle.Fill, BackColor = Theme.Canvas };
                _pages[typeof(T)] = page;
            }

            pnlPageHost.SuspendLayout();
            pnlPageHost.Controls.Clear();   // pages are cached, so Clear() does not lose them
            pnlPageHost.Controls.Add(page);
            pnlPageHost.ResumeLayout(true);

            lblPageTitle.Text = title;
            SetActiveNav(activeNav);
        }

        private void SetActiveNav(RoundedButton active)
        {
            foreach (var button in _navButtons)
            {
                bool isActive = button == active;
                button.BackColor = isActive ? Theme.BrandSoft : Theme.Surface;
                button.HoverColor = isActive ? Theme.BrandSoft : Theme.Canvas;
                button.ForeColor = isActive ? Theme.Brand : Theme.InkMuted;
                button.Font = isActive ? Theme.BodyBold : Theme.Body;
            }
        }

        // TODO (not wired yet, because no matching screens/logic exist in the project):
        //   btnNewReservation  -> open the "new reservation" flow
        //   btnSettings, btnMore, txtSearch -> settings / more menu / search
    }
}
