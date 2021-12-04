using System.Collections.Generic;

namespace Design_Patterns_OOP.Creational.Singleton
{
    public class ConfigManager
    {
        private static ConfigManager _instance;

        private Dictionary<string, object> settings = new();

        private ConfigManager()
        {
        }

        public static ConfigManager GetInstance()
        {
            return _instance ??= new ConfigManager();
        }

        public void AddSetting(string key, object val)
        {
            _instance.settings.TryAdd(key, val);
        }

        public object GetSetting(string key)
        {
            return _instance.settings.GetValueOrDefault(key);
        }
    }
}