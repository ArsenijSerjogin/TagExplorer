namespace TagExplorer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.CatigoriesPanel = new System.Windows.Forms.Panel();
            this.btnThemeSettings = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.CatigoriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatigoriesPanel
            // 
            this.CatigoriesPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CatigoriesPanel.Controls.Add(this.btnThemeSettings);
            this.CatigoriesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CatigoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.CatigoriesPanel.Name = "CatigoriesPanel";
            this.CatigoriesPanel.Size = new System.Drawing.Size(172, 496);
            this.CatigoriesPanel.TabIndex = 0;
            // 
            // btnThemeSettings
            // 
            this.btnThemeSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThemeSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemeSettings.FlatAppearance.BorderSize = 0;
            this.btnThemeSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemeSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemeSettings.Location = new System.Drawing.Point(0, 0);
            this.btnThemeSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnThemeSettings.Name = "btnThemeSettings";
            this.btnThemeSettings.Size = new System.Drawing.Size(172, 41);
            this.btnThemeSettings.TabIndex = 0;
            this.btnThemeSettings.Text = "Theme";
            this.btnThemeSettings.UseVisualStyleBackColor = false;
            this.btnThemeSettings.Click += new System.EventHandler(this.btnThemeSettings_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(172, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(280, 496);
            this.panelSetting.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 496);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.CatigoriesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.CatigoriesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void DisableСategoryButton()
        {
            if (currentСategoryButton != null)
                currentСategoryButton.BackColor = DesignManager.Theme.GetColorByName("deselectedButton");
        }
        private void ActivateCategoryButton()
        {
            if (currentСategoryButton != null)
                currentСategoryButton.BackColor = DesignManager.Theme.GetColorByName("selectedButton");
        }

        private void UpdateComponent()
        {
            //
            // CatigoriesPanel
            this.CatigoriesPanel.BackColor = DesignManager.Theme.GetColorByName("toolsSecond");
            //
            //btnThemeSettings
            this.btnThemeSettings.BackColor = DesignManager.Theme.GetColorByName("deselectedButton");
            this.btnThemeSettings.ForeColor = DesignManager.Theme.GetColorByName("fontColorMain");
        }

        private System.Windows.Forms.Panel CatigoriesPanel;
        private System.Windows.Forms.Button btnThemeSettings;
        private System.Windows.Forms.Panel panelSetting;
    }
}