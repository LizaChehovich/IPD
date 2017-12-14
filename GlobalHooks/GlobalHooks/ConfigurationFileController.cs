using System;
using System.IO;
using Newtonsoft.Json;

namespace GlobalHooks
{
    class ConfigurationFileController
    {
        private const string KeyWord = "kisa";

        public ConfigurationInfo ReadFromFile()
        {
            try
            {
                var reader = new StreamReader(@"GH.conf");
                return JsonConvert.DeserializeObject<ConfigurationInfo>(reader.ReadToEnd());
            }
            catch (Exception)
            {
                return new ConfigurationInfo();
            }
        }

        public void SaveToFile(ConfigurationInfo configuration)
        {
            var writer = new StreamWriter(@"GH.conf",false);
            writer.Write(JsonConvert.SerializeObject(configuration));
        }

    }
}
