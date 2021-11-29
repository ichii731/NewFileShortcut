using NonInvasiveKeyboardHookLibrary;
using SHDocVw;
using Shell32;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace NewFileShortcut
{
    class KeyControl
    {
        private int key;
        private bool ctrl;
        private bool shift;
        private bool alt;
        private string name;
        private string ext;
        private string content;

        // Declare external functions.
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public KeyControl(int _vkey,
            bool _ctrl,
            bool _shift,
            bool _alt,
            string _name,
            string _ext,
            string _content)
        {
            //コンストラクタで35行目の引数を作成
            key = _vkey;
            name = _name;
            ext = _ext;
            content = _content;
        }

        public void StartKeyControl()
        {
            var keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();
            keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, key, () =>
            {
                // STAスレッド
                var t = new Thread(() =>
                {
                    CreateProcess();
                });

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            });
        }

        public void CreateProcess()
        {
            try
            {
                //COMのShellクラス作成
                Shell shell = new Shell();
                //IEとエクスプローラの一覧を取得
                ShellWindows win = shell.Windows();

                int chars = 256;
                StringBuilder buff = new StringBuilder(chars);

                // Obtain the handle of the active window.
                IntPtr handle = GetForegroundWindow();


                // Update the controls.
                if (GetWindowText(handle, buff, chars) > 0)
                {
                    foreach (IWebBrowser2 web in win)
                    {
                        //エクスプローラのみ(IEを除外)
                        if (Path.GetFileName(web.FullName).ToUpper() == "EXPLORER.EXE")
                        {
                            if (buff.ToString() == web.LocationName)
                            {
                                string getfile = web.LocationURL.Remove(0, 8);
                                getfile = System.Web.HttpUtility.UrlDecode(getfile);
                                //リストに追加

                                //FileStream fs = File.Create(getfile + "/new.csv");
                                //fs.Close();
                                File.WriteAllText(getfile + "/" + name + "." + ext, content);
                            }
                        }

                    }

                }
            }

            catch (Exception err)
            {
                string errString = err.ToString();
                if (Regex.IsMatch(errString, "System.IO.FileNotFoundException"))
                {
                    MessageBox.Show("ファイルが作成できませんでした\n書き込み権限などを確認してください",
                        "作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (Regex.IsMatch(errString, "System.IO.DirectoryNotFoundException"))
                {
                    MessageBox.Show("フォルダが確認できませんでした\nネットワークやWSLディレクトリでは失敗する可能性があります",
"作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    MessageBox.Show(errString);
                }
            }

        }
    }

}