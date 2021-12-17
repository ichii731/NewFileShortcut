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
                MessageBox.Show("既に起動しています。二重起動はできません。");
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

                //ここにforEachで設定を回してキー割り当ての値を元に新規作成
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
                    MessageBox.Show("設定ファイルの読み込みに失敗しました\n確認して再起動してください");
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
