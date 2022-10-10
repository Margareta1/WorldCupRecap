namespace WF
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
            this.pageRankings = new System.Windows.Forms.TabControl();
            this.pagePlayers = new System.Windows.Forms.TabPage();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblFavorites = new System.Windows.Forms.Label();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpPlayersByYC = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayersByYellowCards = new System.Windows.Forms.Label();
            this.flpMatchesByAttendance = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMatchesByAttendance = new System.Windows.Forms.Label();
            this.flpPlayersByScores = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayersByScoreNumber = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.pageRankings.SuspendLayout();
            this.pagePlayers.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flpPlayersByYC.SuspendLayout();
            this.flpMatchesByAttendance.SuspendLayout();
            this.flpPlayersByScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageRankings
            // 
            this.pageRankings.Controls.Add(this.pagePlayers);
            this.pageRankings.Controls.Add(this.tabPage2);
            this.pageRankings.Controls.Add(this.Settings);
            this.pageRankings.Location = new System.Drawing.Point(0, -1);
            this.pageRankings.Name = "pageRankings";
            this.pageRankings.SelectedIndex = 0;
            this.pageRankings.Size = new System.Drawing.Size(1182, 755);
            this.pageRankings.TabIndex = 0;
            // 
            // pagePlayers
            // 
            this.pagePlayers.Controls.Add(this.lblPlayers);
            this.pagePlayers.Controls.Add(this.lblFavorites);
            this.pagePlayers.Controls.Add(this.flpPlayers);
            this.pagePlayers.Controls.Add(this.flpFavorites);
            this.pagePlayers.Location = new System.Drawing.Point(4, 37);
            this.pagePlayers.Name = "pagePlayers";
            this.pagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.pagePlayers.Size = new System.Drawing.Size(1174, 714);
            this.pagePlayers.TabIndex = 0;
            this.pagePlayers.Text = "Players";
            this.pagePlayers.UseVisualStyleBackColor = true;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayers.Location = new System.Drawing.Point(511, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(76, 28);
            this.lblPlayers.TabIndex = 3;
            this.lblPlayers.Text = "Players";
            // 
            // lblFavorites
            // 
            this.lblFavorites.AutoSize = true;
            this.lblFavorites.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFavorites.Location = new System.Drawing.Point(26, 0);
            this.lblFavorites.Name = "lblFavorites";
            this.lblFavorites.Size = new System.Drawing.Size(92, 28);
            this.lblFavorites.TabIndex = 2;
            this.lblFavorites.Text = "Favorites";
            // 
            // flpPlayers
            // 
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.Location = new System.Drawing.Point(511, 26);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(625, 672);
            this.flpPlayers.TabIndex = 1;
            // 
            // flpFavorites
            // 
            this.flpFavorites.AutoScroll = true;
            this.flpFavorites.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpFavorites.Location = new System.Drawing.Point(26, 26);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(459, 672);
            this.flpFavorites.TabIndex = 0;
            this.flpFavorites.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpPlayersByYC);
            this.tabPage2.Controls.Add(this.flpMatchesByAttendance);
            this.tabPage2.Controls.Add(this.flpPlayersByScores);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rankings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flpPlayersByYC
            // 
            this.flpPlayersByYC.AutoScroll = true;
            this.flpPlayersByYC.Controls.Add(this.lblPlayersByYellowCards);
            this.flpPlayersByYC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPlayersByYC.Location = new System.Drawing.Point(412, 7);
            this.flpPlayersByYC.Name = "flpPlayersByYC";
            this.flpPlayersByYC.Size = new System.Drawing.Size(350, 700);
            this.flpPlayersByYC.TabIndex = 1;
            // 
            // lblPlayersByYellowCards
            // 
            this.lblPlayersByYellowCards.AutoSize = true;
            this.lblPlayersByYellowCards.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayersByYellowCards.Location = new System.Drawing.Point(3, 0);
            this.lblPlayersByYellowCards.Name = "lblPlayersByYellowCards";
            this.lblPlayersByYellowCards.Size = new System.Drawing.Size(221, 28);
            this.lblPlayersByYellowCards.TabIndex = 5;
            this.lblPlayersByYellowCards.Text = "Players by yellow cards";
            // 
            // flpMatchesByAttendance
            // 
            this.flpMatchesByAttendance.AutoScroll = true;
            this.flpMatchesByAttendance.Controls.Add(this.lblMatchesByAttendance);
            this.flpMatchesByAttendance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpMatchesByAttendance.Location = new System.Drawing.Point(790, 7);
            this.flpMatchesByAttendance.Name = "flpMatchesByAttendance";
            this.flpMatchesByAttendance.Size = new System.Drawing.Size(350, 700);
            this.flpMatchesByAttendance.TabIndex = 3;
            // 
            // lblMatchesByAttendance
            // 
            this.lblMatchesByAttendance.AutoSize = true;
            this.lblMatchesByAttendance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMatchesByAttendance.Location = new System.Drawing.Point(3, 0);
            this.lblMatchesByAttendance.Name = "lblMatchesByAttendance";
            this.lblMatchesByAttendance.Size = new System.Drawing.Size(214, 28);
            this.lblMatchesByAttendance.TabIndex = 6;
            this.lblMatchesByAttendance.Text = "MatchesByAttendance";
            // 
            // flpPlayersByScores
            // 
            this.flpPlayersByScores.AutoScroll = true;
            this.flpPlayersByScores.Controls.Add(this.lblPlayersByScoreNumber);
            this.flpPlayersByScores.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPlayersByScores.Location = new System.Drawing.Point(35, 7);
            this.flpPlayersByScores.Name = "flpPlayersByScores";
            this.flpPlayersByScores.Size = new System.Drawing.Size(350, 700);
            this.flpPlayersByScores.TabIndex = 0;
            // 
            // lblPlayersByScoreNumber
            // 
            this.lblPlayersByScoreNumber.AutoSize = true;
            this.lblPlayersByScoreNumber.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayersByScoreNumber.Location = new System.Drawing.Point(3, 0);
            this.lblPlayersByScoreNumber.Name = "lblPlayersByScoreNumber";
            this.lblPlayersByScoreNumber.Size = new System.Drawing.Size(236, 28);
            this.lblPlayersByScoreNumber.TabIndex = 4;
            this.lblPlayersByScoreNumber.Text = "Players by score number";
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 29);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1174, 722);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pageRankings);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pageRankings.ResumeLayout(false);
            this.pagePlayers.ResumeLayout(false);
            this.pagePlayers.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flpPlayersByYC.ResumeLayout(false);
            this.flpPlayersByYC.PerformLayout();
            this.flpMatchesByAttendance.ResumeLayout(false);
            this.flpMatchesByAttendance.PerformLayout();
            this.flpPlayersByScores.ResumeLayout(false);
            this.flpPlayersByScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl pageRankings;
        private TabPage pagePlayers;
        private TabPage tabPage2;
        private TabPage Settings;
        private Label lblPlayers;
        private Label lblFavorites;
        private FlowLayoutPanel flpPlayers;
        private FlowLayoutPanel flpFavorites;
        private FlowLayoutPanel flpPlayersByYC;
        private Label lblPlayersByYellowCards;
        private FlowLayoutPanel flpMatchesByAttendance;
        private Label lblMatchesByAttendance;
        private FlowLayoutPanel flpPlayersByScores;
        private Label lblPlayersByScoreNumber;
    }
}