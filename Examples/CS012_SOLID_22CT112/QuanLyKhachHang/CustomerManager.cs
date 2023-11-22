using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    internal class CustomerManager
    {
        public CustomerManager() { }
        public void AddCustomer()
        {
            Console.WriteLine("Them khach hang");
        }

        public void UpdateCustomer()
        {
            Console.WriteLine("Sua khach hang");
        }


        public void DeleteCustomer()
        {
            Console.WriteLine("Delete khach hang");
        }

        public void GetCustomer()
        {
            Console.WriteLine("Get khach hang");
        }

        public void SendMailCustomer()
        {
            Console.WriteLine("SendMail khach hang");
        }
    }
}
