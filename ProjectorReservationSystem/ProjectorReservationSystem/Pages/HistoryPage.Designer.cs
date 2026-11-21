namespace ProjectorReservationSystem.Pages
{
    partial class HistoryPage
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
            pnlCards = new Panel();
            cardTimeline = new ProjectorReservationSystem.Controls.RoundedPanel();
            timelineHistory = new ProjectorReservationSystem.Controls.TimelineControl();
            pnlTimelineHeader = new Panel();
            lblHistoryTitle = new Label();
            pnlGap = new Panel();
            cardList = new ProjectorReservationSystem.Controls.RoundedPanel();
            lstProjectors = new ListBox();
            pnlListHeader = new Panel();
            lblListTitle = new Label();
            pnlCards.SuspendLayout();
            cardTimeline.SuspendLayout();
            pnlTimelineHeader.SuspendLayout();
            cardList.SuspendLayout();
            pnlListHeader.SuspendLayout();
            SuspendLayout();
            //
            // pnlCards
            //
            pnlCards.BackColor = Color.FromArgb(246, 246, 252);
            pnlCards.Controls.Add(cardTimeline);
            pnlCards.Controls.Add(pnlGap);
            pnlCards.Controls.Add(cardList);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 0);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(676, 436);
            pnlCards.TabIndex = 0;
            //
            // cardTimeline
            //
            cardTimeline.BackColor = Color.White;
            cardTimeline.BorderColor = Color.FromArgb(236, 236, 244);
            cardTimeline.Controls.Add(timelineHistory);
            cardTimeline.Controls.Add(pnlTimelineHeader);
            cardTimeline.CornerRadius = 16;
            cardTimeline.Dock = DockStyle.Fill;
            cardTimeline.Location = new Point(220, 0);
            cardTimeline.Name = "cardTimeline";
            cardTimeline.Padding = new Padding(1, 1, 1, 12);
            cardTimeline.Size = new Size(456, 436);
            cardTimeline.TabIndex = 0;
            //
            // timelineHistory
            //
            timelineHistory.AutoScroll = true;
            timelineHistory.BackColor = Color.White;
            timelineHistory.Dock = DockStyle.Fill;
            timelineHistory.Location = new Point(1, 57);
            timelineHistory.Name = "timelineHistory";
            timelineHistory.Size = new Size(454, 367);
            timelineHistory.TabIndex = 1;
            //
            // pnlTimelineHeader
            //
            pnlTimelineHeader.BackColor = Color.White;
            pnlTimelineHeader.Controls.Add(lblHistoryTitle);
            pnlTimelineHeader.Dock = DockStyle.Top;
            pnlTimelineHeader.Location = new Point(1, 1);
            pnlTimelineHeader.Name = "pnlTimelineHeader";
            pnlTimelineHeader.Size = new Size(454, 56);
            pnlTimelineHeader.TabIndex = 0;
            //
            // lblHistoryTitle
            //
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.BackColor = Color.White;
            lblHistoryTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoryTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblHistoryTitle.Location = new Point(21, 20);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(159, 19);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "PJ-03 · Borrower history";
            //
            // pnlGap
            //
            pnlGap.BackColor = Color.FromArgb(246, 246, 252);
            pnlGap.Dock = DockStyle.Left;
            pnlGap.Location = new Point(204, 0);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(16, 436);
            pnlGap.TabIndex = 1;
            //
            // cardList
            //
            cardList.BackColor = Color.White;
            cardList.BorderColor = Color.FromArgb(236, 236, 244);
            cardList.Controls.Add(lstProjectors);
            cardList.Controls.Add(pnlListHeader);
            cardList.CornerRadius = 16;
            cardList.Dock = DockStyle.Left;
            cardList.Location = new Point(0, 0);
            cardList.Name = "cardList";
            cardList.Padding = new Padding(20, 1, 20, 16);
            cardList.Size = new Size(204, 436);
            cardList.TabIndex = 2;
            //
            // lstProjectors
            //
            lstProjectors.BackColor = Color.White;
            lstProjectors.BorderStyle = BorderStyle.None;
            lstProjectors.Dock = DockStyle.Fill;
            lstProjectors.DrawMode = DrawMode.OwnerDrawFixed;
            lstProjectors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProjectors.ForeColor = Color.FromArgb(31, 29, 59);
            lstProjectors.FormattingEnabled = true;
            lstProjectors.IntegralHeight = false;
            lstProjectors.ItemHeight = 46;
            lstProjectors.Location = new Point(20, 57);
            lstProjectors.Name = "lstProjectors";
            lstProjectors.Size = new Size(164, 363);
            lstProjectors.TabIndex = 1;
            lstProjectors.DrawItem += lstProjectors_DrawItem;
            lstProjectors.SelectedIndexChanged += lstProjectors_SelectedIndexChanged;
            //
            // pnlListHeader
            //
            pnlListHeader.BackColor = Color.White;
            pnlListHeader.Controls.Add(lblListTitle);
            pnlListHeader.Dock = DockStyle.Top;
            pnlListHeader.Location = new Point(20, 1);
            pnlListHeader.Name = "pnlListHeader";
            pnlListHeader.Size = new Size(164, 56);
            pnlListHeader.TabIndex = 0;
            //
            // lblListTitle
            //
            lblListTitle.AutoSize = true;
            lblListTitle.BackColor = Color.White;
            lblListTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListTitle.ForeColor = Color.FromArgb(31, 29, 59);
            lblListTitle.Location = new Point(1, 20);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(68, 19);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Projectors";
            //
            // HistoryPage
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(246, 246, 252);
            Controls.Add(pnlCards);
            Name = "HistoryPage";
            Size = new Size(676, 548);
            pnlCards.ResumeLayout(false);
            cardTimeline.ResumeLayout(false);
            pnlTimelineHeader.ResumeLayout(false);
            pnlTimelineHeader.PerformLayout();
            cardList.ResumeLayout(false);
            pnlListHeader.ResumeLayout(false);
            pnlListHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCards;
        private ProjectorReservationSystem.Controls.RoundedPanel cardTimeline;
        private ProjectorReservationSystem.Controls.TimelineControl timelineHistory;
        private Panel pnlTimelineHeader;
        private Label lblHistoryTitle;
        private Panel pnlGap;
        private ProjectorReservationSystem.Controls.RoundedPanel cardList;
        private ListBox lstProjectors;
        private Panel pnlListHeader;
        private Label lblListTitle;
    }
}
