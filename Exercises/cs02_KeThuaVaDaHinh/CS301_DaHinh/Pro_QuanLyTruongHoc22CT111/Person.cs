using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111
{
    public class Person
    {
        //4
        //field Person(MaSo, Ho, Ten,NgaySinh, GioiTinh,DiaChi,SoDienThoai)
        string maSo, ho, ten, diaChi, soDienThoai;
        DateTime ngaySinh;
        bool gioiTinh;
        //properties
        public string MaSo { get => maSo; set => maSo = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        //Constructor
        public Person() { }
        //Method
        public virtual void Nhap(int index)
        {
            Console.WriteLine($"Nhap nguoi thu {index}:");
            Console.Write("Ma so: ");
            maSo = Console.ReadLine();

            Console.Write("Ho: ");
            ho = Console.ReadLine();

            Console.Write("Ten: ");
            ten = Console.ReadLine();

            Console.Write("Ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Gioi tinh: ");
            gioiTinh = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();

            Console.Write("So dien thoai: ");
            soDienThoai = Console.ReadLine();
        }
        /// <summary>
        /// Phuong thuc xuat cua person
        /// </summary>
        /// <param name="index">thu tu</param>
        public virtual void Xuat(int index)
        {
            Console.WriteLine($"Nguoi thu {index}");
            Console.WriteLine($"Ma so: {maSo}");
            Console.WriteLine($"Ho va ten: {ho} {ten}");
            Console.WriteLine($"Ngay sinh:{ngaySinh}");
            Console.WriteLine($"Gioi tinh {0}", gioiTinh ? "Nam" : "Nu");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"Dien thoai: {soDienThoai}");
            Console.WriteLine("---------------------------");
        }
    }
}