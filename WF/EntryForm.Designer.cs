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
            this.gbLanguage.Controls.Add(this.btnHR);
            this.gbLanguage.Controls.Add(this.btnEN);
            this.gbLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbLanguage.Location = new System.Drawing.Point(94, 50);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(295, 92);
            this.gbLanguage.TabIndex = 0;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Choose language";
            // 
            // btnHR
            // 
            this.btnHR.AutoSize = true;
            this.btnHR.Location = new System.Drawing.Point(175, 46);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(61, 32);
            this.btnHR.TabIndex = 1;
            this.btnHR.Text = "HR";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnEN
            // 
            this.btnEN.AutoSize = true;
            this.btnEN.Checked = true;
            this.btnEN.Location = new System.Drawing.Point(29, 46);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(60, 32);
            this.btnEN.TabIndex = 0;
            this.btnEN.TabStop = true;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = true;
            // 
            // gbCup
            // 
            this.gbCup.Controls.Add(this.btnMen);
            this.gbCup.Controls.Add(this.btnWomen);
            this.gbCup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCup.Location = new System.Drawing.Point(94, 180);
            this.gbCup.Name = "gbCup";
            this.gbCup.Size = new System.Drawing.Size(295, 92);
            this.gbCup.TabIndex = 1;
            this.gbCup.TabStop = false;
            this.gbCup.Text = "Choose cup";
            // 
            // btnMen
            // 
            this.btnMen.AutoSize = true;
            this.btnMen.Location = new System.Drawing.Point(175, 46);
            this.btnMen.Name = "btnMen";
            this.btnMen.Size = new System.Drawing.Size(75, 32);
            this.btnMen.TabIndex = 1;
            this.btnMen.Text = "Men";
            this.btnMen.UseVisualStyleBackColor = true;
            // 
            // btnWomen
            // 
            this.btnWomen.AutoSize = true;
            this.btnWomen.Checked = true;
            this.btnWomen.Location = new System.Drawing.Point(29, 46);
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.Size = new System.Drawing.Size(105, 32);
            this.btnWomen.TabIndex = 0;
            this.btnWomen.TabStop = true;
            this.btnWomen.Text = "Women";
            this.btnWomen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSave.Location = new System.Drawing.Point(94, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(255, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCup);
            this.Controls.Add(this.gbLanguage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose settings";
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