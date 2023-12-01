using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class Employee : Person
    {
        double luongCB;

        public double LuongCB { get => luongCB; set => luongCB = value; }

        public Employee() : base() { }

        public Employee(double luongCB, string maEmployee, string tenEmployee, string diaChi, string soDienThoai) : base(maEmployee, tenEmployee, diaChi, soDienThoai)
        {
            this.luongCB = luongCB;

        }
    }
}
