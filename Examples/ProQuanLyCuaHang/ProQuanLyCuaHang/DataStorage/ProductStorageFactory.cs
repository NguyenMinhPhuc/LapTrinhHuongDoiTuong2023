using ProQuanLyCuaHang.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang.DataStorage
{
    internal class ProductStorageFactory : IProductStorageFactory
    {
        IFileType fileType;
        public IFileType FileType { get => fileType; set => fileType = value; }

        public void CreateStorage(EFileName fileName)
        {
            throw new NotImplementedException();
        }
    }
}
