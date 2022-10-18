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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFavoritePlayersForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.cbFP1 = new System.Windows.Forms.ComboBox();
            this.cbFP3 = new System.Windows.Forms.ComboBox();
            this.cbFP2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbFP1
            // 
            resources.ApplyResources(this.cbFP1, "cbFP1");
            this.cbFP1.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP1.FormattingEnabled = true;
            this.cbFP1.Name = "cbFP1";
            // 
            // cbFP3
            // 
            resources.ApplyResources(this.cbFP3, "cbFP3");
            this.cbFP3.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP3.FormattingEnabled = true;
            this.cbFP3.Name = "cbFP3";
            // 
            // cbFP2
            // 
            resources.ApplyResources(this.cbFP2, "cbFP2");
            this.cbFP2.ForeColor = System.Drawing.Color.IndianRed;
            this.cbFP2.FormattingEnabled = true;
            this.cbFP2.Name = "cbFP2";
            // 
            // ChooseFavoritePlayersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.cbFP2);
            this.Controls.Add(this.cbFP3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbFP1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFavoritePlayersForm";
            this.ShowIcon = false;
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