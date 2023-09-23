using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111
{
    internal class Teacher : Person
    {
        //field
        string hocHam, hocVi;
        double soTietDay;
        //properties
        public string HocHam { get => hocHam; set => hocHam = value; }
        public string HocVi { get => hocVi; set => hocVi = value; }
        public double SoTietDay { get => soTietDay; set => soTietDay = value; }
        //constructor
        public Teacher() : base()
        {
            hocHam = string.Empty;
            hocVi = "ThS";
            soTietDay = 0;
        }
        //Method
        public override void Nhap(int index)
        {
            base.Nhap(index);
            Console.WriteLine("Nhap TT Giao vien: ");
            Console.Write("Hoc ham: ");
            hocHam = Console.ReadLine();

            Console.Write("Hoc vi: ");
            hocVi = Console.ReadLine();

            Console.Write("So tiet day: ");
            soTietDay = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat(int index)
        {
            base.Xuat(index);
            Console.WriteLine($"Hoc ham: {hocHam}");
            Console.WriteLine($"Hoc vi: {hocVi}");
            Console.WriteLine($"So tiet day: {soTietDay}");
        }

        public double TinhTienGiang()
        {
            return soTietDay * 90000;
        }

        public override string ToString()
        {
            string result = "T,";
            result += base.ToString();
            result += string.Format($",{hocHam},{HocVi},{SoTietDay}");
            return result;
        }
    }
}
