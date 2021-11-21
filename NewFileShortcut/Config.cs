using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SetStartup();
            }
            else
            {
                DeleteStartup();
            }
            
        }

        public static void SetStartup()
        {
            Microsoft.Win32.RegistryKey regkey =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true);
            regkey.SetValue(Application.ProductName, Application.ExecutablePath);
            regkey.Close();
        }
        public static void DeleteStartup()
        {
            Microsoft.Win32.RegistryKey regkey =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true);
            regkey.DeleteValue(Application.ProductName, false);
            regkey.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //設定ファイルパスを開く
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //設定書き出しをする！
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
