using Pro_QuanLyTruongHoc22CT111.Pros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111.Factory
{
    internal class MyFactory
    {
        IFileType fileType;

        internal IFileType FileType { get => fileType; set => fileType = value; }

        public void CreateFileType(EnumLoaiFile loaiFile)
        {
            switch (loaiFile)
            {
                case EnumLoaiFile.TXT:
                    fileType = new FileTxt();
                    break;
                case EnumLoaiFile.INI:
                    fileType = new FileIni();
                    break;
                case EnumLoaiFile.DAT:
                    fileType = new FileTxt();
                    break;

            }
        }
    }
}
