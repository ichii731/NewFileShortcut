using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class setKeyInfo : Form
    {
        public setKeyInfo(int _id)
        {
            this.Text = "プロファイル" + _id + " 割り当て設定";
            InitializeComponent();
            JsonRW keyJson = JsonRW.JsonRead();
            active1.Checked = keyJson.key[0].active;
            key1.Text = keyJson.key[0].key;
            ctrl1.Checked = keyJson.key[0].ctrl;
            shift1.Checked = keyJson.key[0].shift;
            alt1.Checked = keyJson.key[0].alt;

            name1.Text = keyJson.key[0].name;
            ext1.Text = keyJson.key[0].ext;
            content1.Text = keyJson.key[0].content;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            JsonRW keyJson = JsonRW.JsonRead();
            keyJson.key[0].key = key1.Text;
            keyJson.key[0].name = name1.Text;
            keyJson.key[0].ext = ext1.Text;
            keyJson.key[0].content = content1.Text;

            if (ctrl1.Checked)
            {
                keyJson.key[0].ctrl = true;
            }
            else
            {
                keyJson.key[0].ctrl = false;
            }
            if (shift1.Checked)
            {
                keyJson.key[0].shift = true;
            }
            else
            {
                keyJson.key[0].shift = false;
            }
            if (alt1.Checked)
            {
                keyJson.key[0].alt = true;
            }
            else
            {
                keyJson.key[0].alt = false;
            }

            File.WriteAllText(@"C:\Users\tomomi\Downloads\key.json", JsonRW.JsonWrite(keyJson));
        }
    }
}
