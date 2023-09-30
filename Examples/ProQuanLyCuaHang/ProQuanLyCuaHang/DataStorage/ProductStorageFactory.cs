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
        public IFileType fileType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreateStorage(EFileName fileName)
        {
            throw new NotImplementedException();
        }
    }
}
