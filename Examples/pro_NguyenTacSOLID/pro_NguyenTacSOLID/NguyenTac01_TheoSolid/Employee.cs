using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac01_TheoSolid
{
    internal class Employee
    {
        string id, name;
        public Employee() { }
        public Employee(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        //
        public bool InsertEmployee(ref string err, Employee employee)
        {
            try
            {
                Console.WriteLine("Thuc hien insert");
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return false;
        }


    }
}
