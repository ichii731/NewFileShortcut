using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Windows.Forms;

namespace NewFileShortcut
{
    class JsonRW

    {
        // 文字列型
        [JsonPropertyName("json_ver")]
        public string Token { get; set; }
        // リスト型
        [JsonPropertyName("key")]
        public Key[] key { get; set; }
        public class Key
        {
            public bool active { get; set; }
            public string key { get; set; }
            public bool ctrl { get; set; }
            public bool shift { get; set; }
            public bool alt { get; set; }
            public string name { get; set; }
            public string ext { get; set; }
            public string content { get; set; }
        }


        public static JsonRW JsonRead()
        {
            string json_file = File.ReadAllText(@"C:\Users\tomomi\Downloads\key.json", Encoding.UTF8);

            if (String.IsNullOrEmpty(json_file))
            {
                return null;
            }
            try
            {
                JsonRW keyJson = JsonSerializer.Deserialize<JsonRW>(json_file);
                return keyJson;
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static string JsonWrite(Object keyObj)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                var json = JsonSerializer.Serialize(keyObj, options);
                return json;
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
