using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class QuanLyNguoi
    {
        List<Person> persons;
        public QuanLyNguoi()
        {
            Persons = new List<Person>();
        }
        //phuong thuc
        public void XetTrangThai()
        {
            Student student = new Student();
            student.XetTrangThai(TrangThai.TOTNGHIEP);
        }

        public List<Person> Persons { get => persons; set => persons = value; }
    }
}
