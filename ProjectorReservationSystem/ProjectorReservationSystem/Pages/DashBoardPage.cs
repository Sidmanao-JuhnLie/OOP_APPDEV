using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectorReservationSystem.Pages
{
    public partial class DashBoardPage : UserControl
    {
        public DashBoardPage()
        {
            InitializeComponent();

            // The project has no data layer yet, so show the mockup's sample numbers.
            // TODO: delete this call and call the Set... methods below with real data instead.
            LoadSampleData();
        }

        // ---------------------------------------------------------------------
        // Public API: call these with real numbers when the data layer exists.
        // ---------------------------------------------------------------------

        /// <summary>Projector counts by condition (hero card + "Total projectors" card).</summary>
        public void SetProjectorSummary(int total, int available, int inUse, int underRepair, int broken)
        {
            lblHeroValue.Text = available.ToString();
            lblHeroSub.Text = $"of {total} projectors";
            lblInUseVal.Text = inUse.ToString();
            lblRepairVal.Text = underRepair.ToString();

            lblTotalNum.Text = total.ToString();
            lblAvailableCount.Text = available.ToString();
            lblInUseCount.Text = inUse.ToString();
            lblRepairCount.Text = underRepair.ToString();
            lblBrokenCount.Text = broken.ToString();
        }

        /// <summary>"Request status" card. Bar lengths are relative to the total number of requests.</summary>
        public void SetRequestStatus(int pending, int approved, int rejected)
        {
            int total = Math.Max(1, pending + approved + rejected);

            lblPendingCount.Text = pending.ToString();
            lblApprovedCount.Text = approved.ToString();
            lblRejectedCount.Text = rejected.ToString();

            progPending.Maximum = total;
            progApproved.Maximum = total;
            progRejected.Maximum = total;
            progPending.Value = pending;
            progApproved.Value = approved;
            progRejected.Value = rejected;
        }

        /// <summary>"Reservations per day" chart: one label and one value per day for each week.</summary>
        public void SetReservationsPerDay(string[] dayLabels, double[] thisWeek, double[] lastWeek)
        {
            chartPerDay.SetData(dayLabels, thisWeek, lastWeek);
        }

        private void LoadSampleData()
        {
            SetProjectorSummary(total: 12, available: 8, inUse: 3, underRepair: 1, broken: 0);
            SetRequestStatus(pending: 2, approved: 6, rejected: 2);
            SetReservationsPerDay(
                new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" },
                new double[] { 5, 8, 6, 9, 7, 3, 1 },
                new double[] { 4, 6, 7, 5, 6, 2, 1 });
        }
    }
}
