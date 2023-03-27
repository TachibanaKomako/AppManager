using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs
{
    public interface IConfigLocalRepository
    {
        IConfig Load();
        void Save(IConfig config);
        void Save(string dirPath, IConfig config);
    }
}
