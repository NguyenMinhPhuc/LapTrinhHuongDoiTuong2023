using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_22CT111
{
    //lop Entity _ DTO
    public class NhanVien : IComparable
    {
        //fields
        string maNV, tenNV, diaChi;
        DateTime ngaySinh;
        //properties
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        //Constructors
        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, string diaChi, DateTime ngaySinh)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;

        }

        public NhanVien(NhanVien nhanVien)
        {
            this.maNV = nhanVien.maNV;
            this.tenNV = nhanVien.tenNV;
            this.diaChi = nhanVien.diaChi;
            this.ngaySinh = nhanVien.ngaySinh;
        }

        //Method
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap MaNV: ");
            maNV = Console.ReadLine();

            Console.Write("Nhap TenNV: ");
            tenNV = Console.ReadLine();

            Console.Write("Nhap diaChi: ");
            diaChi = Console.ReadLine();

            Console.Write("Nhap NgaySinh: ");
            NgaySinh = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format($"Manv: {maNV} - TenNV: {tenNV} - NgaySinh {ngaySinh.ToShortDateString()} - Dia chi: {diaChi}");
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Manv: {maNV} - TenNV: {tenNV} - NgaySinh {ngaySinh.ToShortDateString()} - Dia chi: {diaChi}");
        }

        public int CompareTo(object? obj)
        {
            if (obj is NhanVien)
            {
                return this.tenNV.CompareTo((obj as NhanVien).tenNV);
            }
            return -1;
        }
    }
}
