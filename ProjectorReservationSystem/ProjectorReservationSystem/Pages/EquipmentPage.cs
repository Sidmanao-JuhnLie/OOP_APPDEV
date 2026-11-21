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
    public partial class EquipmentPage : UserControl
    {
        /// <summary>
        /// Raised when the user clicks "Update condition". The project has no equipment-update
        /// functionality yet, so the page only announces the click; whoever owns that logic
        /// subscribes and reads <see cref="SelectedProjector"/> to know which projector is meant.
        /// </summary>
        public event EventHandler? UpdateConditionRequested;

        /// <summary>Raised when the user clicks "Log repair" (same idea as above).</summary>
        public event EventHandler? LogRepairRequested;

        public EquipmentPage()
        {
            InitializeComponent();
            UiHelper.StyleGrid(dgvProjectors);
            UiHelper.StyleGrid(dgvRepairLogs);

            // The project has no data layer yet, so show the mockup's sample rows.
            // TODO: delete this call and fill the tables with AddProjectorRow / AddRepairLogRow from real data.
            LoadSampleData();
        }

        // ---------------------------------------------------------------------
        // Public API: call these with real data when it exists.
        // ---------------------------------------------------------------------

        /// <summary>Projector ID (e.g. "PJ-03") of the selected row in the projector table, or null if none.</summary>
        public string? SelectedProjector
        {
            get
            {
                var row = dgvProjectors.CurrentRow;
                return row == null ? null : Convert.ToString(row.Cells[colProjector.Index].Value);
            }
        }

        public void ClearProjectors() => dgvProjectors.Rows.Clear();

        /// <summary>Condition should be one of: Available, In Use, Under Repair, Broken.</summary>
        public void AddProjectorRow(string projector, string model, string condition, string lastChecked, string location)
        {
            dgvProjectors.Rows.Add(projector, model, condition, lastChecked, location);
        }

        public void ClearRepairLogs() => dgvRepairLogs.Rows.Clear();

        /// <summary>Status should be e.g. "Under Repair" or "Completed".</summary>
        public void AddRepairLogRow(string date, string projector, string issue, string technician, string status)
        {
            dgvRepairLogs.Rows.Add(date, projector, issue, technician, status);
        }

        // ---------------------------------------------------------------------
        // Behavior
        // ---------------------------------------------------------------------

        private void btnUpdateCondition_Click(object sender, EventArgs e)
        {
            UpdateConditionRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogRepair_Click(object sender, EventArgs e)
        {
            LogRepairRequested?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>Paints the Condition column as a colored pill.</summary>
        private void dgvProjectors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PaintPillCell(sender, e, colCondition.Index);
        }

        /// <summary>Paints the repair Status column as a colored pill.</summary>
        private void dgvRepairLogs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PaintPillCell(sender, e, colRepairStatus.Index);
        }

        private static void PaintPillCell(object? sender, DataGridViewCellPaintingEventArgs e, int pillColumn)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != pillColumn || e.Graphics == null) return;

            // background, selection color and the row's bottom hairline, but not the text
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            float scale = ((sender as DataGridView)?.DeviceDpi ?? 96) / 96f;
            UiHelper.DrawStatusPill(e.Graphics, e.CellBounds, Convert.ToString(e.Value), (int)Math.Round(12 * scale), scale);
            e.Handled = true;
        }

        private void LoadSampleData()
        {
            AddProjectorRow("PJ-01", "Mini M1", "In Use",       "Nov 10", "AV Room");
            AddProjectorRow("PJ-02", "Mini M1", "Available",    "Nov 12", "AV Room");
            AddProjectorRow("PJ-03", "Mini M2", "Available",    "Nov 09", "AV Room");
            AddProjectorRow("PJ-06", "Mini M2", "Under Repair", "Nov 12", "Repair desk");
            AddProjectorRow("PJ-07", "Mini M1", "Broken",       "Nov 05", "Repair desk");

            AddRepairLogRow("Nov 12", "PJ-06", "Lamp not turning on", "Ramon D.", "Under Repair");
            AddRepairLogRow("Oct 28", "PJ-02", "Cracked lens cover",  "Ramon D.", "Completed");
            AddRepairLogRow("Oct 05", "PJ-04", "Loose HDMI port",     "Ramon D.", "Completed");

            // The mockup shows no highlighted row in either table.
            dgvProjectors.CurrentCell = null;
            dgvRepairLogs.CurrentCell = null;
        }
    }
}
