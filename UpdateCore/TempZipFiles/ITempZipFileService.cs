using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.TempZipFiles
{
    public interface ITempZipFileService
    {
        ITempZipFile Load();
    }
}
