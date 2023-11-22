using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_Interface
{
    internal interface ICompressible
    {
        void Compress();
        void Decompress();

    }

    internal interface ILoggedCompressible : ICompressible
    {
        void LogSavedBytes();
    }
}
