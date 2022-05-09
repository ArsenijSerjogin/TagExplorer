using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagExplorer
{
    public partial class Settings : Form
    {
        private Button currentСategoryButton;
        private Form activeCatigoryForm;

        public Settings()
        {
            InitializeComponent();
            UpdateComponent();
            DesignManager.UpdateComponents += UpdateComponent;
            SelectСategoryButton(this.btnThemeSettings);
            OpenCategoryForm(new Forms.SettingsTheme());
        }

        private void OpenCategoryForm(Form categoryForm)
        {
            if (activeCatigoryForm != null)
            {
                activeCatigoryForm.Close();
            }
            activeCatigoryForm = categoryForm;
            categoryForm.TopLevel = false;
            categoryForm.FormBorderStyle = FormBorderStyle.None;
            categoryForm.Dock = DockStyle.Fill;
            this.panelSetting.Controls.Add(categoryForm);
            this.panelSetting.Tag = categoryForm;
            categoryForm.BringToFront();
            categoryForm.Show();
        }

        private void SelectСategoryButton(object btnSender)
        {
            if (btnSender == null) return;

            if(currentСategoryButton != (Button)btnSender)
            {               
                DisableСategoryButton();                    // Disable previus button
                currentСategoryButton = (Button)btnSender;  // Set current button
                ActivateCategoryButton();                   // Activate current button
            }
        }

        private void btnThemeSettings_Click(object sender, EventArgs e)
        {
            SelectСategoryButton(sender);
            OpenCategoryForm(new Forms.SettingsTheme());
        }
    }
}
