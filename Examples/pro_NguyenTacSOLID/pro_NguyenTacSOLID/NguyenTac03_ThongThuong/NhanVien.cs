using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac03_ThongThuong
{
    internal interface INhanVien
    {
        public string ID { get; set; }
        public string Name { get; set; }



        public void LayThongTinNhanVien();

        public void LayThongTinDuAn();
    }
}
