using System.Diagnostics;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class AboutApp : Form
    {
        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }
        public AboutApp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://ic731.net/NewFileShortcut");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://github.com/ichii731/NewFileShortcut");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenUrl("https://ic731.net/NewFileShortcut/release");
        }
    }
}
