using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    public class Teacher : Person
    {
        string hocHam, hocVi;
        double soTietDay;


        public string HocHam { get => hocHam; set => hocHam = value; }
        public string HocVi { get => hocVi; set => hocVi = value; }
        public double SoTietDay { get => soTietDay; set => soTietDay = value; }

        public Teacher() : base()
        {
            this.soTietDay = 0;
            this.HocVi = "ThS";
            this.hocHam = string.Empty;
        }

        public override void Nhap(int index)
        {
            base.Nhap(index);
            Console.WriteLine("Nhap TT Giao vien:");
            Console.Write("Hoc vi: ");
            hocVi = Console.ReadLine();
            Console.Write("Hoc ham: ");
            hocHam = Console.ReadLine();
            Console.Write("So tiet giang: ");
            soTietDay = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Hoc ham: {hocHam}");
            Console.WriteLine($"Hoc vi: {hocVi}");
            Console.WriteLine($"So tiet day: {string.Format("{0:#,###}", soTietDay)}");
        }
        public double TinhTienDay()
        {
            return soTietDay * 90000;
        }
        public override string ToString()
        {
            string result = "T," + base.ToString();
            result += string.Format($",{hocHam},{hocVi},{soTietDay}");
            return result;
        }
    }
}