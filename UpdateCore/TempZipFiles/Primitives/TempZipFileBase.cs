using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateCore.Configs;

namespace UpdateCore.TempZipFiles.Primitives
{
    internal abstract class TempZipFileBase : ITempZipFile
    {
        public void Delete(IConfig config)
        {
            if(File.Exists(GetTempFilePath(config)))
            {
                File.Delete(GetTempFilePath(config));
            }
        }

        public void Download(IConfig config)
        {
            //古いデータは削除しておく
            Delete();
            //ダウンロード
            Download(GetTempFilePath(config), config);
        }

        protected abstract void Download(string destinationFilePath,IConfig config);

        public void Unzip(IConfig config)
        {
            //解凍先はキックするディレクトリを取得する
            string dirPath = config.GetValue(ConfigKey.KickDirPath);
            //解凍する
            ZipFile.ExtractToDirectory(GetTempFilePath(config), dirPath);
        }

        public void Upload(IConfig config)
        {
            Upload(GetTempFilePath(config), config);
        }
        private static string GetTempFilePath(IConfig config)
        {
            return config.GetValue(ConfigKey.TempFilePath);
        }
        protected abstract void Upload(string sourceFilePath, IConfig config);
    }
}
