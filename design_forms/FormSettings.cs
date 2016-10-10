using System;
using System.Globalization;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            loadStrings();

            loadData();
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

        private void loadData()
        {
            int x = 0;
            this.comboBoxLanguage.DataSource = ObjectManager.languages;

            for(; x < ObjectManager.languages.Length; x++)
            {
                CultureInfo cultureInfo = ObjectManager.languages[x];
                if(System.Threading.Thread.CurrentThread.CurrentUICulture.Equals(cultureInfo))
                {
                    break;
                }
            }

            if(x >= ObjectManager.languages.Length)
            {
                x = 0;
            }

            this.comboBoxLanguage.SelectedIndex = x;
        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {

        }

        public CultureInfo language
        {
            get
            {
                return this.comboBoxLanguage.SelectedValue as CultureInfo;
            }
        }
    }
}
