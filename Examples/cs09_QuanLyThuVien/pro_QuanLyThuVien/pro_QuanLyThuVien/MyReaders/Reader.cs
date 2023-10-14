using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_QuanLyThuVien.MyReaders
{
    internal class Reader
    {
        int readerID;
        string name;
        string address;
        string phone;

        public int ReaderID { get => readerID; set => readerID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        public Reader()
        {
            this.readerID = 0;
            this.name = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
        }
        public Reader(int readerID, string name, string address, string phone)
        {
            this.readerID = readerID;
            this.name = name;
            this.address = address;
            this.phone = phone;

        }

        public void Input(int index)
        {
            Console.WriteLine($"\nNhap doc gia thu : {index}");
            Console.Write("Nhap maDG: ");
            readerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap Name: ");
            name = Console.ReadLine();

            Console.Write("Nhap Address: ");
            address = Console.ReadLine();

            Console.Write("Nhap Phone: ");
            phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format($"ReadeID: {readerID}\n Name: {name}\n Address: {address} \n Phone: {phone}");
        }

        public void Write(StreamWriter sw)
        {
            sw.WriteLine(string.Format("{readerID},{name},{address},{phone}"));
        }

        public Reader Read(string line)
        {
            Reader reader = null;
            if (!string.IsNullOrEmpty(line))
            {
                string[] strings = line.Split(new char[] { ',' });
                reader = new Reader()
                {
                    readerID = Convert.ToInt32(strings[0]),
                    name = strings[1],
                    address = strings[2],
                    phone = strings[3]
                };
            }
            return reader;
        }
    }
}
