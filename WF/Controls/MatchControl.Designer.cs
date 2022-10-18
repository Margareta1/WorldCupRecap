namespace WF
{
    partial class MatchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchControl));
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblAtt = new System.Windows.Forms.Label();
            this.lblHT = new System.Windows.Forms.Label();
            this.lblAT = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoc
            // 
            resources.ApplyResources(this.lblLoc, "lblLoc");
            this.lblLoc.Name = "lblLoc";
            // 
            // lblAtt
            // 
            resources.ApplyResources(this.lblAtt, "lblAtt");
            this.lblAtt.Name = "lblAtt";
            // 
            // lblHT
            // 
            resources.ApplyResources(this.lblHT, "lblHT");
            this.lblHT.Name = "lblHT";
            // 
            // lblAT
            // 
            resources.ApplyResources(this.lblAT, "lblAT");
            this.lblAT.Name = "lblAT";
            // 
            // lblAwayTeam
            // 
            resources.ApplyResources(this.lblAwayTeam, "lblAwayTeam");
            this.lblAwayTeam.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAwayTeam.Name = "lblAwayTeam";
            // 
            // lblHomeTeam
            // 
            resources.ApplyResources(this.lblHomeTeam, "lblHomeTeam");
            this.lblHomeTeam.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHomeTeam.Name = "lblHomeTeam";
            // 
            // lblAttendance
            // 
            resources.ApplyResources(this.lblAttendance, "lblAttendance");
            this.lblAttendance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAttendance.Name = "lblAttendance";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLocation.Name = "lblLocation";
            // 
            // MatchControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAT);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.lblLoc);
            this.Name = "MatchControl";
            this.Load += new System.EventHandler(this.MatchControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoc;
        private Label lblAtt;
        private Label lblHT;
        private Label lblAT;
        private Label lblAwayTeam;
        private Label lblHomeTeam;
        private Label lblAttendance;
        private Label lblLocation;
    }
}
