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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pagePlayers = new System.Windows.Forms.TabPage();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblFavorites = new System.Windows.Forms.Label();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.btnPrintYCRankings = new System.Windows.Forms.Button();
            this.btnPrintGoalRankings = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Controls.Add(this.pagePlayers);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.Settings);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            // 
            // pagePlayers
            // 
            resources.ApplyResources(this.pagePlayers, "pagePlayers");
            this.pagePlayers.Controls.Add(this.lblPlayers);
            this.pagePlayers.Controls.Add(this.lblFavorites);
            this.pagePlayers.Controls.Add(this.flpPlayers);
            this.pagePlayers.Controls.Add(this.flpFavorites);
            this.pagePlayers.Name = "pagePlayers";
            this.pagePlayers.UseVisualStyleBackColor = true;
            // 
            // lblPlayers
            // 
            resources.ApplyResources(this.lblPlayers, "lblPlayers");
            this.lblPlayers.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayers.Name = "lblPlayers";
            // 
            // lblFavorites
            // 
            resources.ApplyResources(this.lblFavorites, "lblFavorites");
            this.lblFavorites.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFavorites.Name = "lblFavorites";
            // 
            // flpPlayers
            // 
            resources.ApplyResources(this.flpPlayers, "flpPlayers");
            this.flpPlayers.Name = "flpPlayers";
            // 
            // flpFavorites
            // 
            resources.ApplyResources(this.flpFavorites, "flpFavorites");
            this.flpFavorites.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Tag = "";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.btnPrintAttendance);
            this.tabPage2.Controls.Add(this.btnPrintYCRankings);
            this.tabPage2.Controls.Add(this.btnPrintGoalRankings);
            this.tabPage2.Controls.Add(this.flpPlayersByYC);
            this.tabPage2.Controls.Add(this.flpMatchesByAttendance);
            this.tabPage2.Controls.Add(this.flpPlayersByScores);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrintAttendance
            // 
            resources.ApplyResources(this.btnPrintAttendance, "btnPrintAttendance");
            this.btnPrintAttendance.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.UseVisualStyleBackColor = false;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // btnPrintYCRankings
            // 
            resources.ApplyResources(this.btnPrintYCRankings, "btnPrintYCRankings");
            this.btnPrintYCRankings.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintYCRankings.Name = "btnPrintYCRankings";
            this.btnPrintYCRankings.UseVisualStyleBackColor = false;
            this.btnPrintYCRankings.Click += new System.EventHandler(this.btnPrintYCRankings_Click);
            // 
            // btnPrintGoalRankings
            // 
            resources.ApplyResources(this.btnPrintGoalRankings, "btnPrintGoalRankings");
            this.btnPrintGoalRankings.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrintGoalRankings.Name = "btnPrintGoalRankings";
            this.btnPrintGoalRankings.UseVisualStyleBackColor = false;
            this.btnPrintGoalRankings.Click += new System.EventHandler(this.btnPrintGoalRankings_Click);
            // 
            // flpPlayersByYC
            // 
            resources.ApplyResources(this.flpPlayersByYC, "flpPlayersByYC");
            this.flpPlayersByYC.Controls.Add(this.lblPlayersByYellowCards);
            this.flpPlayersByYC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPlayersByYC.Name = "flpPlayersByYC";
            // 
            // lblPlayersByYellowCards
            // 
            resources.ApplyResources(this.lblPlayersByYellowCards, "lblPlayersByYellowCards");
            this.lblPlayersByYellowCards.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayersByYellowCards.Name = "lblPlayersByYellowCards";
            // 
            // flpMatchesByAttendance
            // 
            resources.ApplyResources(this.flpMatchesByAttendance, "flpMatchesByAttendance");
            this.flpMatchesByAttendance.Controls.Add(this.lblMatchesByAttendance);
            this.flpMatchesByAttendance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpMatchesByAttendance.Name = "flpMatchesByAttendance";
            // 
            // lblMatchesByAttendance
            // 
            resources.ApplyResources(this.lblMatchesByAttendance, "lblMatchesByAttendance");
            this.lblMatchesByAttendance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMatchesByAttendance.Name = "lblMatchesByAttendance";
            // 
            // flpPlayersByScores
            // 
            resources.ApplyResources(this.flpPlayersByScores, "flpPlayersByScores");
            this.flpPlayersByScores.Controls.Add(this.lblPlayersByScoreNumber);
            this.flpPlayersByScores.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPlayersByScores.Name = "flpPlayersByScores";
            // 
            // lblPlayersByScoreNumber
            // 
            resources.ApplyResources(this.lblPlayersByScoreNumber, "lblPlayersByScoreNumber");
            this.lblPlayersByScoreNumber.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlayersByScoreNumber.Name = "lblPlayersByScoreNumber";
            // 
            // Settings
            // 
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.Controls.Add(this.btnChangeLan);
            this.Settings.Name = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // btnChangeLan
            // 
            resources.ApplyResources(this.btnChangeLan, "btnChangeLan");
            this.btnChangeLan.BackColor = System.Drawing.Color.IndianRed;
            this.btnChangeLan.Name = "btnChangeLan";
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.tabMain);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
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