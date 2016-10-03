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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();

            loadStrings();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textHelp;
            this.labelTitle.Text = Properties.Resources.textHelp;
            this.buttonForum.Text = Properties.Resources.textForum;
            this.buttonBugReport.Text = Properties.Resources.textBugReport;
            this.buttonAbout.Text = Properties.Resources.textAbout;
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {

        }

        private void buttonBugReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
