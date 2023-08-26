using System.Reflection.Emit;
using System.Data;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    /// <summary>
    /// Xây dụng lớp sinh viên để lưu trữ thông tin của sinh viên, và các hành vi của sinh viên (lấy, thêm, sửa, xóa)
    /// ghi chú: Sinh viên tự xác định các thông tin của sinh viên gồm: Tên và kiểu dữ liệu
    /// </summary>
    public class SinhVien
    {
        #region field - biến thành viên
        //MSSV string
        //Họ và tên string
        //Giới tính bool
        //Ngày sinh datetime
        //Điện thoại string
        //Địa chỉ string
        //CCCD string
        //Lớp học string
        string mSSV;
        string hoVaTen;
        bool gioiTinh;//1 nam; 0 nu
        DateTime ngaySinh;
        string dienThoai;
        string diaChi;
        string cCCD;
        string lopHoc;
        #endregion

        #region Properties - Thuộc tính
        public string MSSV { get => mSSV; set => mSSV = value; }
        public global::System.String HoVaTen { get => hoVaTen; set => hoVaTen = value; }

        public global::System.Boolean GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string LopHoc { get => lopHoc; set => lopHoc = value; }

        #endregion

        #region Constructors - Hàm tạo
        public SinhVien()
        {

        }

        public SinhVien(string mSSV, string hoVaTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string lopHoc)
        {
            this.mSSV = mSSV;
            this.hoVaTen = hoVaTen;
            this.ciaChi = diaChi;
            this.cCCD = cCCD; ;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.dienThoai = dienThoai;
            this.lopHoc = lopHoc;
        }
        public SinhVien(SinhVien sinhVien)
        {
            this.mSSV = sinhVien.mSSV;
            this.hoVaTen = sinhVien.hoVaTen;
            this.ciaChi = sinhVien.diaChi;
            this.cCCD = sinhVien.cCCD; ;
            this.ngaySinh = sinhVien.ngaySinh;
            this.gioiTinh = sinhVien.gioiTinh;
            this.dienThoai = sinhVien.dienThoai;
            this.lopHoc = sinhVien.lopHoc;
        }

        #endregion

        #region  Method - phương thức
        //1. Lay
        public SinhVien GetSinhVien()
        {
            SinhVien sinhVien = null;
            sinhVien = new SinhVien();
            return sinhVien;
        }
        public void DisplaySinhVien(SinhVien sinhVien)
        {
            Console.WriteLine($"MSSV: {mSSV}\n HovaTen: {hoVaTen}")
        }
        //2. Them
        public void AddSinhVien(SinhVien sinhVien)
        {
            Cls_Main.Path;
        }
        //3. Sua
        public void UpdateSinhVien(string mSSV)
        { }
        //4. Xoa
        public void DeleteSinhVien(string mSSV)
        { }
        //1. Số lượng tham số khác nhau
        //2. kiểu dữ liệu của tham số khác nhau
        //3. Thứ tự tham số khác nhau
        public void NhapSinhVien(int a,string b)
        {
            mSSV = Console.ReadLine();
            hoVaTen=Console.WriteLine()"Hello World!");
        }

        public void NhapSinhVien(int b,string a)
        {

        }
        #endregion
    }
}