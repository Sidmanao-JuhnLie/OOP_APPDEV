namespace ProjectorReservationSystem.Forms
{
    partial class NotificationPopup
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
            pnlCard = new ProjectorReservationSystem.Controls.RoundedPanel();
            flpItems = new FlowLayoutPanel();
            lblEmpty = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            flpItems.SuspendLayout();
            SuspendLayout();
            //
            // pnlCard
            //
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(flpItems);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.CornerRadius = 16;
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(16, 16);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(352, 228);
            pnlCard.TabIndex = 0;
            //
            // flpItems
            //
            flpItems.AutoScroll = true;
            flpItems.BackColor = Color.White;
            flpItems.Controls.Add(lblEmpty);
            flpItems.Dock = DockStyle.Fill;
            flpItems.FlowDirection = FlowDirection.TopDown;
            flpItems.Location = new Point(0, 52);
            flpItems.Name = "flpItems";
            flpItems.Padding = new Padding(8, 0, 8, 8);
            flpItems.Size = new Size(352, 176);
            flpItems.TabIndex = 1;
            flpItems.WrapContents = false;
            //
            // lblEmpty
            //
            lblEmpty.AutoSize = true;
            lblEmpty.BackColor = Color.White;
            lblEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpty.ForeColor = Color.FromArgb(107, 107, 138);
            lblEmpty.Location = new Point(20, 8);
            lblEmpty.Margin = new Padding(12, 8, 0, 8);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(130, 17);
            lblEmpty.TabIndex = 0;
            lblEmpty.Text = "You're all caught up.";
            lblEmpty.Visible = false;
            //
            // lblTitle
            //
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(20, 6, 0, 0);
            lblTitle.Size = new Size(352, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Notifications";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // NotificationPopup
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(225, 222, 250);
            ClientSize = new Size(384, 260);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationPopup";
            Padding = new Padding(16);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Notifications";
            pnlCard.ResumeLayout(false);
            flpItems.ResumeLayout(false);
            flpItems.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProjectorReservationSystem.Controls.RoundedPanel pnlCard;
        private FlowLayoutPanel flpItems;
        private Label lblEmpty;
        private Label lblTitle;
    }
}
