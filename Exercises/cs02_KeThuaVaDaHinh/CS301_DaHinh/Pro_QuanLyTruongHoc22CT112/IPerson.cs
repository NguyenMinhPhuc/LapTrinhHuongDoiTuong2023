using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    public interface IPerson
    {
        //properties
        string MaSo { get; set; }
        string Ho { get; set; }
        string Ten { get; set; }
        DateTime NgaySinh { get; set; }
        string DiaChi { get; set; }
        bool GioiTinh { get; set; }
        string SoDienThoai { get; set; }
        void Nhap(int index);
        void Xuat();
    }
}