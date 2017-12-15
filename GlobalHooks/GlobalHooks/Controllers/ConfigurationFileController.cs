using System;
using System.Collections.Generic;
using System.IO;
using GlobalHooks.Model;
using Newtonsoft.Json;

namespace GlobalHooks.Controllers
{
    class ConfigurationFileController
    {
        private const string KeyWord = @"Interfaces and Peripheral Devices";
        private readonly List<char> _alphabet = new List<char>();

        public ConfigurationFileController()
        {
            for (var index = 0; index < 95; index++)
            {
                _alphabet.Add((char) (' ' + index));
            }
        }

        public ConfigurationInfo ReadFromFile()
        {
            try
            {
                using (var reader = new StreamReader(@"GH.config"))
                {
                    var config = JsonConvert.DeserializeObject<ConfigurationInfo>(Decode(reader.ReadToEnd()));
                    return config ?? GetDefaultConfigurationInfo();
                }
            }
            catch (Exception)
            {
                return GetDefaultConfigurationInfo();
            }
        }

        public void SaveToFile(ConfigurationInfo configuration)
        {
            using (var writer = new StreamWriter(@"GH.config", false))
            {
                writer.Write(Encode(JsonConvert.SerializeObject(configuration)));
            }
        }

        private string Encode(string configuration)
        {
            var result = string.Empty;
            var positionInKeyWord = 0;
            foreach (var symbol in configuration)
            {
               result += _alphabet[
                    (_alphabet.IndexOf(symbol) + _alphabet.IndexOf(KeyWord[positionInKeyWord])) % _alphabet.Count];
                positionInKeyWord = GetNextPositionInKeyWord(positionInKeyWord);
            }
            return result;
        }

        private string Decode(string configuration)
        {
            var result = string.Empty;
            var positionInKeyWord = 0;
            foreach (var symbol in configuration)
            {
                result += _alphabet[(
                    _alphabet.IndexOf(symbol) + _alphabet.Count - _alphabet.IndexOf(KeyWord[positionInKeyWord])) % _alphabet.Count];
                positionInKeyWord = GetNextPositionInKeyWord(positionInKeyWord);
            }
            return result;
        }

        private int GetNextPositionInKeyWord(int currentPosition)
        {
            return currentPosition == KeyWord.Length - 1 ? 0 : ++currentPosition;
        }

        private ConfigurationInfo GetDefaultConfigurationInfo()
        {
            return new ConfigurationInfo()
            {
                To = string.Empty,
                FileSize = 0,
                HiddenMode = false,
                From = string.Empty,
                Password = string.Empty,
                ShortcutToDisconnect = null,
                ShortcutToDisplayTheWindow = null,
                ShortcutToDisplayAdvancedSettings = null
            };
        }

    }
}
