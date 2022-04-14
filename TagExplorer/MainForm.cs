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
    public partial class TagExplorer : Form
    {
        public TagExplorer()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "select" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    webBrowser.Url = new Uri(fbd.SelectedPath);
            }
        }
    }
}
