using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
    }
}
