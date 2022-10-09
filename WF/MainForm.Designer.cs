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
            this.pageRankings = new System.Windows.Forms.TabControl();
            this.pagePlayers = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.pageRankings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageRankings
            // 
            this.pageRankings.Controls.Add(this.pagePlayers);
            this.pageRankings.Controls.Add(this.tabPage2);
            this.pageRankings.Controls.Add(this.Settings);
            this.pageRankings.Location = new System.Drawing.Point(0, -1);
            this.pageRankings.Name = "pageRankings";
            this.pageRankings.SelectedIndex = 0;
            this.pageRankings.Size = new System.Drawing.Size(1182, 755);
            this.pageRankings.TabIndex = 0;
            // 
            // pagePlayers
            // 
            this.pagePlayers.Location = new System.Drawing.Point(4, 37);
            this.pagePlayers.Name = "pagePlayers";
            this.pagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.pagePlayers.Size = new System.Drawing.Size(1174, 714);
            this.pagePlayers.TabIndex = 0;
            this.pagePlayers.Text = "Players";
            this.pagePlayers.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rankings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 29);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(974, 720);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pageRankings);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.pageRankings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl pageRankings;
        private TabPage pagePlayers;
        private TabPage tabPage2;
        private TabPage Settings;
    }
}