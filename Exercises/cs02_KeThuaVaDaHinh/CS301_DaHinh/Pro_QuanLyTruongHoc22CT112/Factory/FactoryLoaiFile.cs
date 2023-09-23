
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pro_QuanLyTruongHoc22CT112
{
    internal class FactoryLoaiFile : IFactoryLoaiFile
    {
        ILoaiFile loaiFile;
        public ILoaiFile LoaiFile { get => loaiFile; set => loaiFile = value; }


        public void CreateLoaiFile(ELoaiFile loaiFile)
        {
            switch (loaiFile)
            {
                case ELoaiFile.TXT:
                    this.loaiFile = new FileTxt();
                    break;
                case ELoaiFile.INI:
                    this.loaiFile = new FileIni();
                    break;
                case ELoaiFile.BAT:
                    this.loaiFile = new FileBat();
                    break;
                default:
                    break;
            }
        }
    }
}
