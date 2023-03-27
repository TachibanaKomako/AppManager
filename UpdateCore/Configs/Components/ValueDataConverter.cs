using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs.Concrete;

namespace UpdateCore.Configs.Components
{
    internal class ValueDataConverter
    {
        public static IConfig ToConfig(ValueData[] valueDatas)
        {
            Config config = new();
            foreach (var valueData in valueDatas)
            {
                config.SetValue(valueData.Key, valueData.Content);
            }
            return config;
        }
        public static IEnumerable<ValueData> ToValueDatas(IConfig config)
        {
            foreach(ConfigKey key in Enum.GetValues(typeof(ConfigKey)))
            {
                string value = config.GetValue(key);
                if (string.IsNullOrEmpty(value) is false)
                {
                    yield return new ValueData { Content = value, Key = key };
                }
            }
        }
    }
}
