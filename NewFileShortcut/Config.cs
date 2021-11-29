using System;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class Config : Form
    {
        Microsoft.Win32.RegistryKey regkey = 
            Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true);

        public Config()
        {
            InitializeComponent();
            string regValue = (string)regkey.GetValue(Application.ProductName);
            if (regValue == Application.ExecutablePath)
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                regkey.SetValue(Application.ProductName, Application.ExecutablePath);
                regkey.Close();
            }
            else
            {
                regkey.DeleteValue(Application.ProductName, false);
                regkey.Close();
            }
            Application.Restart();
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
