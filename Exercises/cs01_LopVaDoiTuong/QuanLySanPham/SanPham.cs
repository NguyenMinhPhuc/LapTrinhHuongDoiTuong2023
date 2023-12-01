using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLySanPham
{
    public class SanPham
    {
        //masp,ten, soluong, dongia
        //field
        string maSanPham, tenSanPham;
        int soLuong;
        double donGia;
        //Nhan Ctrl +Shift + R chon tao properties thich hop
        //Properties
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        //constructor - ham tao
        //Ham tao mac dinh
        public SanPham()
        {
            this.maSanPham = string.Empty;
            this.tenSanPham = string.Empty;
            this.soLuong = 0;
            this.donGia = 0;
        }
        //Ham tao co tham so
        public SanPham(string maSanPham,string tenSanPham,int soLuong,double donGia)
        {
            this.maSanPham=maSanPham;
            this.tenSanPham=tenSanPham;
            this.soLuong=soLuong;
            this.donGia=donGia;
        }
        // ham tao sao chep
        public SanPham(SanPham sanPham)
        {
            this.maSanPham=sanPham.maSanPham;
            this.tenSanPham=sanPham.tenSanPham;
            this.soLuong=sanPham.soLuong;
            this.donGia=sanPham.donGia;
        }
        //method
        // Nhap san pham
        public void NhapSanPham()
        {
            this.maSanPham=Console.ReadLine();
            this.tenSanPham=Console.ReadLine();
            this.soLuong=Convert.ToInt32(Console.ReadLine());
            this.donGia=Convert.ToDouble(Console.ReadLine());
        }

        public SanPham NhapSanPham(bool traVe){
            SanPham sanPham=new SanPham();
            sanPham.maSanPham=Console.ReadLine();
            sanPham.tenSanPham=Console.ReadLine();
            sanPham.soLuong=Convert.ToInt32(Console.ReadLine());
            sanPham.donGia=Convert.ToDouble(Console.ReadLine());
            return sanPham;
        }
        //XuatThong tin san pham
        public void XuatThongTinSanPham()
        {
            Console.WriteLine($"Ma SP: {maSanPham} \nten SP: {tenSanPham}\nSo luong: {soLuong}\nDonGia= {string.Format("{0:#,###}",donGia)} \nThanh tien: {string.Format("{0:#,###}",TinhThanhTien())}");
        }

        // in thong tin san pham

        //Phuong thuc tinh tien
        public double TinhThanhTien(){
            return soLuong*donGia;
        }

    }
}