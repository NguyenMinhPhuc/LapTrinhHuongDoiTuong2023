using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac01
{
    internal class Employee
    {
        string id, name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Employee() { }
        public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //Thêm dữ liệu vào database
        public bool InsertEmplyeeIntoData(Employee employee)
        {
            Console.WriteLine("Them vao database");
        }

        //Làm báo cáo
        public void XuatBaoCao(Employee employee)
        {
            Console.WriteLine("Xuat bao bao");
        }
    }
}
