using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shoppe.Model.Settings
{
    public class AppSettings
    {
        [JsonInclude]
        public string ConnectionStrings { get; set; } = null!;
        private static JsonSerializerOptions _options;
        public AppSettings()
        {
            _options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
                PropertyNamingPolicy = null,
            };
        }
        public void SaveAsJsonFormat(string fileName)
        {
            File.WriteAllText(fileName, JsonSerializer.Serialize(this, _options));
        }
        public static AppSettings ReadAsJsonFormat(string fileName)
        {
            return JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(fileName), _options)!;
        }
    };
}
