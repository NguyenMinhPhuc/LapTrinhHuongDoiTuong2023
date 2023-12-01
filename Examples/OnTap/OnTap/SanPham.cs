using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class SanPham : IComparable
    {
        //Entity
        //4 thanh phan
        //field
        string maSP, tenSP, dvt;
        long donGia;
        //properties
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        //Contructor
        public SanPham() { }
        public SanPham(string maSP, string tenSP, string dvt, long donGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.dvt = dvt;
            this.donGia = donGia;
        }
        public SanPham(SanPham sanPham)
        {
            this.maSP = sanPham.maSP;
            this.tenSP = sanPham.tenSP;
            this.dvt = sanPham.dvt;
            this.donGia = sanPham.donGia;
        }
        //Method
        public void NhapMotSanPham()
        {
            Console.Write("Nhap MaSP: ");
            maSP = Console.ReadLine();
            Console.Write("Nhap TenSP: ");
            tenSP = Console.ReadLine();
            Console.Write("Nhap dvt: ");
            dvt = Console.ReadLine();
            Console.Write("Nhap Don Gia: ");
            donGia = Convert.ToInt64(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format($"MaSP: {maSP} - TenSP: {tenSP} - Dvt: {dvt} - Don gia: {donGia}");
        }

        public void XuatMotSanPham()
        {
            Console.WriteLine($"MaSP: {maSP} - TenSP: {tenSP} - Dvt: {dvt} - Don gia: {donGia}");
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return -1;
            else
            {
                if (obj is SanPham)
                {
                    return this.maSP.CompareTo(((SanPham)obj).maSP);
                }
            }
            return -1;
        }
    }
}
