using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs.Concrete
{
    internal class Config : IConfig
    {
        Dictionary<ConfigKey, string> _config = new();
        public AppId GetAppId()
        {
            return new AppId(int.Parse(GetValue(ConfigKey.AppId)));
        }

        public string GetValue(ConfigKey key)
        {
            return _config[key];
        }

        public void SetValue(ConfigKey key, string value)
        {
            if(_config.ContainsKey(key))
            {
                _config[key] = value;
            }
            else
            {
                _config.Add(key, value);
            }
        }
    }
}
