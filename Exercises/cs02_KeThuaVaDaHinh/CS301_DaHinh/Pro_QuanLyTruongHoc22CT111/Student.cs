using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111
{
    internal class Student : Person
    {
        //field
        string lop, nganh;
        double diemTB, diemRL;
        //properties
        public string Lop { get => lop; set => lop = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public double DiemRL { get => diemRL; set => diemRL = value; }

        //Constructor
        public Student() : base()
        {

        }
        //Method
        public override void Nhap(int index)
        {
            base.Nhap(index);
            Console.WriteLine("Nhap TT Sinh vien: ");
            Console.Write("Lop: ");
            lop = Console.ReadLine();

            Console.Write("Nganh: ");
            nganh = Console.ReadLine();

            Console.Write("Diem TB: ");
            diemTB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Diem RL: ");
            diemRL = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat(int index)
        {
            base.Xuat(index);
            Console.WriteLine($"Lop {lop} - Nganh: {nganh}");
            Console.WriteLine($"Diem TB: {diemTB}");
            Console.WriteLine($"Diem TB: {diemRL}");
        }

        public string XepLoai()
        {
            string xepLoai = string.Empty;
            if (diemTB >= 9)
            {
                xepLoai = "xuat sac";
            }
            else if (diemTB >= 8)
            {
                xepLoai = "Gioi";
            }
            else if (diemTB >= 7)
            {
                xepLoai = "Kha";
            }
            else if (diemTB >= 6)
            {
                xepLoai = "TB Kha";
            }
            else if (diemTB >= 5)
            {
                xepLoai = "Trung binh";
            }
            else
            {
                xepLoai = "Yeu";
            }
            return xepLoai;
        }

        public override string ToString()
        {
            string result = "S,";
            result += base.ToString();
            result += string.Format($",{lop},{nganh},{diemTB},{diemRL}");
            return result;
        }
    }
}
