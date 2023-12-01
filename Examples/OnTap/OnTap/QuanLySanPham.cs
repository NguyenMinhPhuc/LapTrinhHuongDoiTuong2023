using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class QuanLySanPham
    {
        List<SanPham> sanPhamList;
        public QuanLySanPham()
        {
            sanPhamList = new List<SanPham>();
        }
        //Them
        public void ThemSanPham()
        {
            SanPham sanPham = null;
            int count = 0;
            while (true)
            {
                string chon = string.Empty;
                sanPham = new SanPham();
                sanPham.NhapMotSanPham();
                sanPhamList.Add(sanPham);
                count++;
                Console.WriteLine("Co nhap tiep khong (Y/N)");
                chon = Console.ReadLine();
                if (chon.ToLower().Equals("n"))
                    break;
            }
            Console.WriteLine($"So luong sp da nhap: {count}");
        }
        //Sua
        //tim --> sua
        //Xoa
        //tim --> xoa
        //Tim kiem
        //nhieu gia tri
        //mot gia tri
        public SanPham TimSanPhamTheoMaSP(string maSP)
        {
            SanPham sanPhamReult = null;
            foreach (SanPham sp in sanPhamList)
            {
                if (sp.MaSP.Equals(maSP))
                {
                    sanPhamReult = sp;
                }
            }
            return sanPhamReult;
        }

        public List<SanPham> TimSanPhamTheoTenSP(string tenSP)
        {
            List<SanPham> sanPhamReult = new List<SanPham>();
            foreach (SanPham sp in sanPhamList)
            {
                if (sp.TenSP.Equals(tenSP))
                {
                    sanPhamReult.Add(sp);
                }
            }
            return sanPhamReult;
        }
        //sap xep
        public void SapXep(bool ASC)
        {
            if (ASC)
            {
                sanPhamList.Sort();
            }
            else
            {
                sanPhamList.Sort();
                sanPhamList.Reverse();
            }
        }
    }
}
