using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFileShortcut
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            new MainForm();

            //ここにforEachで設定を回してキー割り当ての値を元に新規作成
            KeyControl kc = new KeyControl(int.Parse(ConfigurationManager.AppSettings["key"]));
            kc.StartKeyControl();
            Application.Run();
        }
    }
}
