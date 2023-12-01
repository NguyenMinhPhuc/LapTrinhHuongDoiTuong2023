using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_22CT111
{
    public class NVHanhChanh : NhanVien
    {
        int luongCB;

        public int LuongCB { get => luongCB; set => luongCB = value; }

        public NVHanhChanh() : base() { }
        public NVHanhChanh(int luongCB) : base()
        {
            LuongCB = luongCB;

        }
        public NVHanhChanh(int luongCB, string maNV, string tenNV, DateTime ngaySinh, string diaChi) : base(maNV, tenNV, diaChi, ngaySinh)
        {
            LuongCB = luongCB;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("nhap lcb: ");
            luongCB = Convert.ToInt32(Console.ReadLine());
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Luong cb {luongCB}");
        }

        public override string ToString()
        {
            return string.Format("{0} - Luong cb {1}", base.ToString(), luongCB);
        }

    }
}