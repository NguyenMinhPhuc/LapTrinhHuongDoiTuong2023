using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang.DataStorage
{
    internal interface IFileType
    {
        List<Product> Read(string path);
        void Write(string path, List<Product> products);
    }
}
