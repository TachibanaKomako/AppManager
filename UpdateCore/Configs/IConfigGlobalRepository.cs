using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs
{
    public interface IConfigGlobalRepository
    {
        IConfig Load(AppId appId, IConfig localConfig);
        void Save(AppId appId,IConfig localConfig);
    }
}
