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
            switch (fileName)
            {
                case EFileName.INI:
                    fileType = new FileIINI();
                    break;
                case EFileName.TXT:
                    fileType = new FileTXT();
                    break;
                case EFileName.DAT:
                    fileType = new FileDAT();
                    break;
            }
        }
    }
}
