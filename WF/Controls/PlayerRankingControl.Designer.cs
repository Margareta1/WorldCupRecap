namespace WF
{
    partial class PlayerRankingControl
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblGoalsNum = new System.Windows.Forms.Label();
            this.lblYC = new System.Windows.Forms.Label();
            this.lblYCNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(5, 9);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 100);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 1;
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGoals.Location = new System.Drawing.Point(112, 9);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(46, 20);
            this.lblGoals.TabIndex = 2;
            this.lblGoals.Text = "Goals";
            // 
            // lblGoalsNum
            // 
            this.lblGoalsNum.AutoSize = true;
            this.lblGoalsNum.Location = new System.Drawing.Point(112, 35);
            this.lblGoalsNum.Name = "lblGoalsNum";
            this.lblGoalsNum.Size = new System.Drawing.Size(0, 20);
            this.lblGoalsNum.TabIndex = 3;
            // 
            // lblYC
            // 
            this.lblYC.AutoSize = true;
            this.lblYC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYC.Location = new System.Drawing.Point(112, 61);
            this.lblYC.Name = "lblYC";
            this.lblYC.Size = new System.Drawing.Size(91, 20);
            this.lblYC.TabIndex = 4;
            this.lblYC.Text = "Yellow cards";
            // 
            // lblYCNumber
            // 
            this.lblYCNumber.AutoSize = true;
            this.lblYCNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYCNumber.Location = new System.Drawing.Point(112, 89);
            this.lblYCNumber.Name = "lblYCNumber";
            this.lblYCNumber.Size = new System.Drawing.Size(0, 20);
            this.lblYCNumber.TabIndex = 5;
            // 
            // PlayerRankingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblYCNumber);
            this.Controls.Add(this.lblYC);
            this.Controls.Add(this.lblGoalsNum);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPlayer);
            this.Name = "PlayerRankingControl";
            this.Size = new System.Drawing.Size(220, 150);
            this.Load += new System.EventHandler(this.PlayerRankingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPlayer;
        private Label lblName;
        private Label lblGoals;
        private Label lblGoalsNum;
        private Label lblYC;
        private Label lblYCNumber;
    }
}
