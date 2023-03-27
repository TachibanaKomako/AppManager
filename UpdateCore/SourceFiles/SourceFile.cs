using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;

namespace UpdateCore.SourceFiles
{
    internal class SourceFile : ISourceFile
    {
        public void Zip(IConfig config)
        {
            string sourceDirPath = config.GetValue(ConfigKey.SourceDirPath);
            string tempFilePath = config.GetValue(ConfigKey.TempFilePath);
            if(File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
            ZipFile.CreateFromDirectory(sourceDirPath, tempFilePath);
        }
    }
}
