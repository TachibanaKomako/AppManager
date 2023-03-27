using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;

namespace UpdateCore.ExeFiles
{
    public interface IExeFile
    {
        void Kick(IConfig config);
    }
}
