using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Configuration;

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
            string key = ConfigurationManager.AppSettings["key"];
            key1.Text = key;
            
        }
        private void Cofirm_Click(object sender, EventArgs e)
        {
        }
    }
}
