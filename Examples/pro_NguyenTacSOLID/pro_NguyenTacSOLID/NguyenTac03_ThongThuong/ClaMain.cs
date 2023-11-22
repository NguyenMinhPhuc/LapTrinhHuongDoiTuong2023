using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac03_ThongThuong
{
    internal class ClaMain
    {

        List<INhanVien> nhanViens = new List<INhanVien>();
        public ClaMain()
        {
            INhanVien nhanvienthuongtruc = new NhanVienTrucThuoc();

            nhanViens.Add(nhanvienthuongtruc);
            INhanVien nhanvienhopdong = new NhanVienHopDong();
            nhanViens.Add(nhanvienhopdong);
            foreach (var item in nhanViens)
            {
                item.LayThongTinNhanVien();
            }
        }
    }
}
