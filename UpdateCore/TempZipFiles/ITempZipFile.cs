using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;

namespace UpdateCore.TempZipFiles
{
    public interface ITempZipFile
    {
        void Download(IConfig config);
        void Upload(IConfig config);
        void Unzip(IConfig config);
        void Delete(IConfig config);
    }
}
