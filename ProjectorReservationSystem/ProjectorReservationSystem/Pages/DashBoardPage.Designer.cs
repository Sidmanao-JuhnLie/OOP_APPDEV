namespace ProjectorReservationSystem.Pages
{
    partial class DashBoardPage
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
            tlpMain = new TableLayoutPanel();
            tlpTop = new TableLayoutPanel();
            cardHero = new ProjectorReservationSystem.Controls.GradientPanel();
            lblHeroTitle = new Label();
            lblHeroValue = new Label();
            lblHeroSub = new Label();
            lblInUseCap = new Label();
            lblInUseVal = new Label();
            lblRepairCap = new Label();
            lblRepairVal = new Label();
            cardRequests = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblReqTitle = new Label();
            lblReqWeek = new Label();
            lblPendingName = new Label();
            lblPendingCount = new Label();
            progPending = new ProjectorReservationSystem.Controls.RoundedProgress();
            lblApprovedName = new Label();
            lblApprovedCount = new Label();
            progApproved = new ProjectorReservationSystem.Controls.RoundedProgress();
            lblRejectedName = new Label();
            lblRejectedCount = new Label();
            progRejected = new ProjectorReservationSystem.Controls.RoundedProgress();
            tlpBottom = new TableLayoutPanel();
            cardChart = new ProjectorReservationSystem.Controls.RoundedPanel();
            chartPerDay = new ProjectorReservationSystem.Controls.BarChart();
            cardTotals = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblTotalNum = new Label();
            lblTotalCap = new Label();
            dotAvailable = new ProjectorReservationSystem.Controls.CircleBadge();
            lblAvailableName = new Label();
            lblAvailableCount = new Label();
            dotInUse = new ProjectorReservationSystem.Controls.CircleBadge();
            lblInUseName = new Label();
            lblInUseCount = new Label();
            dotRepair = new ProjectorReservationSystem.Controls.CircleBadge();
            lblRepairName = new Label();
            lblRepairCount = new Label();
            dotBroken = new ProjectorReservationSystem.Controls.CircleBadge();
            lblBrokenName = new Label();
            lblBrokenCount = new Label();
            tlpMain.SuspendLayout();
            tlpTop.SuspendLayout();
            cardHero.SuspendLayout();
            cardRequests.SuspendLayout();
            tlpBottom.SuspendLayout();
            cardChart.SuspendLayout();
            cardTotals.SuspendLayout();
            SuspendLayout();
            //
            // tlpMain
            //
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpTop, 0, 0);
            tlpMain.Controls.Add(tlpBottom, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            tlpMain.Size = new Size(676, 548);
            tlpMain.TabIndex = 0;
            //
            // tlpTop
            //
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));
            tlpTop.Controls.Add(cardHero, 0, 0);
            tlpTop.Controls.Add(cardRequests, 1, 0);
            tlpTop.Dock = DockStyle.Fill;
            tlpTop.Location = new Point(0, 0);
            tlpTop.Margin = new Padding(0, 0, 0, 8);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(676, 200);
            tlpTop.TabIndex = 0;
            //
            // cardHero
            //
            cardHero.BackColor = Color.White;
            cardHero.Controls.Add(lblRepairVal);
            cardHero.Controls.Add(lblRepairCap);
            cardHero.Controls.Add(lblInUseVal);
            cardHero.Controls.Add(lblInUseCap);
            cardHero.Controls.Add(lblHeroSub);
            cardHero.Controls.Add(lblHeroValue);
            cardHero.Controls.Add(lblHeroTitle);
            cardHero.CornerRadius = 16;
            cardHero.Dock = DockStyle.Fill;
            cardHero.Location = new Point(0, 0);
            cardHero.Margin = new Padding(0, 0, 8, 0);
            cardHero.Name = "cardHero";
            cardHero.Size = new Size(303, 200);
            cardHero.TabIndex = 0;
            //
            // lblHeroTitle
            //
            lblHeroTitle.AutoSize = true;
            lblHeroTitle.BackColor = Color.Transparent;
            lblHeroTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeroTitle.ForeColor = Color.FromArgb(233, 229, 255);
            lblHeroTitle.Location = new Point(24, 20);
            lblHeroTitle.Name = "lblHeroTitle";
            lblHeroTitle.Size = new Size(104, 17);
            lblHeroTitle.TabIndex = 0;
            lblHeroTitle.Text = "Available projectors";
            //
            // lblHeroValue
            //
            lblHeroValue.AutoSize = true;
            lblHeroValue.BackColor = Color.Transparent;
            lblHeroValue.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeroValue.ForeColor = Color.White;
            lblHeroValue.Location = new Point(20, 38);
            lblHeroValue.Name = "lblHeroValue";
            lblHeroValue.Size = new Size(48, 59);
            lblHeroValue.TabIndex = 1;
            lblHeroValue.Text = "8";
            //
            // lblHeroSub
            //
            lblHeroSub.AutoSize = true;
            lblHeroSub.BackColor = Color.Transparent;
            lblHeroSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeroSub.ForeColor = Color.FromArgb(233, 229, 255);
            lblHeroSub.Location = new Point(24, 100);
            lblHeroSub.Name = "lblHeroSub";
            lblHeroSub.Size = new Size(80, 17);
            lblHeroSub.TabIndex = 2;
            lblHeroSub.Text = "of 12 projectors";
            //
            // lblInUseCap
            //
            lblInUseCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInUseCap.AutoSize = true;
            lblInUseCap.BackColor = Color.Transparent;
            lblInUseCap.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInUseCap.ForeColor = Color.FromArgb(233, 229, 255);
            lblInUseCap.Location = new Point(24, 138);
            lblInUseCap.Name = "lblInUseCap";
            lblInUseCap.Size = new Size(40, 15);
            lblInUseCap.TabIndex = 3;
            lblInUseCap.Text = "IN USE";
            //
            // lblInUseVal
            //
            lblInUseVal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInUseVal.AutoSize = true;
            lblInUseVal.BackColor = Color.Transparent;
            lblInUseVal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInUseVal.ForeColor = Color.White;
            lblInUseVal.Location = new Point(22, 154);
            lblInUseVal.Name = "lblInUseVal";
            lblInUseVal.Size = new Size(22, 25);
            lblInUseVal.TabIndex = 4;
            lblInUseVal.Text = "3";
            //
            // lblRepairCap
            //
            lblRepairCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRepairCap.AutoSize = true;
            lblRepairCap.BackColor = Color.Transparent;
            lblRepairCap.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepairCap.ForeColor = Color.FromArgb(233, 229, 255);
            lblRepairCap.Location = new Point(140, 138);
            lblRepairCap.Name = "lblRepairCap";
            lblRepairCap.Size = new Size(90, 15);
            lblRepairCap.TabIndex = 5;
            lblRepairCap.Text = "UNDER REPAIR";
            //
            // lblRepairVal
            //
            lblRepairVal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRepairVal.AutoSize = true;
            lblRepairVal.BackColor = Color.Transparent;
            lblRepairVal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepairVal.ForeColor = Color.White;
            lblRepairVal.Location = new Point(138, 154);
            lblRepairVal.Name = "lblRepairVal";
            lblRepairVal.Size = new Size(22, 25);
            lblRepairVal.TabIndex = 6;
            lblRepairVal.Text = "1";
            //
            // cardRequests
            //
            cardRequests.BackColor = Color.White;
            cardRequests.BorderColor = Color.FromArgb(236, 236, 244);
            cardRequests.Controls.Add(progRejected);
            cardRequests.Controls.Add(lblRejectedCount);
            cardRequests.Controls.Add(lblRejectedName);
            cardRequests.Controls.Add(progApproved);
            cardRequests.Controls.Add(lblApprovedCount);
            cardRequests.Controls.Add(lblApprovedName);
            cardRequests.Controls.Add(progPending);
            cardRequests.Controls.Add(lblPendingCount);
            cardRequests.Controls.Add(lblPendingName);
            cardRequests.Controls.Add(lblReqWeek);
            cardRequests.Controls.Add(lblReqTitle);
            cardRequests.CornerRadius = 16;
            cardRequests.Dock = DockStyle.Fill;
            cardRequests.Location = new Point(311, 0);
            cardRequests.Margin = new Padding(8, 0, 0, 0);
            cardRequests.Name = "cardRequests";
            cardRequests.Size = new Size(357, 200);
            cardRequests.TabIndex = 1;
            //
            // lblReqTitle
            //
            lblReqTitle.AutoSize = true;
            lblReqTitle.BackColor = Color.White;
            lblReqTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReqTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblReqTitle.Location = new Point(24, 16);
            lblReqTitle.Name = "lblReqTitle";
            lblReqTitle.Size = new Size(106, 20);
            lblReqTitle.TabIndex = 0;
            lblReqTitle.Text = "Request status";
            //
            // lblReqWeek
            //
            lblReqWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReqWeek.AutoSize = true;
            lblReqWeek.BackColor = Color.White;
            lblReqWeek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReqWeek.ForeColor = Color.FromArgb(107, 107, 138);
            lblReqWeek.Location = new Point(273, 19);
            lblReqWeek.Name = "lblReqWeek";
            lblReqWeek.Size = new Size(60, 17);
            lblReqWeek.TabIndex = 1;
            lblReqWeek.Text = "This week";
            //
            // lblPendingName
            //
            lblPendingName.AutoSize = true;
            lblPendingName.BackColor = Color.White;
            lblPendingName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingName.ForeColor = Color.FromArgb(31, 29, 59);
            lblPendingName.Location = new Point(24, 52);
            lblPendingName.Name = "lblPendingName";
            lblPendingName.Size = new Size(54, 19);
            lblPendingName.TabIndex = 2;
            lblPendingName.Text = "Pending";
            //
            // lblPendingCount
            //
            lblPendingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendingCount.BackColor = Color.White;
            lblPendingCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblPendingCount.Location = new Point(293, 52);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(40, 19);
            lblPendingCount.TabIndex = 3;
            lblPendingCount.Text = "2";
            lblPendingCount.TextAlign = ContentAlignment.TopRight;
            //
            // progPending
            //
            progPending.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progPending.BackColor = Color.Transparent;
            progPending.BarColor = Color.FromArgb(245, 158, 11);
            progPending.Location = new Point(24, 78);
            progPending.Maximum = 10;
            progPending.Name = "progPending";
            progPending.Size = new Size(309, 8);
            progPending.TabIndex = 4;
            progPending.TabStop = false;
            progPending.Value = 2;
            //
            // lblApprovedName
            //
            lblApprovedName.AutoSize = true;
            lblApprovedName.BackColor = Color.White;
            lblApprovedName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApprovedName.ForeColor = Color.FromArgb(31, 29, 59);
            lblApprovedName.Location = new Point(24, 98);
            lblApprovedName.Name = "lblApprovedName";
            lblApprovedName.Size = new Size(61, 19);
            lblApprovedName.TabIndex = 5;
            lblApprovedName.Text = "Approved";
            //
            // lblApprovedCount
            //
            lblApprovedCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblApprovedCount.BackColor = Color.White;
            lblApprovedCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApprovedCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblApprovedCount.Location = new Point(293, 98);
            lblApprovedCount.Name = "lblApprovedCount";
            lblApprovedCount.Size = new Size(40, 19);
            lblApprovedCount.TabIndex = 6;
            lblApprovedCount.Text = "6";
            lblApprovedCount.TextAlign = ContentAlignment.TopRight;
            //
            // progApproved
            //
            progApproved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progApproved.BackColor = Color.Transparent;
            progApproved.BarColor = Color.FromArgb(22, 163, 74);
            progApproved.Location = new Point(24, 124);
            progApproved.Maximum = 10;
            progApproved.Name = "progApproved";
            progApproved.Size = new Size(309, 8);
            progApproved.TabIndex = 7;
            progApproved.TabStop = false;
            progApproved.Value = 6;
            //
            // lblRejectedName
            //
            lblRejectedName.AutoSize = true;
            lblRejectedName.BackColor = Color.White;
            lblRejectedName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRejectedName.ForeColor = Color.FromArgb(31, 29, 59);
            lblRejectedName.Location = new Point(24, 144);
            lblRejectedName.Name = "lblRejectedName";
            lblRejectedName.Size = new Size(58, 19);
            lblRejectedName.TabIndex = 8;
            lblRejectedName.Text = "Rejected";
            //
            // lblRejectedCount
            //
            lblRejectedCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRejectedCount.BackColor = Color.White;
            lblRejectedCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRejectedCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblRejectedCount.Location = new Point(293, 144);
            lblRejectedCount.Name = "lblRejectedCount";
            lblRejectedCount.Size = new Size(40, 19);
            lblRejectedCount.TabIndex = 9;
            lblRejectedCount.Text = "2";
            lblRejectedCount.TextAlign = ContentAlignment.TopRight;
            //
            // progRejected
            //
            progRejected.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progRejected.BackColor = Color.Transparent;
            progRejected.BarColor = Color.FromArgb(220, 38, 38);
            progRejected.Location = new Point(24, 170);
            progRejected.Maximum = 10;
            progRejected.Name = "progRejected";
            progRejected.Size = new Size(309, 8);
            progRejected.TabIndex = 10;
            progRejected.TabStop = false;
            progRejected.Value = 2;
            //
            // tlpBottom
            //
            tlpBottom.ColumnCount = 2;
            tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpBottom.Controls.Add(cardChart, 0, 0);
            tlpBottom.Controls.Add(cardTotals, 1, 0);
            tlpBottom.Dock = DockStyle.Fill;
            tlpBottom.Location = new Point(0, 216);
            tlpBottom.Margin = new Padding(0, 8, 0, 0);
            tlpBottom.Name = "tlpBottom";
            tlpBottom.RowCount = 1;
            tlpBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottom.Size = new Size(676, 332);
            tlpBottom.TabIndex = 1;
            //
            // cardChart
            //
            cardChart.BackColor = Color.White;
            cardChart.BorderColor = Color.FromArgb(236, 236, 244);
            cardChart.Controls.Add(chartPerDay);
            cardChart.CornerRadius = 16;
            cardChart.Dock = DockStyle.Fill;
            cardChart.Location = new Point(0, 0);
            cardChart.Margin = new Padding(0, 0, 8, 0);
            cardChart.Name = "cardChart";
            cardChart.Padding = new Padding(24, 20, 24, 16);
            cardChart.Size = new Size(384, 332);
            cardChart.TabIndex = 0;
            //
            // chartPerDay
            //
            chartPerDay.BackColor = Color.Transparent;
            chartPerDay.Dock = DockStyle.Fill;
            chartPerDay.Location = new Point(24, 20);
            chartPerDay.Name = "chartPerDay";
            chartPerDay.SeriesAName = "This week";
            chartPerDay.SeriesBName = "Last week";
            chartPerDay.Size = new Size(336, 296);
            chartPerDay.TabIndex = 0;
            chartPerDay.TabStop = false;
            chartPerDay.Title = "Reservations per day";
            //
            // cardTotals
            //
            cardTotals.BackColor = Color.White;
            cardTotals.BorderColor = Color.FromArgb(236, 236, 244);
            cardTotals.Controls.Add(lblBrokenCount);
            cardTotals.Controls.Add(lblBrokenName);
            cardTotals.Controls.Add(dotBroken);
            cardTotals.Controls.Add(lblRepairCount);
            cardTotals.Controls.Add(lblRepairName);
            cardTotals.Controls.Add(dotRepair);
            cardTotals.Controls.Add(lblInUseCount);
            cardTotals.Controls.Add(lblInUseName);
            cardTotals.Controls.Add(dotInUse);
            cardTotals.Controls.Add(lblAvailableCount);
            cardTotals.Controls.Add(lblAvailableName);
            cardTotals.Controls.Add(dotAvailable);
            cardTotals.Controls.Add(lblTotalCap);
            cardTotals.Controls.Add(lblTotalNum);
            cardTotals.CornerRadius = 16;
            cardTotals.Dock = DockStyle.Fill;
            cardTotals.Location = new Point(392, 0);
            cardTotals.Margin = new Padding(8, 0, 0, 0);
            cardTotals.Name = "cardTotals";
            cardTotals.Size = new Size(276, 332);
            cardTotals.TabIndex = 1;
            //
            // lblTotalNum
            //
            lblTotalNum.AutoSize = true;
            lblTotalNum.BackColor = Color.White;
            lblTotalNum.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalNum.ForeColor = Color.FromArgb(31, 29, 59);
            lblTotalNum.Location = new Point(20, 16);
            lblTotalNum.Name = "lblTotalNum";
            lblTotalNum.Size = new Size(54, 51);
            lblTotalNum.TabIndex = 0;
            lblTotalNum.Text = "12";
            //
            // lblTotalCap
            //
            lblTotalCap.AutoSize = true;
            lblTotalCap.BackColor = Color.White;
            lblTotalCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCap.ForeColor = Color.FromArgb(107, 107, 138);
            lblTotalCap.Location = new Point(24, 66);
            lblTotalCap.Name = "lblTotalCap";
            lblTotalCap.Size = new Size(88, 17);
            lblTotalCap.TabIndex = 1;
            lblTotalCap.Text = "Total projectors";
            //
            // dotAvailable
            //
            dotAvailable.BackColor = Color.Transparent;
            dotAvailable.FillColor = Color.FromArgb(16, 185, 129);
            dotAvailable.Location = new Point(24, 116);
            dotAvailable.Name = "dotAvailable";
            dotAvailable.Size = new Size(10, 10);
            dotAvailable.TabIndex = 2;
            dotAvailable.TabStop = false;
            //
            // lblAvailableName
            //
            lblAvailableName.AutoSize = true;
            lblAvailableName.BackColor = Color.White;
            lblAvailableName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableName.ForeColor = Color.FromArgb(31, 29, 59);
            lblAvailableName.Location = new Point(44, 112);
            lblAvailableName.Name = "lblAvailableName";
            lblAvailableName.Size = new Size(58, 19);
            lblAvailableName.TabIndex = 3;
            lblAvailableName.Text = "Available";
            //
            // lblAvailableCount
            //
            lblAvailableCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableCount.BackColor = Color.White;
            lblAvailableCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblAvailableCount.Location = new Point(212, 112);
            lblAvailableCount.Name = "lblAvailableCount";
            lblAvailableCount.Size = new Size(40, 19);
            lblAvailableCount.TabIndex = 4;
            lblAvailableCount.Text = "8";
            lblAvailableCount.TextAlign = ContentAlignment.TopRight;
            //
            // dotInUse
            //
            dotInUse.BackColor = Color.Transparent;
            dotInUse.FillColor = Color.FromArgb(59, 130, 246);
            dotInUse.Location = new Point(24, 160);
            dotInUse.Name = "dotInUse";
            dotInUse.Size = new Size(10, 10);
            dotInUse.TabIndex = 5;
            dotInUse.TabStop = false;
            //
            // lblInUseName
            //
            lblInUseName.AutoSize = true;
            lblInUseName.BackColor = Color.White;
            lblInUseName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInUseName.ForeColor = Color.FromArgb(31, 29, 59);
            lblInUseName.Location = new Point(44, 156);
            lblInUseName.Name = "lblInUseName";
            lblInUseName.Size = new Size(45, 19);
            lblInUseName.TabIndex = 6;
            lblInUseName.Text = "In use";
            //
            // lblInUseCount
            //
            lblInUseCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInUseCount.BackColor = Color.White;
            lblInUseCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInUseCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblInUseCount.Location = new Point(212, 156);
            lblInUseCount.Name = "lblInUseCount";
            lblInUseCount.Size = new Size(40, 19);
            lblInUseCount.TabIndex = 7;
            lblInUseCount.Text = "3";
            lblInUseCount.TextAlign = ContentAlignment.TopRight;
            //
            // dotRepair
            //
            dotRepair.BackColor = Color.Transparent;
            dotRepair.FillColor = Color.FromArgb(249, 115, 22);
            dotRepair.Location = new Point(24, 204);
            dotRepair.Name = "dotRepair";
            dotRepair.Size = new Size(10, 10);
            dotRepair.TabIndex = 8;
            dotRepair.TabStop = false;
            //
            // lblRepairName
            //
            lblRepairName.AutoSize = true;
            lblRepairName.BackColor = Color.White;
            lblRepairName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepairName.ForeColor = Color.FromArgb(31, 29, 59);
            lblRepairName.Location = new Point(44, 200);
            lblRepairName.Name = "lblRepairName";
            lblRepairName.Size = new Size(80, 19);
            lblRepairName.TabIndex = 9;
            lblRepairName.Text = "Under repair";
            //
            // lblRepairCount
            //
            lblRepairCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRepairCount.BackColor = Color.White;
            lblRepairCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepairCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblRepairCount.Location = new Point(212, 200);
            lblRepairCount.Name = "lblRepairCount";
            lblRepairCount.Size = new Size(40, 19);
            lblRepairCount.TabIndex = 10;
            lblRepairCount.Text = "1";
            lblRepairCount.TextAlign = ContentAlignment.TopRight;
            //
            // dotBroken
            //
            dotBroken.BackColor = Color.Transparent;
            dotBroken.FillColor = Color.FromArgb(239, 68, 68);
            dotBroken.Location = new Point(24, 248);
            dotBroken.Name = "dotBroken";
            dotBroken.Size = new Size(10, 10);
            dotBroken.TabIndex = 11;
            dotBroken.TabStop = false;
            //
            // lblBrokenName
            //
            lblBrokenName.AutoSize = true;
            lblBrokenName.BackColor = Color.White;
            lblBrokenName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrokenName.ForeColor = Color.FromArgb(31, 29, 59);
            lblBrokenName.Location = new Point(44, 244);
            lblBrokenName.Name = "lblBrokenName";
            lblBrokenName.Size = new Size(48, 19);
            lblBrokenName.TabIndex = 12;
            lblBrokenName.Text = "Broken";
            //
            // lblBrokenCount
            //
            lblBrokenCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBrokenCount.BackColor = Color.White;
            lblBrokenCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrokenCount.ForeColor = Color.FromArgb(31, 29, 59);
            lblBrokenCount.Location = new Point(212, 244);
            lblBrokenCount.Name = "lblBrokenCount";
            lblBrokenCount.Size = new Size(40, 19);
            lblBrokenCount.TabIndex = 13;
            lblBrokenCount.Text = "0";
            lblBrokenCount.TextAlign = ContentAlignment.TopRight;
            //
            // DashBoardPage
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(246, 246, 252);
            Controls.Add(tlpMain);
            Name = "DashBoardPage";
            Size = new Size(676, 548);
            tlpMain.ResumeLayout(false);
            tlpTop.ResumeLayout(false);
            cardHero.ResumeLayout(false);
            cardHero.PerformLayout();
            cardRequests.ResumeLayout(false);
            cardRequests.PerformLayout();
            tlpBottom.ResumeLayout(false);
            cardChart.ResumeLayout(false);
            cardTotals.ResumeLayout(false);
            cardTotals.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpTop;
        private ProjectorReservationSystem.Controls.GradientPanel cardHero;
        private Label lblHeroTitle;
        private Label lblHeroValue;
        private Label lblHeroSub;
        private Label lblInUseCap;
        private Label lblInUseVal;
        private Label lblRepairCap;
        private Label lblRepairVal;
        private ProjectorReservationSystem.Controls.RoundedPanel cardRequests;
        private Label lblReqTitle;
        private Label lblReqWeek;
        private Label lblPendingName;
        private Label lblPendingCount;
        private ProjectorReservationSystem.Controls.RoundedProgress progPending;
        private Label lblApprovedName;
        private Label lblApprovedCount;
        private ProjectorReservationSystem.Controls.RoundedProgress progApproved;
        private Label lblRejectedName;
        private Label lblRejectedCount;
        private ProjectorReservationSystem.Controls.RoundedProgress progRejected;
        private TableLayoutPanel tlpBottom;
        private ProjectorReservationSystem.Controls.RoundedPanel cardChart;
        private ProjectorReservationSystem.Controls.BarChart chartPerDay;
        private ProjectorReservationSystem.Controls.RoundedPanel cardTotals;
        private Label lblTotalNum;
        private Label lblTotalCap;
        private ProjectorReservationSystem.Controls.CircleBadge dotAvailable;
        private Label lblAvailableName;
        private Label lblAvailableCount;
        private ProjectorReservationSystem.Controls.CircleBadge dotInUse;
        private Label lblInUseName;
        private Label lblInUseCount;
        private ProjectorReservationSystem.Controls.CircleBadge dotRepair;
        private Label lblRepairName;
        private Label lblRepairCount;
        private ProjectorReservationSystem.Controls.CircleBadge dotBroken;
        private Label lblBrokenName;
        private Label lblBrokenCount;
    }
}
