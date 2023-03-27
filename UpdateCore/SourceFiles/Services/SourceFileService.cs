using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.SourceFiles.Services
{
    internal class SourceFileService : ISourceFileService
    {
        public ISourceFile Load()
        {
            return new SourceFile();
        }
    }
}
