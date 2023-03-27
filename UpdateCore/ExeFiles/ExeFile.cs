using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;

namespace UpdateCore.ExeFiles
{
    internal class ExeFile : IExeFile
    {
        public void Kick(IConfig config)
        {
            string kickFilePath = $"{config.GetValue(ConfigKey.KickDirPath)}\\{config.GetValue(ConfigKey.KickFileName)}";
            ProcessStartInfo startInfo = new()
            {
                FileName = kickFilePath,
                UseShellExecute = true
            };
            _ = Process.Start(startInfo);
        }
    }
}
