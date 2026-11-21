namespace ProjectorReservationSystem.Pages
{
    partial class ReservationsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardGrid = new ProjectorReservationSystem.Controls.RoundedPanel();
            dgvReservations = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colBorrower = new DataGridViewTextBoxColumn();
            colProjector = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlSpacer = new Panel();
            pnlTimelineCard = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblTimelineTitle = new Label();
            stepTracker = new ProjectorReservationSystem.Controls.StepTracker();
            pnlToolbar = new Panel();
            pnlStatusBox = new ProjectorReservationSystem.Controls.RoundedPanel();
            cboStatus = new ComboBox();
            btnNewReservationPage = new ProjectorReservationSystem.Controls.RoundedButton();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            pnlTimelineCard.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlStatusBox.SuspendLayout();
            SuspendLayout();
            //
            // cardGrid
            //
            cardGrid.BackColor = Color.White;
            cardGrid.BorderColor = Color.FromArgb(236, 236, 244);
            cardGrid.Controls.Add(dgvReservations);
            cardGrid.CornerRadius = 16;
            cardGrid.Dock = DockStyle.Fill;
            cardGrid.Location = new Point(0, 62);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(1, 8, 1, 8);
            cardGrid.Size = new Size(676, 346);
            cardGrid.TabIndex = 0;
            //
            // dgvReservations
            //
            dgvReservations.Columns.AddRange(new DataGridViewColumn[] { colId, colBorrower, colProjector, colDate, colTime, colStatus });
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(1, 8);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(674, 330);
            dgvReservations.TabIndex = 0;
            dgvReservations.CellPainting += dgvReservations_CellPainting;
            dgvReservations.SelectionChanged += dgvReservations_SelectionChanged;
            //
            // colId
            //
            colId.FillWeight = 11F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 40;
            colId.Name = "colId";
            colId.ReadOnly = true;
            //
            // colBorrower
            //
            colBorrower.FillWeight = 20F;
            colBorrower.HeaderText = "Borrower";
            colBorrower.MinimumWidth = 40;
            colBorrower.Name = "colBorrower";
            colBorrower.ReadOnly = true;
            //
            // colProjector
            //
            colProjector.FillWeight = 15F;
            colProjector.HeaderText = "Projector";
            colProjector.MinimumWidth = 40;
            colProjector.Name = "colProjector";
            colProjector.ReadOnly = true;
            //
            // colDate
            //
            colDate.FillWeight = 14F;
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 40;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            //
            // colTime
            //
            colTime.FillWeight = 18F;
            colTime.HeaderText = "Time";
            colTime.MinimumWidth = 40;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            //
            // colStatus
            //
            colStatus.FillWeight = 22F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 40;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            //
            // pnlSpacer
            //
            pnlSpacer.BackColor = Color.FromArgb(246, 246, 252);
            pnlSpacer.Dock = DockStyle.Bottom;
            pnlSpacer.Location = new Point(0, 408);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Size = new Size(676, 16);
            pnlSpacer.TabIndex = 1;
            //
            // pnlTimelineCard
            //
            pnlTimelineCard.BackColor = Color.White;
            pnlTimelineCard.BorderColor = Color.FromArgb(236, 236, 244);
            pnlTimelineCard.Controls.Add(stepTracker);
            pnlTimelineCard.Controls.Add(lblTimelineTitle);
            pnlTimelineCard.CornerRadius = 16;
            pnlTimelineCard.Dock = DockStyle.Bottom;
            pnlTimelineCard.Location = new Point(0, 424);
            pnlTimelineCard.Name = "pnlTimelineCard";
            pnlTimelineCard.Size = new Size(676, 124);
            pnlTimelineCard.TabIndex = 2;
            //
            // lblTimelineTitle
            //
            lblTimelineTitle.AutoSize = true;
            lblTimelineTitle.BackColor = Color.White;
            lblTimelineTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimelineTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblTimelineTitle.Location = new Point(24, 16);
            lblTimelineTitle.Name = "lblTimelineTitle";
            lblTimelineTitle.Size = new Size(240, 20);
            lblTimelineTitle.TabIndex = 0;
            lblTimelineTitle.Text = "Request R-1045 · Maria Santos · PJ-03";
            //
            // stepTracker
            //
            stepTracker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stepTracker.BackColor = Color.Transparent;
            stepTracker.CurrentStep = 3;
            stepTracker.Location = new Point(24, 50);
            stepTracker.Name = "stepTracker";
            stepTracker.Size = new Size(628, 64);
            stepTracker.TabIndex = 1;
            stepTracker.TabStop = false;
            //
            // pnlToolbar
            //
            pnlToolbar.BackColor = Color.FromArgb(246, 246, 252);
            pnlToolbar.Controls.Add(btnNewReservationPage);
            pnlToolbar.Controls.Add(pnlStatusBox);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(676, 62);
            pnlToolbar.TabIndex = 3;
            //
            // pnlStatusBox
            //
            pnlStatusBox.BackColor = Color.White;
            pnlStatusBox.BorderColor = Color.FromArgb(236, 236, 244);
            pnlStatusBox.Controls.Add(cboStatus);
            pnlStatusBox.CornerRadius = 12;
            pnlStatusBox.Location = new Point(0, 0);
            pnlStatusBox.Name = "pnlStatusBox";
            pnlStatusBox.Size = new Size(160, 46);
            pnlStatusBox.TabIndex = 0;
            //
            // cboStatus
            //
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.BackColor = Color.White;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.ForeColor = Color.FromArgb(31, 29, 59);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All statuses", "Pending", "Approved", "Rejected", "In Use", "Returned" });
            cboStatus.Location = new Point(10, 9);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(140, 28);
            cboStatus.TabIndex = 0;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            //
            // btnNewReservationPage
            //
            btnNewReservationPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewReservationPage.BackColor = Color.FromArgb(91, 63, 245);
            btnNewReservationPage.Cursor = Cursors.Hand;
            btnNewReservationPage.FlatAppearance.BorderSize = 0;
            btnNewReservationPage.FlatStyle = FlatStyle.Flat;
            btnNewReservationPage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewReservationPage.ForeColor = Color.White;
            btnNewReservationPage.Location = new Point(526, 0);
            btnNewReservationPage.Name = "btnNewReservationPage";
            btnNewReservationPage.Size = new Size(150, 46);
            btnNewReservationPage.TabIndex = 1;
            btnNewReservationPage.Text = "New reservation";
            btnNewReservationPage.UseVisualStyleBackColor = false;
            //
            // ReservationsPage
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(246, 246, 252);
            Controls.Add(cardGrid);
            Controls.Add(pnlSpacer);
            Controls.Add(pnlTimelineCard);
            Controls.Add(pnlToolbar);
            Name = "ReservationsPage";
            Size = new Size(676, 548);
            cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            pnlTimelineCard.ResumeLayout(false);
            pnlTimelineCard.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlStatusBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProjectorReservationSystem.Controls.RoundedPanel cardGrid;
        private DataGridView dgvReservations;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBorrower;
        private DataGridViewTextBoxColumn colProjector;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colStatus;
        private Panel pnlSpacer;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlTimelineCard;
        private Label lblTimelineTitle;
        private ProjectorReservationSystem.Controls.StepTracker stepTracker;
        private Panel pnlToolbar;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlStatusBox;
        private ComboBox cboStatus;
        private ProjectorReservationSystem.Controls.RoundedButton btnNewReservationPage;
    }
}
