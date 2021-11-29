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
         JsonRW keyJson = JsonRW.JsonRead();

            foreach (var keyConfig in keyJson.key)
            {
                if (keyConfig.active)
                {
                    KeyControl kc = new KeyControl(int.Parse(keyConfig.key),
                        keyConfig.ctrl,
                        keyConfig.shift,
                        keyConfig.alt,
                        keyConfig.name,
                        keyConfig.ext,
                        keyConfig.content);
                    kc.StartKeyControl();
                }
            }
            Application.Run();
        }
    }
}
