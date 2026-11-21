namespace ProjectorReservationSystem.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlLogo = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblLogo = new Label();
            lblBrandName = new Label();
            btnNavDashboard = new ProjectorReservationSystem.Controls.RoundedButton();
            btnNavReservations = new ProjectorReservationSystem.Controls.RoundedButton();
            btnNavEquipment = new ProjectorReservationSystem.Controls.RoundedButton();
            btnNavHistory = new ProjectorReservationSystem.Controls.RoundedButton();
            btnLogout = new ProjectorReservationSystem.Controls.RoundedButton();
            pnlIllustrationCard = new ProjectorReservationSystem.Controls.RoundedPanel();
            picSidebarIllustration = new ProjectorReservationSystem.Controls.ProjectorIllustration();
            btnNewReservation = new ProjectorReservationSystem.Controls.RoundedButton();
            pnlRight = new Panel();
            btnSettings = new ProjectorReservationSystem.Controls.RoundedButton();
            btnCloseApp = new ProjectorReservationSystem.Controls.RoundedButton();
            badgeAvatar = new ProjectorReservationSystem.Controls.CircleBadge();
            lblUserName = new Label();
            lblUserRole = new Label();
            lblMyRequests = new Label();
            lblMyPendingCap = new Label();
            lblMyPendingVal = new Label();
            lblMyApprovedCap = new Label();
            lblMyApprovedVal = new Label();
            lblRecentTitle = new Label();
            lblToday = new Label();
            rowApproved = new ProjectorReservationSystem.Controls.ActivityRow();
            rowRejected = new ProjectorReservationSystem.Controls.ActivityRow();
            pnlDivider = new Panel();
            lblYesterday = new Label();
            rowReturned = new ProjectorReservationSystem.Controls.ActivityRow();
            pnlCenterHost = new Panel();
            pnlCanvas = new ProjectorReservationSystem.Controls.RoundedPanel();
            pnlPageHost = new Panel();
            lblPageTitle = new Label();
            pnlTopBar = new Panel();
            badgeNotif = new ProjectorReservationSystem.Controls.CircleBadge();
            btnNotifications = new ProjectorReservationSystem.Controls.RoundedButton();
            btnMore = new ProjectorReservationSystem.Controls.RoundedButton();
            pnlSearch = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlIllustrationCard.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlCenterHost.SuspendLayout();
            pnlCanvas.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnNewReservation);
            pnlSidebar.Controls.Add(pnlIllustrationCard);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnNavHistory);
            pnlSidebar.Controls.Add(btnNavEquipment);
            pnlSidebar.Controls.Add(btnNavReservations);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblBrandName);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 720);
            pnlSidebar.TabIndex = 2;
            //
            // pnlLogo
            //
            pnlLogo.BackColor = Color.FromArgb(91, 63, 245);
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.CornerRadius = 12;
            pnlLogo.Location = new Point(24, 24);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(40, 40);
            pnlLogo.TabIndex = 0;
            //
            // lblLogo
            //
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(40, 40);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "P";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblBrandName
            //
            lblBrandName.BackColor = Color.White;
            lblBrandName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.ForeColor = Color.FromArgb(31, 29, 59);
            lblBrandName.Location = new Point(72, 24);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(150, 40);
            lblBrandName.TabIndex = 1;
            lblBrandName.Text = "Projector\r\nReservation";
            lblBrandName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnNavDashboard
            //
            btnNavDashboard.BackColor = Color.White;
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavDashboard.ForeColor = Color.FromArgb(107, 107, 138);
            btnNavDashboard.HoverColor = Color.FromArgb(246, 246, 252);
            btnNavDashboard.IconGlyph = "";
            btnNavDashboard.Location = new Point(24, 96);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(16, 0, 8, 0);
            btnNavDashboard.Size = new Size(192, 48);
            btnNavDashboard.TabIndex = 2;
            btnNavDashboard.Text = "Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += btnNavDashboard_Click;
            //
            // btnNavReservations
            //
            btnNavReservations.BackColor = Color.White;
            btnNavReservations.Cursor = Cursors.Hand;
            btnNavReservations.FlatAppearance.BorderSize = 0;
            btnNavReservations.FlatStyle = FlatStyle.Flat;
            btnNavReservations.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavReservations.ForeColor = Color.FromArgb(107, 107, 138);
            btnNavReservations.HoverColor = Color.FromArgb(246, 246, 252);
            btnNavReservations.IconGlyph = "";
            btnNavReservations.Location = new Point(24, 152);
            btnNavReservations.Name = "btnNavReservations";
            btnNavReservations.Padding = new Padding(16, 0, 8, 0);
            btnNavReservations.Size = new Size(192, 48);
            btnNavReservations.TabIndex = 3;
            btnNavReservations.Text = "Reservations";
            btnNavReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReservations.UseVisualStyleBackColor = false;
            btnNavReservations.Click += btnNavReservations_Click;
            //
            // btnNavEquipment
            //
            btnNavEquipment.BackColor = Color.White;
            btnNavEquipment.Cursor = Cursors.Hand;
            btnNavEquipment.FlatAppearance.BorderSize = 0;
            btnNavEquipment.FlatStyle = FlatStyle.Flat;
            btnNavEquipment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavEquipment.ForeColor = Color.FromArgb(107, 107, 138);
            btnNavEquipment.HoverColor = Color.FromArgb(246, 246, 252);
            btnNavEquipment.IconGlyph = "";
            btnNavEquipment.Location = new Point(24, 208);
            btnNavEquipment.Name = "btnNavEquipment";
            btnNavEquipment.Padding = new Padding(16, 0, 8, 0);
            btnNavEquipment.Size = new Size(192, 48);
            btnNavEquipment.TabIndex = 4;
            btnNavEquipment.Text = "Equipment";
            btnNavEquipment.TextAlign = ContentAlignment.MiddleLeft;
            btnNavEquipment.UseVisualStyleBackColor = false;
            btnNavEquipment.Click += btnNavEquipment_Click;
            //
            // btnNavHistory
            //
            btnNavHistory.BackColor = Color.White;
            btnNavHistory.Cursor = Cursors.Hand;
            btnNavHistory.FlatAppearance.BorderSize = 0;
            btnNavHistory.FlatStyle = FlatStyle.Flat;
            btnNavHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavHistory.ForeColor = Color.FromArgb(107, 107, 138);
            btnNavHistory.HoverColor = Color.FromArgb(246, 246, 252);
            btnNavHistory.IconGlyph = "";
            btnNavHistory.Location = new Point(24, 264);
            btnNavHistory.Name = "btnNavHistory";
            btnNavHistory.Padding = new Padding(16, 0, 8, 0);
            btnNavHistory.Size = new Size(192, 48);
            btnNavHistory.TabIndex = 5;
            btnNavHistory.Text = "History";
            btnNavHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHistory.UseVisualStyleBackColor = false;
            btnNavHistory.Click += btnNavHistory_Click;
            //
            // btnLogout
            //
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(107, 107, 138);
            btnLogout.HoverColor = Color.FromArgb(246, 246, 252);
            btnLogout.IconGlyph = "";
            btnLogout.Location = new Point(24, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(16, 0, 8, 0);
            btnLogout.Size = new Size(192, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            //
            // pnlIllustrationCard
            //
            pnlIllustrationCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlIllustrationCard.BackColor = Color.FromArgb(246, 246, 252);
            pnlIllustrationCard.Controls.Add(picSidebarIllustration);
            pnlIllustrationCard.CornerRadius = 16;
            pnlIllustrationCard.Location = new Point(24, 492);
            pnlIllustrationCard.Name = "pnlIllustrationCard";
            pnlIllustrationCard.Size = new Size(192, 136);
            pnlIllustrationCard.TabIndex = 7;
            //
            // picSidebarIllustration
            //
            picSidebarIllustration.BackColor = Color.Transparent;
            picSidebarIllustration.Location = new Point(41, 26);
            picSidebarIllustration.Name = "picSidebarIllustration";
            picSidebarIllustration.Size = new Size(110, 83);
            picSidebarIllustration.TabIndex = 0;
            picSidebarIllustration.TabStop = false;
            //
            // btnNewReservation
            //
            btnNewReservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewReservation.BackColor = Color.FromArgb(91, 63, 245);
            btnNewReservation.Cursor = Cursors.Hand;
            btnNewReservation.FlatAppearance.BorderSize = 0;
            btnNewReservation.FlatStyle = FlatStyle.Flat;
            btnNewReservation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Location = new Point(24, 644);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(192, 52);
            btnNewReservation.TabIndex = 8;
            btnNewReservation.Text = "New reservation";
            btnNewReservation.UseVisualStyleBackColor = false;
            //
            // pnlRight
            //
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(rowReturned);
            pnlRight.Controls.Add(lblYesterday);
            pnlRight.Controls.Add(pnlDivider);
            pnlRight.Controls.Add(rowRejected);
            pnlRight.Controls.Add(rowApproved);
            pnlRight.Controls.Add(lblToday);
            pnlRight.Controls.Add(lblRecentTitle);
            pnlRight.Controls.Add(lblMyApprovedVal);
            pnlRight.Controls.Add(lblMyApprovedCap);
            pnlRight.Controls.Add(lblMyPendingVal);
            pnlRight.Controls.Add(lblMyPendingCap);
            pnlRight.Controls.Add(lblMyRequests);
            pnlRight.Controls.Add(lblUserRole);
            pnlRight.Controls.Add(lblUserName);
            pnlRight.Controls.Add(badgeAvatar);
            pnlRight.Controls.Add(btnCloseApp);
            pnlRight.Controls.Add(btnSettings);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(980, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(300, 720);
            pnlRight.TabIndex = 1;
            //
            // btnSettings
            //
            btnSettings.BackColor = Color.White;
            btnSettings.CornerRadius = 16;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.FromArgb(107, 107, 138);
            btnSettings.HoverColor = Color.FromArgb(246, 246, 252);
            btnSettings.IconGlyph = "";
            btnSettings.IconSize = 11F;
            btnSettings.Location = new Point(204, 24);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(32, 32);
            btnSettings.TabIndex = 0;
            btnSettings.UseVisualStyleBackColor = false;
            //
            // btnCloseApp
            //
            btnCloseApp.BackColor = Color.White;
            btnCloseApp.CornerRadius = 16;
            btnCloseApp.Cursor = Cursors.Hand;
            btnCloseApp.FlatAppearance.BorderSize = 0;
            btnCloseApp.FlatStyle = FlatStyle.Flat;
            btnCloseApp.ForeColor = Color.FromArgb(107, 107, 138);
            btnCloseApp.HoverColor = Color.FromArgb(246, 246, 252);
            btnCloseApp.IconGlyph = "";
            btnCloseApp.IconSize = 11F;
            btnCloseApp.Location = new Point(244, 24);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(32, 32);
            btnCloseApp.TabIndex = 1;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += btnCloseApp_Click;
            //
            // badgeAvatar
            //
            badgeAvatar.BackColor = Color.Transparent;
            badgeAvatar.FillColor = Color.FromArgb(239, 236, 254);
            badgeAvatar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            badgeAvatar.ForeColor = Color.FromArgb(91, 63, 245);
            badgeAvatar.Location = new Point(24, 24);
            badgeAvatar.Name = "badgeAvatar";
            badgeAvatar.Size = new Size(76, 76);
            badgeAvatar.TabIndex = 2;
            badgeAvatar.TabStop = false;
            badgeAvatar.Text = "AR";
            //
            // lblUserName
            //
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.White;
            lblUserName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(31, 29, 59);
            lblUserName.Location = new Point(24, 112);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 20);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Alex Rivera";
            //
            // lblUserRole
            //
            lblUserRole.AutoSize = true;
            lblUserRole.BackColor = Color.White;
            lblUserRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserRole.ForeColor = Color.FromArgb(107, 107, 138);
            lblUserRole.Location = new Point(24, 134);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(88, 17);
            lblUserRole.TabIndex = 4;
            lblUserRole.Text = "Faculty member";
            //
            // lblMyRequests
            //
            lblMyRequests.AutoSize = true;
            lblMyRequests.BackColor = Color.White;
            lblMyRequests.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyRequests.ForeColor = Color.FromArgb(31, 29, 59);
            lblMyRequests.Location = new Point(24, 168);
            lblMyRequests.Name = "lblMyRequests";
            lblMyRequests.Size = new Size(88, 20);
            lblMyRequests.TabIndex = 5;
            lblMyRequests.Text = "My requests";
            //
            // lblMyPendingCap
            //
            lblMyPendingCap.AutoSize = true;
            lblMyPendingCap.BackColor = Color.White;
            lblMyPendingCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyPendingCap.ForeColor = Color.FromArgb(107, 107, 138);
            lblMyPendingCap.Location = new Point(24, 208);
            lblMyPendingCap.Name = "lblMyPendingCap";
            lblMyPendingCap.Size = new Size(49, 17);
            lblMyPendingCap.TabIndex = 6;
            lblMyPendingCap.Text = "Pending";
            //
            // lblMyPendingVal
            //
            lblMyPendingVal.AutoSize = true;
            lblMyPendingVal.BackColor = Color.White;
            lblMyPendingVal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyPendingVal.ForeColor = Color.FromArgb(31, 29, 59);
            lblMyPendingVal.Location = new Point(110, 203);
            lblMyPendingVal.Name = "lblMyPendingVal";
            lblMyPendingVal.Size = new Size(15, 21);
            lblMyPendingVal.TabIndex = 7;
            lblMyPendingVal.Text = "2";
            //
            // lblMyApprovedCap
            //
            lblMyApprovedCap.AutoSize = true;
            lblMyApprovedCap.BackColor = Color.White;
            lblMyApprovedCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyApprovedCap.ForeColor = Color.FromArgb(107, 107, 138);
            lblMyApprovedCap.Location = new Point(24, 240);
            lblMyApprovedCap.Name = "lblMyApprovedCap";
            lblMyApprovedCap.Size = new Size(55, 17);
            lblMyApprovedCap.TabIndex = 8;
            lblMyApprovedCap.Text = "Approved";
            //
            // lblMyApprovedVal
            //
            lblMyApprovedVal.AutoSize = true;
            lblMyApprovedVal.BackColor = Color.White;
            lblMyApprovedVal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyApprovedVal.ForeColor = Color.FromArgb(31, 29, 59);
            lblMyApprovedVal.Location = new Point(110, 235);
            lblMyApprovedVal.Name = "lblMyApprovedVal";
            lblMyApprovedVal.Size = new Size(15, 21);
            lblMyApprovedVal.TabIndex = 9;
            lblMyApprovedVal.Text = "5";
            //
            // lblRecentTitle
            //
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.BackColor = Color.White;
            lblRecentTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblRecentTitle.Location = new Point(24, 284);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(116, 20);
            lblRecentTitle.TabIndex = 10;
            lblRecentTitle.Text = "Recent decisions";
            //
            // lblToday
            //
            lblToday.AutoSize = true;
            lblToday.BackColor = Color.White;
            lblToday.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToday.ForeColor = Color.FromArgb(107, 107, 138);
            lblToday.Location = new Point(24, 316);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(40, 17);
            lblToday.TabIndex = 11;
            lblToday.Text = "Today";
            //
            // rowApproved
            //
            rowApproved.BackColor = Color.Transparent;
            rowApproved.Kind = ProjectorReservationSystem.Controls.ActivityKind.Approved;
            rowApproved.Location = new Point(24, 340);
            rowApproved.Name = "rowApproved";
            rowApproved.Size = new Size(252, 56);
            rowApproved.Subtitle = "Approved";
            rowApproved.TabIndex = 12;
            rowApproved.TabStop = false;
            rowApproved.TimeText = "2 min ago";
            rowApproved.Title = "PJ-03 request";
            //
            // rowRejected
            //
            rowRejected.BackColor = Color.Transparent;
            rowRejected.Kind = ProjectorReservationSystem.Controls.ActivityKind.Rejected;
            rowRejected.Location = new Point(24, 404);
            rowRejected.Name = "rowRejected";
            rowRejected.Size = new Size(252, 56);
            rowRejected.Subtitle = "Rejected";
            rowRejected.TabIndex = 13;
            rowRejected.TabStop = false;
            rowRejected.TimeText = "1 hour ago";
            rowRejected.Title = "PJ-07 request";
            //
            // pnlDivider
            //
            pnlDivider.BackColor = Color.FromArgb(236, 236, 244);
            pnlDivider.Location = new Point(24, 472);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(252, 1);
            pnlDivider.TabIndex = 14;
            //
            // lblYesterday
            //
            lblYesterday.AutoSize = true;
            lblYesterday.BackColor = Color.White;
            lblYesterday.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesterday.ForeColor = Color.FromArgb(107, 107, 138);
            lblYesterday.Location = new Point(24, 484);
            lblYesterday.Name = "lblYesterday";
            lblYesterday.Size = new Size(60, 17);
            lblYesterday.TabIndex = 15;
            lblYesterday.Text = "Yesterday";
            //
            // rowReturned
            //
            rowReturned.BackColor = Color.Transparent;
            rowReturned.Kind = ProjectorReservationSystem.Controls.ActivityKind.Returned;
            rowReturned.Location = new Point(24, 508);
            rowReturned.Name = "rowReturned";
            rowReturned.Size = new Size(252, 56);
            rowReturned.Subtitle = "Returned";
            rowReturned.TabIndex = 16;
            rowReturned.TabStop = false;
            rowReturned.TimeText = "Yesterday";
            rowReturned.Title = "PJ-05 request";
            //
            // pnlCenterHost
            //
            pnlCenterHost.BackColor = Color.White;
            pnlCenterHost.Controls.Add(pnlCanvas);
            pnlCenterHost.Dock = DockStyle.Fill;
            pnlCenterHost.Location = new Point(240, 0);
            pnlCenterHost.Name = "pnlCenterHost";
            pnlCenterHost.Padding = new Padding(8, 16, 8, 16);
            pnlCenterHost.Size = new Size(740, 720);
            pnlCenterHost.TabIndex = 0;
            //
            // pnlCanvas
            //
            pnlCanvas.BackColor = Color.FromArgb(246, 246, 252);
            pnlCanvas.Controls.Add(pnlPageHost);
            pnlCanvas.Controls.Add(lblPageTitle);
            pnlCanvas.Controls.Add(pnlTopBar);
            pnlCanvas.CornerRadius = 20;
            pnlCanvas.Dock = DockStyle.Fill;
            pnlCanvas.Location = new Point(8, 16);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Padding = new Padding(24, 24, 24, 16);
            pnlCanvas.Size = new Size(724, 688);
            pnlCanvas.TabIndex = 0;
            //
            // pnlPageHost
            //
            pnlPageHost.BackColor = Color.FromArgb(246, 246, 252);
            pnlPageHost.Dock = DockStyle.Fill;
            pnlPageHost.Location = new Point(24, 124);
            pnlPageHost.Name = "pnlPageHost";
            pnlPageHost.Size = new Size(676, 548);
            pnlPageHost.TabIndex = 2;
            //
            // lblPageTitle
            //
            lblPageTitle.BackColor = Color.FromArgb(246, 246, 252);
            lblPageTitle.Dock = DockStyle.Top;
            lblPageTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblPageTitle.Location = new Point(24, 80);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(676, 44);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Overview";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlTopBar
            //
            pnlTopBar.BackColor = Color.FromArgb(246, 246, 252);
            pnlTopBar.Controls.Add(badgeNotif);
            pnlTopBar.Controls.Add(btnMore);
            pnlTopBar.Controls.Add(btnNotifications);
            pnlTopBar.Controls.Add(pnlSearch);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(24, 24);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(676, 56);
            pnlTopBar.TabIndex = 0;
            //
            // badgeNotif
            //
            badgeNotif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            badgeNotif.BackColor = Color.Transparent;
            badgeNotif.FillColor = Color.FromArgb(220, 38, 38);
            badgeNotif.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            badgeNotif.ForeColor = Color.White;
            badgeNotif.Location = new Point(600, 0);
            badgeNotif.Name = "badgeNotif";
            badgeNotif.Size = new Size(18, 18);
            badgeNotif.TabIndex = 3;
            badgeNotif.TabStop = false;
            badgeNotif.Text = "2";
            //
            // btnMore
            //
            btnMore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMore.BackColor = Color.White;
            btnMore.BorderColor = Color.FromArgb(236, 236, 244);
            btnMore.CornerRadius = 14;
            btnMore.Cursor = Cursors.Hand;
            btnMore.FlatAppearance.BorderSize = 0;
            btnMore.FlatStyle = FlatStyle.Flat;
            btnMore.ForeColor = Color.FromArgb(31, 29, 59);
            btnMore.HoverColor = Color.FromArgb(239, 236, 254);
            btnMore.IconGlyph = "";
            btnMore.Location = new Point(628, 4);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(48, 48);
            btnMore.TabIndex = 2;
            btnMore.UseVisualStyleBackColor = false;
            //
            // btnNotifications
            //
            btnNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNotifications.BackColor = Color.White;
            btnNotifications.BorderColor = Color.FromArgb(236, 236, 244);
            btnNotifications.CornerRadius = 14;
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = Color.FromArgb(31, 29, 59);
            btnNotifications.HoverColor = Color.FromArgb(239, 236, 254);
            btnNotifications.IconGlyph = "";
            btnNotifications.Location = new Point(572, 4);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(48, 48);
            btnNotifications.TabIndex = 1;
            btnNotifications.UseVisualStyleBackColor = false;
            btnNotifications.Click += btnNotifications_Click;
            //
            // pnlSearch
            //
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderColor = Color.FromArgb(236, 236, 244);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearchIcon);
            pnlSearch.CornerRadius = 14;
            pnlSearch.Location = new Point(0, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(386, 48);
            pnlSearch.TabIndex = 0;
            //
            // lblSearchIcon
            //
            lblSearchIcon.BackColor = Color.White;
            lblSearchIcon.Font = new Font("Segoe MDL2 Assets", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchIcon.ForeColor = Color.FromArgb(107, 107, 138);
            lblSearchIcon.Location = new Point(14, 12);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(24, 24);
            lblSearchIcon.TabIndex = 1;
            lblSearchIcon.Text = "";
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(31, 29, 59);
            txtSearch.Location = new Point(46, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search reservations or projectors";
            txtSearch.Size = new Size(326, 19);
            txtSearch.TabIndex = 0;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlCenterHost);
            Controls.Add(pnlRight);
            Controls.Add(pnlSidebar);
            ForeColor = Color.FromArgb(31, 29, 59);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projector Reservation System";
            Load += MainForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlIllustrationCard.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlCenterHost.ResumeLayout(false);
            pnlCanvas.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlLogo;
        private Label lblLogo;
        private Label lblBrandName;
        private ProjectorReservationSystem.Controls.RoundedButton btnNavDashboard;
        private ProjectorReservationSystem.Controls.RoundedButton btnNavReservations;
        private ProjectorReservationSystem.Controls.RoundedButton btnNavEquipment;
        private ProjectorReservationSystem.Controls.RoundedButton btnNavHistory;
        private ProjectorReservationSystem.Controls.RoundedButton btnLogout;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlIllustrationCard;
        private ProjectorReservationSystem.Controls.ProjectorIllustration picSidebarIllustration;
        private ProjectorReservationSystem.Controls.RoundedButton btnNewReservation;
        private Panel pnlRight;
        private ProjectorReservationSystem.Controls.RoundedButton btnSettings;
        private ProjectorReservationSystem.Controls.RoundedButton btnCloseApp;
        private ProjectorReservationSystem.Controls.CircleBadge badgeAvatar;
        private Label lblUserName;
        private Label lblUserRole;
        private Label lblMyRequests;
        private Label lblMyPendingCap;
        private Label lblMyPendingVal;
        private Label lblMyApprovedCap;
        private Label lblMyApprovedVal;
        private Label lblRecentTitle;
        private Label lblToday;
        private ProjectorReservationSystem.Controls.ActivityRow rowApproved;
        private ProjectorReservationSystem.Controls.ActivityRow rowRejected;
        private Panel pnlDivider;
        private Label lblYesterday;
        private ProjectorReservationSystem.Controls.ActivityRow rowReturned;
        private Panel pnlCenterHost;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlCanvas;
        private Panel pnlPageHost;
        private Label lblPageTitle;
        private Panel pnlTopBar;
        private ProjectorReservationSystem.Controls.CircleBadge badgeNotif;
        private ProjectorReservationSystem.Controls.RoundedButton btnNotifications;
        private ProjectorReservationSystem.Controls.RoundedButton btnMore;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlSearch;
        private Label lblSearchIcon;
        private TextBox txtSearch;
    }
}
