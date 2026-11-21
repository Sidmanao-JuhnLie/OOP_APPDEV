namespace ProjectorReservationSystem.Pages
{
    partial class EquipmentPage
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
            cardRepairs = new ProjectorReservationSystem.Controls.RoundedPanel();
            dgvRepairLogs = new DataGridView();
            colRepairDate = new DataGridViewTextBoxColumn();
            colRepairProjector = new DataGridViewTextBoxColumn();
            colIssue = new DataGridViewTextBoxColumn();
            colTechnician = new DataGridViewTextBoxColumn();
            colRepairStatus = new DataGridViewTextBoxColumn();
            pnlLogsHeader = new Panel();
            lblRepairLogs = new Label();
            cardProjectors = new ProjectorReservationSystem.Controls.RoundedPanel();
            dgvProjectors = new DataGridView();
            colProjector = new DataGridViewTextBoxColumn();
            colModel = new DataGridViewTextBoxColumn();
            colCondition = new DataGridViewTextBoxColumn();
            colChecked = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            pnlToolbar = new Panel();
            lblProjectorsTitle = new Label();
            btnUpdateCondition = new ProjectorReservationSystem.Controls.RoundedButton();
            btnLogRepair = new ProjectorReservationSystem.Controls.RoundedButton();
            cardRepairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepairLogs).BeginInit();
            pnlLogsHeader.SuspendLayout();
            cardProjectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjectors).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            //
            // cardRepairs
            //
            cardRepairs.BackColor = Color.White;
            cardRepairs.BorderColor = Color.FromArgb(236, 236, 244);
            cardRepairs.Controls.Add(dgvRepairLogs);
            cardRepairs.CornerRadius = 16;
            cardRepairs.Dock = DockStyle.Fill;
            cardRepairs.Location = new Point(0, 356);
            cardRepairs.Name = "cardRepairs";
            cardRepairs.Padding = new Padding(1, 6, 1, 6);
            cardRepairs.Size = new Size(676, 192);
            cardRepairs.TabIndex = 0;
            //
            // dgvRepairLogs
            //
            dgvRepairLogs.Columns.AddRange(new DataGridViewColumn[] { colRepairDate, colRepairProjector, colIssue, colTechnician, colRepairStatus });
            dgvRepairLogs.Dock = DockStyle.Fill;
            dgvRepairLogs.Location = new Point(1, 6);
            dgvRepairLogs.Name = "dgvRepairLogs";
            dgvRepairLogs.Size = new Size(674, 180);
            dgvRepairLogs.TabIndex = 0;
            dgvRepairLogs.CellPainting += dgvRepairLogs_CellPainting;
            //
            // colRepairDate
            //
            colRepairDate.FillWeight = 14F;
            colRepairDate.HeaderText = "Date";
            colRepairDate.MinimumWidth = 40;
            colRepairDate.Name = "colRepairDate";
            colRepairDate.ReadOnly = true;
            //
            // colRepairProjector
            //
            colRepairProjector.FillWeight = 16F;
            colRepairProjector.HeaderText = "Projector";
            colRepairProjector.MinimumWidth = 40;
            colRepairProjector.Name = "colRepairProjector";
            colRepairProjector.ReadOnly = true;
            //
            // colIssue
            //
            colIssue.FillWeight = 32F;
            colIssue.HeaderText = "Issue";
            colIssue.MinimumWidth = 40;
            colIssue.Name = "colIssue";
            colIssue.ReadOnly = true;
            //
            // colTechnician
            //
            colTechnician.FillWeight = 20F;
            colTechnician.HeaderText = "Technician";
            colTechnician.MinimumWidth = 40;
            colTechnician.Name = "colTechnician";
            colTechnician.ReadOnly = true;
            //
            // colRepairStatus
            //
            colRepairStatus.FillWeight = 18F;
            colRepairStatus.HeaderText = "Status";
            colRepairStatus.MinimumWidth = 40;
            colRepairStatus.Name = "colRepairStatus";
            colRepairStatus.ReadOnly = true;
            //
            // pnlLogsHeader
            //
            pnlLogsHeader.BackColor = Color.FromArgb(246, 246, 252);
            pnlLogsHeader.Controls.Add(lblRepairLogs);
            pnlLogsHeader.Dock = DockStyle.Top;
            pnlLogsHeader.Location = new Point(0, 320);
            pnlLogsHeader.Name = "pnlLogsHeader";
            pnlLogsHeader.Size = new Size(676, 36);
            pnlLogsHeader.TabIndex = 1;
            //
            // lblRepairLogs
            //
            lblRepairLogs.AutoSize = true;
            lblRepairLogs.BackColor = Color.FromArgb(246, 246, 252);
            lblRepairLogs.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepairLogs.ForeColor = Color.FromArgb(31, 29, 59);
            lblRepairLogs.Location = new Point(0, 12);
            lblRepairLogs.Name = "lblRepairLogs";
            lblRepairLogs.Size = new Size(87, 20);
            lblRepairLogs.TabIndex = 0;
            lblRepairLogs.Text = "Repair logs";
            //
            // cardProjectors
            //
            cardProjectors.BackColor = Color.White;
            cardProjectors.BorderColor = Color.FromArgb(236, 236, 244);
            cardProjectors.Controls.Add(dgvProjectors);
            cardProjectors.CornerRadius = 16;
            cardProjectors.Dock = DockStyle.Top;
            cardProjectors.Location = new Point(0, 58);
            cardProjectors.Name = "cardProjectors";
            cardProjectors.Padding = new Padding(1, 6, 1, 6);
            cardProjectors.Size = new Size(676, 262);
            cardProjectors.TabIndex = 2;
            //
            // dgvProjectors
            //
            dgvProjectors.Columns.AddRange(new DataGridViewColumn[] { colProjector, colModel, colCondition, colChecked, colLocation });
            dgvProjectors.Dock = DockStyle.Fill;
            dgvProjectors.Location = new Point(1, 6);
            dgvProjectors.Name = "dgvProjectors";
            dgvProjectors.Size = new Size(674, 250);
            dgvProjectors.TabIndex = 0;
            dgvProjectors.CellPainting += dgvProjectors_CellPainting;
            //
            // colProjector
            //
            colProjector.FillWeight = 14F;
            colProjector.HeaderText = "Projector";
            colProjector.MinimumWidth = 40;
            colProjector.Name = "colProjector";
            colProjector.ReadOnly = true;
            //
            // colModel
            //
            colModel.FillWeight = 16F;
            colModel.HeaderText = "Model";
            colModel.MinimumWidth = 40;
            colModel.Name = "colModel";
            colModel.ReadOnly = true;
            //
            // colCondition
            //
            colCondition.FillWeight = 24F;
            colCondition.HeaderText = "Condition";
            colCondition.MinimumWidth = 40;
            colCondition.Name = "colCondition";
            colCondition.ReadOnly = true;
            //
            // colChecked
            //
            colChecked.FillWeight = 18F;
            colChecked.HeaderText = "Checked";
            colChecked.MinimumWidth = 40;
            colChecked.Name = "colChecked";
            colChecked.ReadOnly = true;
            //
            // colLocation
            //
            colLocation.FillWeight = 28F;
            colLocation.HeaderText = "Location";
            colLocation.MinimumWidth = 40;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            //
            // pnlToolbar
            //
            pnlToolbar.BackColor = Color.FromArgb(246, 246, 252);
            pnlToolbar.Controls.Add(btnLogRepair);
            pnlToolbar.Controls.Add(btnUpdateCondition);
            pnlToolbar.Controls.Add(lblProjectorsTitle);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(676, 58);
            pnlToolbar.TabIndex = 3;
            //
            // lblProjectorsTitle
            //
            lblProjectorsTitle.AutoSize = true;
            lblProjectorsTitle.BackColor = Color.FromArgb(246, 246, 252);
            lblProjectorsTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjectorsTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblProjectorsTitle.Location = new Point(0, 12);
            lblProjectorsTitle.Name = "lblProjectorsTitle";
            lblProjectorsTitle.Size = new Size(68, 20);
            lblProjectorsTitle.TabIndex = 0;
            lblProjectorsTitle.Text = "Projectors";
            //
            // btnUpdateCondition
            //
            btnUpdateCondition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateCondition.BackColor = Color.White;
            btnUpdateCondition.BorderColor = Color.FromArgb(236, 236, 244);
            btnUpdateCondition.Cursor = Cursors.Hand;
            btnUpdateCondition.FlatAppearance.BorderSize = 0;
            btnUpdateCondition.FlatStyle = FlatStyle.Flat;
            btnUpdateCondition.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateCondition.ForeColor = Color.FromArgb(31, 29, 59);
            btnUpdateCondition.HoverColor = Color.FromArgb(239, 236, 254);
            btnUpdateCondition.Location = new Point(388, 0);
            btnUpdateCondition.Name = "btnUpdateCondition";
            btnUpdateCondition.Size = new Size(158, 44);
            btnUpdateCondition.TabIndex = 1;
            btnUpdateCondition.Text = "Update condition";
            btnUpdateCondition.UseVisualStyleBackColor = false;
            btnUpdateCondition.Click += btnUpdateCondition_Click;
            //
            // btnLogRepair
            //
            btnLogRepair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogRepair.BackColor = Color.FromArgb(91, 63, 245);
            btnLogRepair.Cursor = Cursors.Hand;
            btnLogRepair.FlatAppearance.BorderSize = 0;
            btnLogRepair.FlatStyle = FlatStyle.Flat;
            btnLogRepair.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogRepair.ForeColor = Color.White;
            btnLogRepair.Location = new Point(558, 0);
            btnLogRepair.Name = "btnLogRepair";
            btnLogRepair.Size = new Size(118, 44);
            btnLogRepair.TabIndex = 2;
            btnLogRepair.Text = "Log repair";
            btnLogRepair.UseVisualStyleBackColor = false;
            btnLogRepair.Click += btnLogRepair_Click;
            //
            // EquipmentPage
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(246, 246, 252);
            Controls.Add(cardRepairs);
            Controls.Add(pnlLogsHeader);
            Controls.Add(cardProjectors);
            Controls.Add(pnlToolbar);
            Name = "EquipmentPage";
            Size = new Size(676, 548);
            cardRepairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepairLogs).EndInit();
            pnlLogsHeader.ResumeLayout(false);
            pnlLogsHeader.PerformLayout();
            cardProjectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjectors).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProjectorReservationSystem.Controls.RoundedPanel cardRepairs;
        private DataGridView dgvRepairLogs;
        private DataGridViewTextBoxColumn colRepairDate;
        private DataGridViewTextBoxColumn colRepairProjector;
        private DataGridViewTextBoxColumn colIssue;
        private DataGridViewTextBoxColumn colTechnician;
        private DataGridViewTextBoxColumn colRepairStatus;
        private Panel pnlLogsHeader;
        private Label lblRepairLogs;
        private ProjectorReservationSystem.Controls.RoundedPanel cardProjectors;
        private DataGridView dgvProjectors;
        private DataGridViewTextBoxColumn colProjector;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colCondition;
        private DataGridViewTextBoxColumn colChecked;
        private DataGridViewTextBoxColumn colLocation;
        private Panel pnlToolbar;
        private Label lblProjectorsTitle;
        private ProjectorReservationSystem.Controls.RoundedButton btnUpdateCondition;
        private ProjectorReservationSystem.Controls.RoundedButton btnLogRepair;
    }
}
