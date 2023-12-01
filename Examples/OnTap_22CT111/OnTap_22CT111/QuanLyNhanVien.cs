using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_22CT111
{
    public class QuanLyNhanVien
    {
        List<NhanVien> nhanViens;
        public QuanLyNhanVien()
        {
            nhanViens = new List<NhanVien>();
        }
        //Them
        public void ThemNhanVien()
        {
            NhanVien nhanVien;
            int count = 0;
            while (true)
            {
                string chon = string.Empty;
                nhanVien = new NVHanhChanh();
                nhanVien.NhapThongTin();
                nhanViens.Add(nhanVien);
                count++;
                Console.Write("Nhap tiep khong (Y/N)");
                chon = Console.ReadLine();
                if (chon.ToLower().Equals("n"))
                {
                    break;
                }
            }
            Console.WriteLine($"da co {count} duoc nhap");
        }
        //Sua
        //Xoa
        //Tim kiem
        public NhanVien TimKiemNhanVienTheoMa(string maNV)
        {
            NhanVien nhanVienresult = null;
            foreach (NhanVien nhanVien in nhanViens)
            {
                if (nhanVien.MaNV.Equals(maNV))
                {
                    nhanVienresult = nhanVien;
                }
            }
            return nhanVienresult;
        }

        public List<NhanVien> TimKiemNhanVienTheoTen(string tenNV)
        {
            List<NhanVien> nhanVienresult = null;
            foreach (NhanVien nhanVien in nhanViens)
            {
                if (nhanVien.TenNV.Equals(tenNV))
                {
                    nhanVienresult.Add(nhanVien);
                }
            }
            return nhanVienresult;
        }
        //sap xep
        public void SapXep(bool ASC)
        {
            if (ASC)
            {
                nhanViens.Sort();
            }
            else
            {
                nhanViens.Sort();
                nhanViens.Reverse();
            }
        }

        public void PrintNhanVien()
        {
            foreach (NhanVien item in nhanViens)
            {
                item.XuatThongTin();
            }
        }
        public void PrintNhanVien(List<NhanVien> nhanViens)
        {
            foreach (NhanVien item in nhanViens)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
