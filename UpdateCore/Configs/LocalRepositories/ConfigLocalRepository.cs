using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs.Components;
using UpdateCore.Configs.Components.Files;

namespace UpdateCore.Configs.LocalRepositories
{
    internal class ConfigLocalRepository : IConfigLocalRepository
    {
        private readonly ValueDataFile valueDataFile;
        public ConfigLocalRepository()
        {
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
            valueDataFile = new(filePath);
        }
        public IConfig Load()
        {
            ValueData[] valueDatas = valueDataFile.Load();
            return ValueDataConverter.ToConfig(valueDatas);
        }

        public void Save(IConfig config)
        {
            ValueData[] valueDatas = ValueDataConverter.ToValueDatas(config).ToArray();
            valueDataFile.Save(valueDatas);
        }

        public void Save(string dirPath, IConfig config)
        {
            ValueData[] valueDatas = ValueDataConverter.ToValueDatas(config).ToArray();
            ValueDataFile file = new(dirPath);
            file.Save(valueDatas);
        }
    }
}
