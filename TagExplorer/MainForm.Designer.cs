
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
            this.ToolPanel.SuspendLayout();
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
            this.pathLabel.Name = "pathLabel";
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Url = new System.Uri("c:/", System.UriKind.Absolute);
            // 
            // TagExplorer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.TagPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "TagExplorer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TagPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

