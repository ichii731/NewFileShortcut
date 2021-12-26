using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
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
            // Block double start (Mutex)
            string appName = "NewFileShortcut";
            bool newMutex;
            Mutex mutex = new System.Threading.Mutex(true, appName, out newMutex);
            if (!newMutex)
            {
                MessageBox.Show("���ɋN�����Ă��܂��B��d�N���͂ł��܂���B");
                mutex.Close();
                return;
            }

            try
            {
                // Main Program
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new MainForm());
                new MainForm();

                //������forEach�Őݒ���񂵂ăL�[���蓖�Ă̒l�����ɐV�K�쐬
                try
                {
                    JsonRW keyJson = new JsonRW();
                    string json_file = File.ReadAllText(Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\config\key.json", Encoding.UTF8);
                    keyJson = JsonSerializer.Deserialize<JsonRW>(json_file);
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
                catch (Exception e)
                {
                    MessageBox.Show("�ݒ�t�@�C���̓ǂݍ��݂Ɏ��s���܂���\n�m�F���čċN�����Ă�������");
                    Application.Exit();
                }
            }
            finally
            {
                // Release Mutex
                mutex.ReleaseMutex();
                mutex.Close();
            }
        }
    }
}
