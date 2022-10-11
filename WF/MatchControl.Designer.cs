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
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoc.Location = new System.Drawing.Point(15, 19);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(83, 23);
            this.lblLoc.TabIndex = 0;
            this.lblLoc.Text = "Location:";
            // 
            // lblAtt
            // 
            this.lblAtt.AutoSize = true;
            this.lblAtt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAtt.Location = new System.Drawing.Point(15, 49);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(107, 23);
            this.lblAtt.TabIndex = 1;
            this.lblAtt.Text = "Attendance:";
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHT.Location = new System.Drawing.Point(15, 79);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(109, 23);
            this.lblHT.TabIndex = 2;
            this.lblHT.Text = "Home team:";
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAT.Location = new System.Drawing.Point(15, 109);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(105, 23);
            this.lblAT.TabIndex = 3;
            this.lblAT.Text = "Away team:";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAwayTeam.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAwayTeam.Location = new System.Drawing.Point(132, 109);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(0, 23);
            this.lblAwayTeam.TabIndex = 7;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHomeTeam.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHomeTeam.Location = new System.Drawing.Point(132, 79);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(0, 23);
            this.lblHomeTeam.TabIndex = 6;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttendance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAttendance.Location = new System.Drawing.Point(132, 49);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(0, 23);
            this.lblAttendance.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLocation.Location = new System.Drawing.Point(132, 19);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 23);
            this.lblLocation.TabIndex = 4;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
            this.Size = new System.Drawing.Size(271, 150);
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
