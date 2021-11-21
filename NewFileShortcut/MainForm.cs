using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // アプリケーションの終了
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void uuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutApp AboutApp = new AboutApp();
            AboutApp.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Config Config = new Config();
            Config.Show();
        }
    }
}

