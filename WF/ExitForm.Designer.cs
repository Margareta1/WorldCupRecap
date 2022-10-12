namespace WF
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblLeave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.BackColor = System.Drawing.Color.IndianRed;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYes.Name = "btnYes";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            resources.ApplyResources(this.btnNo, "btnNo");
            this.btnNo.BackColor = System.Drawing.Color.IndianRed;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNo.Name = "btnNo";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // lblLeave
            // 
            resources.ApplyResources(this.lblLeave, "lblLeave");
            this.lblLeave.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLeave.Name = "lblLeave";
            // 
            // ExitForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitForm";
            this.ShowIcon = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label lblLeave;
    }
}