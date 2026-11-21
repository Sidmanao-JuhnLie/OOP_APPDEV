namespace ProjectorReservationSystem.Forms
{
    partial class LoginForm
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
            pnlTopBar = new Panel();
            flpWIndowBtns = new FlowLayoutPanel();
            btnMin = new Button();
            btnClose = new Button();
            tlpSplit = new TableLayoutPanel();
            pnlLeft = new Panel();
            pnlHero = new ProjectorReservationSystem.Controls.RoundedPanel();
            lblBrand = new Label();
            picIllustration = new ProjectorReservationSystem.Controls.ProjectorIllustration();
            pnlRight = new Panel();
            pnlCard = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            pnlEmailBox = new ProjectorReservationSystem.Controls.RoundedPanel();
            txtEmail = new TextBox();
            lblPassword = new Label();
            pnlPasswordBox = new ProjectorReservationSystem.Controls.RoundedPanel();
            txtPassword = new TextBox();
            btnSubmit = new ProjectorReservationSystem.Controls.RoundedButton();
            linkLabel1 = new LinkLabel();
            pnlTopBar.SuspendLayout();
            flpWIndowBtns.SuspendLayout();
            tlpSplit.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlHero.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlCard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlEmailBox.SuspendLayout();
            pnlPasswordBox.SuspendLayout();
            SuspendLayout();
            //
            // pnlTopBar
            //
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(flpWIndowBtns);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1024, 32);
            pnlTopBar.TabIndex = 3;
            //
            // flpWIndowBtns
            //
            flpWIndowBtns.Controls.Add(btnMin);
            flpWIndowBtns.Controls.Add(btnClose);
            flpWIndowBtns.Dock = DockStyle.Right;
            flpWIndowBtns.Location = new Point(926, 0);
            flpWIndowBtns.Name = "flpWIndowBtns";
            flpWIndowBtns.Size = new Size(98, 32);
            flpWIndowBtns.TabIndex = 2;
            flpWIndowBtns.WrapContents = false;
            //
            // btnMin
            //
            btnMin.BackColor = Color.White;
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 229, 238);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 236, 254);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe MDL2 Assets", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMin.ForeColor = Color.FromArgb(31, 29, 59);
            btnMin.Location = new Point(3, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 26);
            btnMin.TabIndex = 1;
            btnMin.TabStop = false;
            btnMin.Text = "— ";
            btnMin.UseVisualStyleBackColor = false;
            //
            // btnClose
            //
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 229, 238);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 236, 254);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe MDL2 Assets", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(31, 29, 59);
            btnClose.Location = new Point(49, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 26);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Text = "✕ ";
            btnClose.UseVisualStyleBackColor = false;
            //
            // tlpSplit
            //
            tlpSplit.ColumnCount = 2;
            tlpSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSplit.Controls.Add(pnlLeft, 0, 0);
            tlpSplit.Controls.Add(pnlRight, 1, 0);
            tlpSplit.Dock = DockStyle.Fill;
            tlpSplit.Location = new Point(0, 32);
            tlpSplit.Margin = new Padding(0);
            tlpSplit.Name = "tlpSplit";
            tlpSplit.RowCount = 1;
            tlpSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSplit.Size = new Size(1024, 544);
            tlpSplit.TabIndex = 0;
            //
            // pnlLeft
            //
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pnlHero);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(16, 8, 8, 16);
            pnlLeft.Size = new Size(512, 544);
            pnlLeft.TabIndex = 0;
            //
            // pnlHero
            //
            pnlHero.BackColor = Color.FromArgb(246, 246, 252);
            pnlHero.Controls.Add(lblBrand);
            pnlHero.Controls.Add(picIllustration);
            pnlHero.CornerRadius = 20;
            pnlHero.Dock = DockStyle.Fill;
            pnlHero.Location = new Point(16, 8);
            pnlHero.Name = "pnlHero";
            pnlHero.Size = new Size(488, 520);
            pnlHero.TabIndex = 0;
            //
            // lblBrand
            //
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.FromArgb(31, 29, 59);
            lblBrand.Location = new Point(94, 326);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(300, 32);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Projector Reservation";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            //
            // picIllustration
            //
            picIllustration.Anchor = AnchorStyles.None;
            picIllustration.BackColor = Color.Transparent;
            picIllustration.Location = new Point(149, 162);
            picIllustration.Name = "picIllustration";
            picIllustration.Size = new Size(190, 144);
            picIllustration.TabIndex = 0;
            picIllustration.TabStop = false;
            //
            // pnlRight
            //
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(pnlCard);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(512, 0);
            pnlRight.Margin = new Padding(0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(512, 544);
            pnlRight.TabIndex = 1;
            //
            // pnlCard
            //
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(tableLayoutPanel1);
            pnlCard.Location = new Point(86, 92);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(340, 360);
            pnlCard.TabIndex = 0;
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSubtitle, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(pnlEmailBox, 0, 4);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 5);
            tableLayoutPanel1.Controls.Add(pnlPasswordBox, 0, 6);
            tableLayoutPanel1.Controls.Add(btnSubmit, 0, 8);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.FromArgb(31, 29, 59);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(340, 360);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            //
            // lblTitle
            //
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblTitle.Location = new Point(0, 4);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome back";
            //
            // lblSubtitle
            //
            lblSubtitle.Anchor = AnchorStyles.Left;
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(107, 107, 138);
            lblSubtitle.Location = new Point(0, 5);
            lblSubtitle.Margin = new Padding(0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(184, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Log in to reserve a projector";
            lblSubtitle.Click += lblSubtitle_Click;
            //
            // lblEmail
            //
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(31, 29, 59);
            lblEmail.Location = new Point(0, 3);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            //
            // pnlEmailBox
            //
            pnlEmailBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlEmailBox.BackColor = Color.White;
            pnlEmailBox.BorderColor = Color.FromArgb(229, 229, 238);
            pnlEmailBox.Controls.Add(txtEmail);
            pnlEmailBox.CornerRadius = 12;
            pnlEmailBox.Location = new Point(0, 94);
            pnlEmailBox.Margin = new Padding(0, 0, 0, 8);
            pnlEmailBox.Name = "pnlEmailBox";
            pnlEmailBox.Size = new Size(340, 46);
            pnlEmailBox.TabIndex = 3;
            //
            // txtEmail
            //
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(31, 29, 59);
            txtEmail.Location = new Point(16, 13);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "you@school.edu";
            txtEmail.Size = new Size(308, 19);
            txtEmail.TabIndex = 0;
            //
            // lblPassword
            //
            lblPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(31, 29, 59);
            lblPassword.Location = new Point(0, 3);
            lblPassword.Margin = new Padding(0, 0, 0, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            //
            // pnlPasswordBox
            //
            pnlPasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPasswordBox.BackColor = Color.White;
            pnlPasswordBox.BorderColor = Color.FromArgb(229, 229, 238);
            pnlPasswordBox.Controls.Add(txtPassword);
            pnlPasswordBox.CornerRadius = 12;
            pnlPasswordBox.Location = new Point(0, 174);
            pnlPasswordBox.Margin = new Padding(0, 0, 0, 8);
            pnlPasswordBox.Name = "pnlPasswordBox";
            pnlPasswordBox.Size = new Size(340, 46);
            pnlPasswordBox.TabIndex = 6;
            //
            // txtPassword
            //
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(31, 29, 59);
            txtPassword.Location = new Point(16, 13);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(308, 19);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            //
            // btnSubmit
            //
            btnSubmit.BackColor = Color.FromArgb(91, 63, 245);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(0, 244);
            btnSubmit.Margin = new Padding(0);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(340, 48);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Log in";
            btnSubmit.UseVisualStyleBackColor = false;
            //
            // linkLabel1
            //
            linkLabel1.ActiveLinkColor = Color.FromArgb(74, 49, 214);
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(91, 63, 245);
            linkLabel1.LinkColor = Color.FromArgb(91, 63, 245);
            linkLabel1.Location = new Point(98, 310);
            linkLabel1.Margin = new Padding(0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(144, 19);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No account? Sign up";
            linkLabel1.VisitedLinkColor = Color.FromArgb(91, 63, 245);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            //
            // LoginForm
            //
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1024, 576);
            Controls.Add(tlpSplit);
            Controls.Add(pnlTopBar);
            ForeColor = Color.FromArgb(31, 29, 59);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projector Reservation System";
            Load += LoginForm_Load;
            pnlTopBar.ResumeLayout(false);
            flpWIndowBtns.ResumeLayout(false);
            tlpSplit.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlHero.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlEmailBox.ResumeLayout(false);
            pnlEmailBox.PerformLayout();
            pnlPasswordBox.ResumeLayout(false);
            pnlPasswordBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopBar;
        private FlowLayoutPanel flpWIndowBtns;
        private Button btnMin;
        private Button btnClose;
        private TableLayoutPanel tlpSplit;
        private Panel pnlLeft;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlHero;
        private Label lblBrand;
        private ProjectorReservationSystem.Controls.ProjectorIllustration picIllustration;
        private Panel pnlRight;
        private Panel pnlCard;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmail;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlEmailBox;
        private TextBox txtEmail;
        private Label lblPassword;
        private ProjectorReservationSystem.Controls.RoundedPanel pnlPasswordBox;
        private TextBox txtPassword;
        private ProjectorReservationSystem.Controls.RoundedButton btnSubmit;
        private LinkLabel linkLabel1;
    }
}
