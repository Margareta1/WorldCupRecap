namespace WF
{
    partial class PlayerControl
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
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlayer.Location = new System.Drawing.Point(32, 20);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(150, 150);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Location = new System.Drawing.Point(34, 180);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(148, 27);
            this.btnChangePhoto.TabIndex = 1;
            this.btnChangePhoto.Text = "Change photo";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(202, 20);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(0, 20);
            this.lblFavorite.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(202, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(202, 99);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 20);
            this.lblNumber.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(202, 134);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 20);
            this.lblPosition.TabIndex = 5;
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(202, 167);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(0, 20);
            this.lblCaptain.TabIndex = 6;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.pbPlayer);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(302, 245);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPlayer;
        private Button btnChangePhoto;
        private Label lblFavorite;
        private Label lblName;
        private Label lblNumber;
        private Label lblPosition;
        private Label lblCaptain;
    }
}
