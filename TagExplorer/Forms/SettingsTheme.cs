using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagExplorer.Forms
{
    public partial class SettingsTheme : Form
    {
        public SettingsTheme()
        {
            InitializeComponent();
            DesignManager.UpdateComponents += UpdateComponent;
            UpdateComponent();
            foreach (string theme in DesignManager.ThemesNames)
                this.ThemeComboBox.Items.Add(theme);
            this.ThemeComboBox.SelectedItem = DesignManager.Theme.Name;
        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignManager.SetNewThemeByName(this.ThemeComboBox.Text);
        }
    }
}
