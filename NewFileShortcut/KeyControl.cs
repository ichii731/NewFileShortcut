using NonInvasiveKeyboardHookLibrary;
using SHDocVw;
using Shell32;
using System;
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
            //コンストラクタで引数を作成
            key = _vkey;
            name = _name;
            ext = _ext;
            content = _content;
            ctrl = _ctrl;
            alt = _alt;
            shift = _shift;
        }

        public void StartKeyControl()
        {
            KeyboardHookManager keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();

            if (ctrl && shift && alt)
            {
                // ctrl + alt + shift
                keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt, NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift }, key, () =>
                {
                    createThread();
                });
            }
            else if (ctrl && shift && !alt)
            {
                // ctrl + shift
                keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift }, key, () =>
                {
                    createThread();
                });
            }
            else if (ctrl && !shift && alt)
            {
                // ctrl + alt
                keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt }, key, () =>
                {
                    createThread();
                });
            }
            else if (!ctrl && shift && alt)
            {
                // shift + alt
                keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift, NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt }, key, () =>
                {
                    createThread();
                });
            }
            else if (ctrl && !shift && !alt)
            {
                // ctrl
                keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, key, () =>
                {
                    createThread();
                });
            }
            else if (shift)
            {
                // shift
                keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift, key, () =>
                {
                    createThread();
                });
            }
            else if (!ctrl && !shift && alt)
            {
                // alt
                keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt, key, () =>
                {
                    createThread();
                });
            }
            else if (!ctrl && !shift && !alt)
            {
                // None
                keyboardHookManager.RegisterHotkey(key, () =>
                {
                    createThread();
                });
            }
        }

        public void createThread()
        {

            Thread t = new Thread(() =>
            {
                CreateProcess();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void CreateProcess()
        {
            try
            {
                // Create shell class
                Shell shell = new Shell();
                // Get all Explore&IE path
                ShellWindows win = shell.Windows();

                int chars = 256;
                StringBuilder buff = new StringBuilder(chars);

                // Obtain the handle of the active window
                IntPtr handle = GetForegroundWindow();

                // Update control
                if (GetWindowText(handle, buff, chars) > 0)
                {
                    foreach (IWebBrowser2 web in win)
                    {
                        //Exclude IE Path
                        if (Path.GetFileName(web.FullName).ToUpper() == "EXPLORER.EXE")
                        {
                            if (buff.ToString() == web.LocationName)
                            {
                                string getfile = web.LocationURL.Remove(0, 8);
                                getfile = System.Web.HttpUtility.UrlDecode(getfile);

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