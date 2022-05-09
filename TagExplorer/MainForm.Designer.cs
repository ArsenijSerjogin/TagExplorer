
namespace TagExplorer
{
    partial class TagExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagExplorer));
            this.TagPanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsProgramTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TagPanel
            // 
            this.TagPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.TagPanel, "TagPanel");
            this.TagPanel.Name = "TagPanel";
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.ToolPanel.Controls.Add(this.btnOpen);
            this.ToolPanel.Controls.Add(this.pathText);
            this.ToolPanel.Controls.Add(this.pathLabel);
            resources.ApplyResources(this.ToolPanel, "ToolPanel");
            this.ToolPanel.Name = "ToolPanel";
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pathText
            // 
            this.pathText.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pathText, "pathText");
            this.pathText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pathText.Name = "pathText";
            // 
            // pathLabel
            // 
            resources.ApplyResources(this.pathLabel, "pathLabel");
            this.pathLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathLabel.Name = "pathLabel";
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Url = new System.Uri("c:/", System.UriKind.Absolute);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsProgramTSMItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            resources.ApplyResources(this.programToolStripMenuItem, "programToolStripMenuItem");
            // 
            // settingsProgramTSMItem
            // 
            this.settingsProgramTSMItem.Name = "settingsProgramTSMItem";
            resources.ApplyResources(this.settingsProgramTSMItem, "settingsProgramTSMItem");
            this.settingsProgramTSMItem.Click += new System.EventHandler(this.settingsProgramTSMItem_Click);
            // 
            // TagExplorer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.TagPanel);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TagExplorer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void UpdateComponent()
        {
            //
            // TagPanel
            this.TagPanel.BackColor = DesignManager.Theme.GetColorByName("menuMain");
            //
            // ToolPanel
            this.ToolPanel.BackColor = DesignManager.Theme.GetColorByName("tools");
            //
            // pathText
            this.pathText.BackColor = DesignManager.Theme.GetColorByName("space");
            this.pathText.ForeColor = DesignManager.Theme.GetColorByName("fontColorShadow");
            // TODO: Fix font, idk how ://
            // this.pathText.Font = new System.Drawing.Font(designManager.Theme.Font, designManager.Theme.FontSize);
            // 
            // pathLabel
            this.pathLabel.ForeColor = DesignManager.Theme.GetColorByName("fontColorMain");
            // 
            // TagExplorer
            this.BackColor = DesignManager.Theme.GetColorByName("menuMain");
            //
            // menuStrip
            this.menuStrip.BackColor = DesignManager.Theme.GetColorByName("toolsSecond");
        }

        private System.Windows.Forms.Panel TagPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsProgramTSMItem;
    }
}

