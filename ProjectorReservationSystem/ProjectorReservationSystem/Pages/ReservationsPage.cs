using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Pages
{
    public partial class ReservationsPage : UserControl
    {
        private const string AllStatuses = "All statuses";

        public ReservationsPage()
        {
            InitializeComponent();
            UiHelper.StyleGrid(dgvReservations);
            cboStatus.SelectedIndex = 0;

            // The project has no data layer yet, so show the mockup's sample rows.
            // TODO: delete this call and fill the table with AddReservationRow(...) from real data instead.
            LoadSampleData();
        }

        // ---------------------------------------------------------------------
        // Public API: call these with real reservation data when it exists.
        // ---------------------------------------------------------------------

        public void ClearReservations()
        {
            dgvReservations.Rows.Clear();
            UpdateTimeline();
        }

        /// <summary>Adds one row. Status should be one of: Pending, Approved, Rejected, In Use, Returned.</summary>
        public void AddReservationRow(string id, string borrower, string projector, string date, string time, string status)
        {
            dgvReservations.Rows.Add(id, borrower, projector, date, time, status);
        }

        // ---------------------------------------------------------------------
        // Behavior
        // ---------------------------------------------------------------------

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTimeline();
        }

        /// <summary>Paints the Status column as a colored pill; every other cell is painted normally.</summary>
        private void dgvReservations_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colStatus.Index || e.Graphics == null) return;

            // background, selection color and the row's bottom hairline, but not the text
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            float scale = dgvReservations.DeviceDpi / 96f;
            UiHelper.DrawStatusPill(e.Graphics, e.CellBounds, Convert.ToString(e.Value), (int)Math.Round(12 * scale), scale);
            e.Handled = true;
        }

        private void ApplyFilter()
        {
            string filter = cboStatus.SelectedItem as string ?? AllStatuses;

            dgvReservations.CurrentCell = null;   // a row can only be hidden when it is not the current one
            foreach (DataGridViewRow row in dgvReservations.Rows)
            {
                string status = Convert.ToString(row.Cells[colStatus.Index].Value) ?? "";
                row.Visible = filter == AllStatuses || status == filter;
            }

            foreach (DataGridViewRow row in dgvReservations.Rows)
            {
                if (row.Visible)
                {
                    dgvReservations.CurrentCell = row.Cells[0];
                    break;
                }
            }

            UpdateTimeline();
        }

        /// <summary>Shows the progress timeline of the selected reservation.</summary>
        private void UpdateTimeline()
        {
            var row = dgvReservations.CurrentRow;
            if (row == null || !row.Visible)
            {
                lblTimelineTitle.Text = "No reservation selected";
                stepTracker.Visible = false;
                return;
            }

            string id = Convert.ToString(row.Cells[colId.Index].Value) ?? "";
            string borrower = Convert.ToString(row.Cells[colBorrower.Index].Value) ?? "";
            string projector = Convert.ToString(row.Cells[colProjector.Index].Value) ?? "";
            string status = Convert.ToString(row.Cells[colStatus.Index].Value) ?? "";

            lblTimelineTitle.Text = $"Request {id} · {borrower} · {projector}";
            stepTracker.CurrentColor = Theme.Brand;

            switch (status)
            {
                case "Pending":  stepTracker.CurrentStep = 2; break;   // waiting in "Under Review"
                case "Approved": stepTracker.CurrentStep = 3; break;
                case "In Use":   stepTracker.CurrentStep = 4; break;   // picked up
                case "Returned": stepTracker.CurrentStep = 6; break;   // beyond the last step = all done
                case "Rejected":
                    stepTracker.CurrentStep = 2;                       // stopped at "Under Review"
                    stepTracker.CurrentColor = Theme.Danger;
                    break;
                default:         stepTracker.CurrentStep = 1; break;
            }
            stepTracker.Visible = true;
        }

        private void LoadSampleData()
        {
            AddReservationRow("R-1046", "Liza Tan",    "PJ-02", "Nov 18", "9:00 - 11:00",  "Pending");
            AddReservationRow("R-1045", "Maria Santos", "PJ-03", "Nov 17", "1:00 - 3:00",   "Approved");
            AddReservationRow("R-1044", "Carlo Reyes", "PJ-07", "Nov 17", "10:00 - 12:00", "Rejected");
            AddReservationRow("R-1043", "Ana Lim",     "PJ-01", "Nov 16", "8:00 - 10:00",  "In Use");
            AddReservationRow("R-1042", "Paolo Cruz",  "PJ-05", "Nov 15", "2:00 - 4:00",   "Returned");

            if (dgvReservations.Rows.Count > 1)
            {
                dgvReservations.CurrentCell = dgvReservations.Rows[1].Cells[0];   // mockup shows R-1045 selected
            }
        }
    }
}
