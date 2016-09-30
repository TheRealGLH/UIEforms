using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_forms
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            SetText();
        }


        void SetText()
        {
            lblHelpName.Text = Properties.Resources.HelpName;
            btnAbout.Text = Properties.Resources.HelpAbout;
            btnBugReport.Text = Properties.Resources.HelpBugReport;
            btnForum.Text = Properties.Resources.HelpForum;
            lblBack.Text = Properties.Resources.GenBackToMenu;
        }
    }
}
