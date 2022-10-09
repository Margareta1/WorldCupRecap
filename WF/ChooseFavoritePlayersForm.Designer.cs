namespace WF
{
    partial class ChooseFavoritePlayersForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbFP1 = new System.Windows.Forms.ComboBox();
            this.cbFP3 = new System.Windows.Forms.ComboBox();
            this.cbFP2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSave.Location = new System.Drawing.Point(166, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbFP1
            // 
            this.cbFP1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFP1.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP1.FormattingEnabled = true;
            this.cbFP1.Location = new System.Drawing.Point(48, 64);
            this.cbFP1.Name = "cbFP1";
            this.cbFP1.Size = new System.Drawing.Size(337, 39);
            this.cbFP1.TabIndex = 2;
            this.cbFP1.Text = "Choose a favorite player";
            // 
            // cbFP3
            // 
            this.cbFP3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFP3.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP3.FormattingEnabled = true;
            this.cbFP3.Location = new System.Drawing.Point(48, 174);
            this.cbFP3.Name = "cbFP3";
            this.cbFP3.Size = new System.Drawing.Size(337, 39);
            this.cbFP3.TabIndex = 4;
            this.cbFP3.Text = "Choose a favorite player";
            // 
            // cbFP2
            // 
            this.cbFP2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFP2.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP2.FormattingEnabled = true;
            this.cbFP2.Location = new System.Drawing.Point(48, 119);
            this.cbFP2.Name = "cbFP2";
            this.cbFP2.Size = new System.Drawing.Size(337, 39);
            this.cbFP2.TabIndex = 5;
            this.cbFP2.Text = "Choose a favorite player";
            // 
            // ChooseFavoritePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.cbFP2);
            this.Controls.Add(this.cbFP3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbFP1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFavoritePlayersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseFavoritePlayersForm";
            this.Load += new System.EventHandler(this.ChooseFavoritePlayersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private ComboBox cbFP1;
        private ComboBox cbFP3;
        private ComboBox cbFP2;
    }
}