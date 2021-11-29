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

                //������forEach�Őݒ���񂵂ăL�[���蓖�Ă̒l�����ɐV�K�쐬
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
