

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class QLSanPham
    {
        //field
        List<SanPham> sanPhams;

        public List<SanPham> SanPhams { get => sanPhams; set => sanPhams = value; }

        //Properties

        //Construtor
        public QLSanPham()
    {
        this.sanPhams = new List<SanPham>();
    }
    //them sp
    public void AddSanPham()
    {
        SanPham sanPham = new SanPham();
        sanPham.NhapSanPham();
        sanPhams.Add(sanPham);
    }
    public void AddSanPham(SanPham sanPham)
    {
        sanPhams.Add(sanPham);
    }
    // tim kiem san pham
    public SanPham SearchSanpham(string maSanPham)
    {
        foreach (var sp in sanPhams)
        {
            if (sp.MaSanPham == maSanPham)
                return sp;
        }
        return null;
    }
    //Tim kiem san pham theo don gia
    public List<SanPham> SearchSanPhamTheoGia(ref int count, double donGia)
    {
        List<SanPham> sanPhamsSearch = new List<SanPham>();
        count = 0;
        foreach (var sp in sanPhams)
        {
            if (sp.DonGia == donGia)
            {
                sanPhamsSearch.Add(sp);
                count++;
            }
        }
        return sanPhamsSearch;
    }
    //in danh sachs
    public void PrintSanPham()
    {
        foreach (var sp in sanPhams)
        {
            sp.XuatThongTinSanPham();
        }
    }
    // sua thong tin san pham
    public bool UpdateSanpham(string maSanPham)
    {
        foreach (var sp in sanPhams)
        {
            if (sp.MaSanPham == maSanPham)
            {
                sp.TenSanPham=Console.ReadLine();
                sp.SoLuong=Convert.ToInt32(Console.ReadLine());
                sp.DonGia=Convert.ToDouble(Console.ReadLine());
                return true;
            }
        }
        return false;
    }
    // xoa san pham

}
}