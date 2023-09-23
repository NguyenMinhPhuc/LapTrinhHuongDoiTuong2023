using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    public class Person : IPerson
    {
        //Field
        private string maSo, ho, ten, diaChi, soDienThoai;
        bool gioiTinh;
        DateTime ngaySinh;
        //Properties
        public string MaSo { get => maSo; set => maSo = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => gioiTinh; set => gioiTinh = value; }
        //Method
        public void Nhap(int index)
        {
            Console.WriteLine($"Nhap Nguoi thu {index}");
            Console.Write("Ma so: ");
            maSo=Console.ReadLine();

            Console.Write("Ho: ");
            ho=Console.ReadLine();

            Console.Write("Ten: ");
            ten=Console.ReadLine();

            Console.Write("Gioi tinh (True/False): ");
            gioiTinh=Convert.ToBoolean(Console.ReadLine());

             Console.Write("Ngay sinh:(dd/mm/yyyy) ");
            ngaySinh=Convert.ToDateTime( Console.ReadLine());
            //Nhap dia chi gom
            Console.Write("Dia chi: ");
            diaChi=Console.ReadLine();
            //Nhap So dien thoai
            Console.Write("So dien thoai: ");
            SoDienThoai=Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"Ma so: {maSo}");
            Console.WriteLine($"Ho: {ho}");
            Console.WriteLine($"Ten: {ten}");
            Console.WriteLine($"Ngay sinh: {string.Format("{0:mm/dd/yyyy}",ngaySinh)}");
            Console.WriteLine("Gioi tinh: {0} ",gioiTinh?"Nam":"Nu");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"Dien thoai: {soDienThoai}");
        }
    }
}