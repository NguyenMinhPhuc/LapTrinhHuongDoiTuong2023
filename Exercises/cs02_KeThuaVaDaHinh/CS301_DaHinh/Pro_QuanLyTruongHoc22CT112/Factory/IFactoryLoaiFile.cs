
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    internal interface IFactoryLoaiFile
    {
        ILoaiFile LoaiFile { get; set; }

        void CreateLoaiFile(ELoaiFile loaiFile);
    }
}
