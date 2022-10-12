namespace WF
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.btnHR = new System.Windows.Forms.RadioButton();
            this.btnEN = new System.Windows.Forms.RadioButton();
            this.gbCup = new System.Windows.Forms.GroupBox();
            this.btnMen = new System.Windows.Forms.RadioButton();
            this.btnWomen = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbLanguage.SuspendLayout();
            this.gbCup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguage
            // 
            resources.ApplyResources(this.gbLanguage, "gbLanguage");
            this.gbLanguage.Controls.Add(this.btnHR);
            this.gbLanguage.Controls.Add(this.btnEN);
            this.gbLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.TabStop = false;
            // 
            // btnHR
            // 
            resources.ApplyResources(this.btnHR, "btnHR");
            this.btnHR.Name = "btnHR";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnEN
            // 
            resources.ApplyResources(this.btnEN, "btnEN");
            this.btnEN.Checked = true;
            this.btnEN.Name = "btnEN";
            this.btnEN.TabStop = true;
            this.btnEN.UseVisualStyleBackColor = true;
            // 
            // gbCup
            // 
            resources.ApplyResources(this.gbCup, "gbCup");
            this.gbCup.Controls.Add(this.btnMen);
            this.gbCup.Controls.Add(this.btnWomen);
            this.gbCup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCup.Name = "gbCup";
            this.gbCup.TabStop = false;
            // 
            // btnMen
            // 
            resources.ApplyResources(this.btnMen, "btnMen");
            this.btnMen.Name = "btnMen";
            this.btnMen.UseVisualStyleBackColor = true;
            // 
            // btnWomen
            // 
            resources.ApplyResources(this.btnWomen, "btnWomen");
            this.btnWomen.Checked = true;
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.TabStop = true;
            this.btnWomen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EntryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCup);
            this.Controls.Add(this.gbLanguage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbCup.ResumeLayout(false);
            this.gbCup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbLanguage;
        private RadioButton btnHR;
        private RadioButton btnEN;
        private GroupBox gbCup;
        private RadioButton btnMen;
        private RadioButton btnWomen;
        private Button btnSave;
        private Button btnCancel;
    }
}