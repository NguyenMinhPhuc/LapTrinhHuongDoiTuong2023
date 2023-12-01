using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang.DataStorage
{
    internal class FileTXT : IFileType
    {
        public List<Product> Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(string path, List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
