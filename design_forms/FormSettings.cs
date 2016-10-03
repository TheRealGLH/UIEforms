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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            loadStrings();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textSettings;
            this.labelTitle.Text = Properties.Resources.textSettings;
            this.groupBoxGeneral.Text = Properties.Resources.textGeneral;
            this.labelLanguage.Text = Properties.Resources.textLanguage;
            this.labelColor.Text = Properties.Resources.textColor;
            this.labelFont.Text = Properties.Resources.textFont;
            this.labelScale.Text = Properties.Resources.textScale;
            this.buttonLoadPreset.Text = Properties.Resources.textLoadPreset;
            this.buttonOk.Text = Properties.Resources.textOk;
            this.buttonCancel.Text = Properties.Resources.textCancel;
        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {

        }
    }
}
