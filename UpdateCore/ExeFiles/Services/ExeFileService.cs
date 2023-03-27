using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.ExeFiles.Services
{
    internal class ExeFileService : IExeFileService
    {
        public IExeFile Load()
        {
            return new ExeFile();
        }
    }
}
