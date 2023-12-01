using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class Student : Person
    {
        double diem;
        int trangThai;
        public Student() : base() { }

        public Student(double diem, string maEmployee, string tenEmployee, string diaChi, string soDienThoai) : base(maEmployee, tenEmployee, diaChi, soDienThoai)
        {
            this.diem = diem;

        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap diem: ");
            diem = Convert.ToDouble(diem);
        }
        public void XetTrangThai(TrangThai trangThai)
        {
            this.trangThai = (int)trangThai;
        }
        public double Diem { get => diem; set => diem = value; }
    }
}
