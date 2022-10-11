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
            this.tabMain = new System.Windows.Forms.TabControl();
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
            this.btnChangeLan = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocGoalRankings = new System.Drawing.Printing.PrintDocument();
            this.printDocYCRankings = new System.Drawing.Printing.PrintDocument();
            this.printDocAttendance = new System.Drawing.Printing.PrintDocument();
            this.btnPrintGoalRankings = new System.Windows.Forms.Button();
            this.btnPrintYCRankings = new System.Windows.Forms.Button();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.pagePlayers.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flpPlayersByYC.SuspendLayout();
            this.flpMatchesByAttendance.SuspendLayout();
            this.flpPlayersByScores.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pagePlayers);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.Settings);
            this.tabMain.Location = new System.Drawing.Point(0, -1);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1182, 755);
            this.tabMain.TabIndex = 0;
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
            this.lblPlayers.Location = new System.Drawing.Point(610, 3);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(105, 28);
            this.lblPlayers.TabIndex = 3;
            this.lblPlayers.Text = "All players";
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
            this.flpPlayers.Location = new System.Drawing.Point(610, 26);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(526, 672);
            this.flpPlayers.TabIndex = 1;
            // 
            // flpFavorites
            // 
            this.flpFavorites.AutoScroll = true;
            this.flpFavorites.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpFavorites.Location = new System.Drawing.Point(26, 26);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(550, 672);
            this.flpFavorites.TabIndex = 0;
            this.flpFavorites.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrintAttendance);
            this.tabPage2.Controls.Add(this.btnPrintYCRankings);
            this.tabPage2.Controls.Add(this.btnPrintGoalRankings);
            this.tabPage2.Controls.Add(this.flpPlayersByYC);
            this.tabPage2.Controls.Add(this.flpMatchesByAttendance);
            this.tabPage2.Controls.Add(this.flpPlayersByScores);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 714);
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
            this.flpPlayersByYC.Size = new System.Drawing.Size(350, 644);
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
            this.flpMatchesByAttendance.Size = new System.Drawing.Size(350, 644);
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
            this.flpPlayersByScores.Size = new System.Drawing.Size(350, 644);
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
            this.Settings.Controls.Add(this.btnChangeLan);
            this.Settings.Location = new System.Drawing.Point(4, 29);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1174, 722);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // btnChangeLan
            // 
            this.btnChangeLan.BackColor = System.Drawing.Color.IndianRed;
            this.btnChangeLan.Location = new System.Drawing.Point(44, 35);
            this.btnChangeLan.Name = "btnChangeLan";
            this.btnChangeLan.Size = new System.Drawing.Size(200, 45);
            this.btnChangeLan.TabIndex = 0;
            this.btnChangeLan.Text = "Change language";
            this.btnChangeLan.UseVisualStyleBackColor = false;
            this.btnChangeLan.Click += new System.EventHandler(this.btnChangeLan_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocGoalRankings
            // 
            this.printDocGoalRankings.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocGoalRankings_PrintPage);
            // 
            // printDocYCRankings
            // 
            this.printDocYCRankings.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocYCRankings_PrintPage);
            // 
            // printDocAttendance
            // 
            this.printDocAttendance.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocAttendance_PrintPage);
            // 
            // btnPrintGoalRankings
            // 
            this.btnPrintGoalRankings.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintGoalRankings.Location = new System.Drawing.Point(72, 668);
            this.btnPrintGoalRankings.Name = "btnPrintGoalRankings";
            this.btnPrintGoalRankings.Size = new System.Drawing.Size(251, 37);
            this.btnPrintGoalRankings.TabIndex = 4;
            this.btnPrintGoalRankings.Text = "Print goal rankings";
            this.btnPrintGoalRankings.UseVisualStyleBackColor = false;
            this.btnPrintGoalRankings.Click += new System.EventHandler(this.btnPrintGoalRankings_Click);
            // 
            // btnPrintYCRankings
            // 
            this.btnPrintYCRankings.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintYCRankings.Location = new System.Drawing.Point(430, 668);
            this.btnPrintYCRankings.Name = "btnPrintYCRankings";
            this.btnPrintYCRankings.Size = new System.Drawing.Size(275, 37);
            this.btnPrintYCRankings.TabIndex = 5;
            this.btnPrintYCRankings.Text = "Print yellow cards rankings";
            this.btnPrintYCRankings.UseVisualStyleBackColor = false;
            this.btnPrintYCRankings.Click += new System.EventHandler(this.btnPrintYCRankings_Click);
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintAttendance.Location = new System.Drawing.Point(882, 668);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(220, 37);
            this.btnPrintAttendance.TabIndex = 6;
            this.btnPrintAttendance.Text = "Print attendance";
            this.btnPrintAttendance.UseVisualStyleBackColor = false;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tabMain);
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
            this.tabMain.ResumeLayout(false);
            this.pagePlayers.ResumeLayout(false);
            this.pagePlayers.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flpPlayersByYC.ResumeLayout(false);
            this.flpPlayersByYC.PerformLayout();
            this.flpMatchesByAttendance.ResumeLayout(false);
            this.flpMatchesByAttendance.PerformLayout();
            this.flpPlayersByScores.ResumeLayout(false);
            this.flpPlayersByScores.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMain;
        private TabPage pagePlayers;
        private TabPage tabPage2;
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
        private TabPage Settings;
        private Button btnChangeLan;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocGoalRankings;
        private System.Drawing.Printing.PrintDocument printDocYCRankings;
        private System.Drawing.Printing.PrintDocument printDocAttendance;
        private Button btnPrintAttendance;
        private Button btnPrintYCRankings;
        private Button btnPrintGoalRankings;
    }
}