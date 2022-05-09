namespace TagExplorer.Forms
{
    partial class SettingsTheme
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(34, 27);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(58, 20);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Theme";
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeComboBox.Location = new System.Drawing.Point(99, 27);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThemeComboBox.Sorted = true;
            this.ThemeComboBox.TabIndex = 1;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // SettingsTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 457);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.lblTheme);
            this.Name = "SettingsTheme";
            this.Text = "SettingsTheme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void UpdateComponent()
        {
            
        }

        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox ThemeComboBox;
    }
}