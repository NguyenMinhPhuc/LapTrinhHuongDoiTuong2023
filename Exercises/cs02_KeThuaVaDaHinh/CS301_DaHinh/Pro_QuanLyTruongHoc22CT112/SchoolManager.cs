using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    public class SchoolManager
    {
        //fiels
        List<Person> list;
        public SchoolManager()
        {
            list = new List<Person>();
        }

        public List<Person> List { get => list; set => list = value; }

        public void NhapDanhSach()
        {
            Person person;
            int index = 0;
            while (true)
            {
                Console.Write("Ban muon nhap (teacher: 'T'/Student 'S')");
                string option = string.Empty;
                option = Console.ReadLine();
                if (option == "T" || option == "t")
                {
                    person = new Teacher();
                }
                else if (option == "S" || option == "s")
                {
                    person = new Student();
                }
                else
                {
                    break;
                }
                person.Nhap(++index);
                list.Add(person);
            }
            Console.WriteLine("Nhap danh sach thanh cong");
        }
        public void XuatDanhSach()
        {
            foreach (Person person in list)
            {
                person.Xuat();
            }
        }
        public Person SearchByID(string maSo)
        {
            foreach (Person item in list)
            {
                if (item.MaSo == maSo)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Person> SearchByName(string ten)
        {
            List<Person> listSearch = new List<Person>();
            foreach (Person person in list)
            {
                if (person.Ten == ten)
                {
                    listSearch.Add(person);
                }
            }
            return listSearch;
        }

        public void DeleteByID(string maSo)
        {
            foreach (Person person in list)
            {
                if (person.MaSo.Equals(maSo))
                {
                    list.Remove(person);
                    return;
                }
            }
        }

        public void Update(string maSo)
        {
            foreach (Person person in list)
            {
                if (person.MaSo.Equals(maSo))
                {
                    Console.Write("Ban muon sua thong tin nao?");
                    Console.WriteLine("1. Sua ho");
                    Console.WriteLine("2. Sua ten");
                    Console.WriteLine("3. Sua ngay sinh");
                    Console.WriteLine("4. Sua dia chi");
                    Console.Write("Chon: ");
                    int chon = Convert.ToInt32(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            Console.Write("Nhap lai ho:  ");
                            person.Ho = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Nhap lai ten:  ");
                            person.Ten = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Nhap lai ngay sinh:  ");
                            person.NgaySinh = Convert.ToDateTime(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("Nhap lai Dia chi:  ");
                            person.DiaChi = Console.ReadLine();
                            break;

                    }
                    Console.WriteLine("Thong tin vua duoc chinh sua");
                    person.Xuat();
                }
            }
        }
    }
}