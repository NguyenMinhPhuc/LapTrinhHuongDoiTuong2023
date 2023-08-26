using System.Runtime.CompilerServices;
using System;

namespace cs01_ClassAndObject
{
    public  class SinhVien
    {
        //field bien
        public static string maSinhVien=string.Empty;
        string hoVaTen="";
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi, soDienThoai;
        private string lopHoc;

        //Phuong thuc truy cap
        public string GetMaSinhVien()
        {
            return maSinhVien;
        }

        public void SetMaSinhVien(string maSinhVien)
        {
            this.maSinhVien = maSinhVien;
        }

        //Viet theo thuoc tinh - Properties

        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        //prop
        public string HoVaTen { get { return hoVaTen; } set { hoVaTen = value; } }

        //propfull

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        //Ctrl+Shift+R
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }


        //3. Constructor - Ham tao
        //3.1. Hàm tạo mặc định  - hàm tạo không tham số
        public SinhVien()
        {

        }
        //3.2. Hàm tạo có tham số
        public SinhVien(string maSinhVien, string hoVaTen, DateTime ngaySinh)
        {
            this.maSinhVien = maSinhVien;
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
        }

        public SinhVien(string maSinhVien, string hoVaTen)
        {
            this.maSinhVien = maSinhVien;
            this.hoVaTen = hoVaTen;
        }
        //3.3. Hàm tạo sao chép

        public SinhVien(SinhVien sinhVien)
        {
            this.maSinhVien=sinhVien.MaSinhVien;
            this.hoVaTen=sinhVien.HoVaTen;;
            this.ngaySinh=sinhVien.NgaySinh;
            this.diaChi=sinhVien.DiaChi;
            this.gioiTinh=sinhVien.GioiTinh;
        }


        //4. method -- phuongw thuc

        //4.1 khong co kieu tra ve (void)
        public void HienThiThongTinSinhVien()
        {
            Console.WriteLine($" MSSV: {maSinhVien}\n Ten Sinh Vien: {hoVaTen}");
        }
        //4.2/ co kieu tra ve (return)
        public int TinhTuoiSinhVien()
        {
            return DateTime.Now.Year - ngaySinh.Year;
        }
    }
}
