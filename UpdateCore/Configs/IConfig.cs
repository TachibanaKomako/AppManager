using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs
{
    public interface IConfig
    {
        string GetValue(ConfigKey key);
        void SetValue(ConfigKey key, string value);
        AppId GetAppId();
    }
}
