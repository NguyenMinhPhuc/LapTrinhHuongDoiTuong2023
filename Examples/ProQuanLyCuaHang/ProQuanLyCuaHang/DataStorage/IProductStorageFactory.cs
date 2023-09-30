using Microsoft.VisualBasic.FileIO;
using ProQuanLyCuaHang.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang.DataStorage
{
    internal interface IProductStorageFactory
    {
        IFileType fileType { get; set; }
        void CreateStorage(EFileName fileName);
    }
}
