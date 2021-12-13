using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFileShortcut
{
    public partial class setKeyInfo : Form
    {
        int id;
        JsonRW keyJson = new JsonRW();
        string json_file = File.ReadAllText(Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\config\key.json", Encoding.UTF8);

        public setKeyInfo(int _id)
        {
            InitializeComponent();
            this.Text = "プロファイル" + _id + " 割り当て設定";
            active.Text = "プロファイル" + _id + "の設定を有効にする";
            id = _id - 1;
            try
            {
                keyJson = JsonSerializer.Deserialize<JsonRW>(json_file);
                active.Checked = keyJson.key[id].active;
                key.Text = keyJson.key[id].key;
                ctrl.Checked = keyJson.key[id].ctrl;
                shift.Checked = keyJson.key[id].shift;
                alt.Checked = keyJson.key[id].alt;

                name.Text = keyJson.key[id].name;
                ext.Text = keyJson.key[id].ext;
                content.Text = keyJson.key[id].content;

            }
            catch (Exception readerr)
            {
                MessageBox.Show("設定の読み込みに失敗しました。\n" + readerr.Message);
                this.Close();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                keyJson = JsonSerializer.Deserialize<JsonRW>(json_file);
                keyJson.key[id].key = key.Text;
                keyJson.key[id].name = name.Text;
                keyJson.key[id].ext = ext.Text;
                keyJson.key[id].content = content.Text;

                if (ctrl.Checked)
                {
                    keyJson.key[id].ctrl = true;
                }
                else
                {
                    keyJson.key[id].ctrl = false;
                }
                if (shift.Checked)
                {
                    keyJson.key[id].shift = true;
                }
                else
                {
                    keyJson.key[id].shift = false;
                }
                if (alt.Checked)
                {
                    keyJson.key[id].alt = true;
                }
                else
                {
                    keyJson.key[id].alt = false;
                }


                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                var json = JsonSerializer.Serialize(keyJson, options);
                File.WriteAllText(Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\config\key.json", json);
                MessageBox.Show("正常に保存しました。再起動後に適用されます。");
                this.Close();
            }
            catch (Exception writeerr)
            {
                MessageBox.Show("設定ファイルの書き込みに失敗しました。権限などを確認してください。\n" + writeerr.Message) ;
                
            }


        }
    }
}
