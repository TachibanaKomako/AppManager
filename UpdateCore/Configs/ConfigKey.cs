using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs
{
    public enum ConfigKey
    {
        /// <summary>
        /// グローバルの種類
        /// WEB?NAS?Database?
        /// </summary>
        GlobalType = 1,
        /// <summary>
        /// Kickするファイル名
        /// </summary>
        KickFileName = 2,
        /// <summary>
        /// Kickするdllを含む全てのファイルの格納場所
        /// </summary>
        KickDirPath = 3,
        /// <summary>
        /// ソースファイル
        /// </summary>
        SourceDirPath = 5,
        AppName = 6,
        VersionName = 7,
        VersionNo = 8,
        AppId = 9,
        TempFilePath = 10,

        WEBUrlPath = 101,
        
        NASDirPath = 201,

        DBConnect = 301,
        DBDatabaseName = 302,
        DBConfigTable = 303,
        DBFileDataTable = 304,
        DBAdminUserName = 305,
        DBAdminPassword = 306,
        DBReadonlyUserName = 307,
        DBReadonlyPassword = 308

    }
}
