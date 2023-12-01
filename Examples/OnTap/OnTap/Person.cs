using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class Person
    {
        string maPerson, tenPerson, diaChi, soDienThoai;

        public string MaPerson { get => maPerson; set => maPerson = value; }
        public string TenPerson { get => tenPerson; set => tenPerson = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public Person() { }
        public Person(string maPerson, string tenPerson, string diaChi, string soDienThoai)
        {
            MaPerson = maPerson;
            TenPerson = tenPerson;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap Ma:");
            maPerson = Console.ReadLine()!;
            Console.Write("Nhap Ten:");
            tenPerson = Console.ReadLine()!;
            Console.Write("Nhap dia chi:");
            diaChi = Console.ReadLine()!;
            Console.Write("Nhap Sdt:");
            soDienThoai = Console.ReadLine()!;
        }
    }
}
