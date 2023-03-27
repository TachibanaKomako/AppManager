using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;
using UpdateCore.TempZipFiles.Primitives;

namespace UpdateCore.TempZipFiles.Concrete
{
    internal class NASTempZipFile : TempZipFileBase
    {
        protected override void Download(string destinationFilePath, IConfig config)
        {
            string sourceFilePath = GetNASFilePath(config);
            File.Copy(sourceFilePath, destinationFilePath, true);
        }

        protected override void Upload(string sourceFilePath, IConfig config)
        {
            string destinationFilePath = GetNASFilePath(config);
            File.Copy(sourceFilePath, destinationFilePath, true);
        }

        private static string GetNASFilePath(IConfig config)
        {
            return $"{config.GetValue(ConfigKey.NASDirPath)}\\{config.GetAppId().Id:0000}";
        }
    }
}
