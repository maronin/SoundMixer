using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundMixer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public ComboBox cbInput
        {
            get { return cbInputDevices;  }
        }

        public object getInputItem
        {
            get { return cbInputDevices.SelectedItem; }
        }

        public ComboBox cbOutput
        {
            get { return cbOutputDevices; }
        }

        public ComboBox cbMixedOutput
        {
            get { return cbMusicOutput; }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dropDownClosed(object sender, EventArgs e)
        {
            blankLbl.Focus(); //Super hacky way... But it works. Gets rid of the highlighting on the combo boxes
        }
    }
}
