using System;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class KeyConfig : Form
    {
        public KeyConfig()
        {
            InitializeComponent();
        }

        private void KeyConfig_Load(object sender, EventArgs e)
        {
        }

        private void profile1_Click(object sender, EventArgs e)
        {
            setKeyInfo profile1 = new setKeyInfo(1);
            profile1.Show();
        }

        private void profile2_Click(object sender, EventArgs e)
        {
            setKeyInfo profile1 = new setKeyInfo(2);
            profile1.Show();
        }

        private void profile3_Click(object sender, EventArgs e)
        {
            setKeyInfo profile1 = new setKeyInfo(3);
            profile1.Show();
        }

    }
}
