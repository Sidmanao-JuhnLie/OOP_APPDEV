using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ProjectorReservationSystem.Controls;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Pages
{
    public partial class HistoryPage : UserControl
    {
        /// <summary>
        /// Raised whenever a projector is selected in the list (the timeline has already been cleared
        /// and its title updated). The project has no history data yet, so the page only announces the
        /// selection; whoever owns the data subscribes and answers with AddBorrowerHistoryEntry(...).
        /// </summary>
        public event EventHandler<string>? ProjectorSelected;

        public HistoryPage()
        {
            InitializeComponent();
            lstProjectors.ItemHeight = LogicalToDeviceUnits(46);   // not auto-scaled by WinForms

            // The project has no data layer yet, so show the mockup's sample data.
            // TODO: delete this call, subscribe to ProjectorSelected and fill the page from real data instead.
            LoadSampleData();
        }

        // ---------------------------------------------------------------------
        // Public API: call these with real data when it exists.
        // ---------------------------------------------------------------------

        public void ClearProjectors() => lstProjectors.Items.Clear();

        public void AddProjector(string projectorId) => lstProjectors.Items.Add(projectorId);

        public void SelectProjector(string projectorId)
        {
            int index = lstProjectors.Items.IndexOf(projectorId);
            if (index >= 0) lstProjectors.SelectedIndex = index;
        }

        public void ClearBorrowerHistory() => timelineHistory.Clear();

        /// <summary>Adds one timeline entry (newest first). Status e.g. Approved, In Use, Returned.</summary>
        public void AddBorrowerHistoryEntry(string date, string borrower, string status)
        {
            timelineHistory.AddItem(date, borrower, status);
        }

        // ---------------------------------------------------------------------
        // Behavior
        // ---------------------------------------------------------------------

        private void lstProjectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            timelineHistory.Clear();

            if (lstProjectors.SelectedItem is not string projectorId)
            {
                lblHistoryTitle.Text = "Borrower history";
                return;
            }

            lblHistoryTitle.Text = $"{projectorId} · Borrower history";
            ProjectorSelected?.Invoke(this, projectorId);
        }

        /// <summary>The selected projector is highlighted with a light purple pill and purple text.</summary>
        private void lstProjectors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            using (var background = new SolidBrush(lstProjectors.BackColor))
            {
                g.FillRectangle(background, e.Bounds);
            }

            float s = lstProjectors.DeviceDpi / 96f;
            int inset = (int)Math.Round(12 * s);
            var pill = Rectangle.Inflate(e.Bounds, 0, -(int)Math.Round(3 * s));
            if (selected)
            {
                using (var path = RoundedPanel.RoundedRect(pill, inset))
                using (var brush = new SolidBrush(Theme.BrandSoft))
                {
                    g.FillPath(brush, path);
                }
            }

            string text = Convert.ToString(lstProjectors.Items[e.Index]) ?? "";
            TextRenderer.DrawText(g, text, selected ? Theme.BodyBold : Theme.Body,
                new Rectangle(pill.X + inset, pill.Y, Math.Max(0, pill.Width - inset), pill.Height),
                selected ? Theme.Brand : Theme.Ink,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix);
        }

        // ---------------------------------------------------------------------
        // Sample data (remove when real data is connected)
        // ---------------------------------------------------------------------

        private void LoadSampleData()
        {
            ProjectorSelected += ShowSampleHistory;

            foreach (var id in new[] { "PJ-01", "PJ-02", "PJ-03", "PJ-04", "PJ-05" })
            {
                AddProjector(id);
            }
            SelectProjector("PJ-03");
        }

        private void ShowSampleHistory(object? sender, string projectorId)
        {
            switch (projectorId)
            {
                case "PJ-01":
                    AddBorrowerHistoryEntry("Nov 16, 2026", "Ana Lim", "In Use");
                    break;
                case "PJ-02":
                    AddBorrowerHistoryEntry("Nov 18, 2026", "Liza Tan", "Pending");
                    break;
                case "PJ-03":
                    AddBorrowerHistoryEntry("Nov 17, 2026", "Maria Santos", "Approved");
                    AddBorrowerHistoryEntry("Nov 08, 2026", "Joy Garcia", "Returned");
                    AddBorrowerHistoryEntry("Oct 30, 2026", "Paolo Cruz", "Returned");
                    AddBorrowerHistoryEntry("Oct 21, 2026", "Ana Lim", "Returned");
                    AddBorrowerHistoryEntry("Oct 14, 2026", "Carlo Reyes", "Returned");
                    break;
                case "PJ-05":
                    AddBorrowerHistoryEntry("Nov 15, 2026", "Paolo Cruz", "Returned");
                    break;
                // PJ-04: no entries, so the timeline shows its "No borrower history yet" text
            }
        }
    }
}
