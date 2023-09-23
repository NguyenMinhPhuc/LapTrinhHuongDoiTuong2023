using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111
{
    internal class PersonManager
    {
        //field
        List<Person> list;
        //properties
        public List<Person> List { get => list; set => list = value; }
        //Constructor
        public PersonManager()
        {
            list = new List<Person>();
        }
        //Method
        public void NhapDanhSach()
        {
            int index = 0;
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Chon Loai: (Teacher:'T'/Student 'S':");
                string chon = Console.ReadLine();

                if (chon.ToLower().Equals("t"))
                {
                    person = new Teacher();
                }
                else if (chon.ToLower().Equals("s"))
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
            Console.WriteLine("Hoan tat qua trinh nhap");
        }

        public void XuatDanhSach()
        {
            int index = 0;
            foreach (Person person in list)
            {
                person.Xuat(++index);
            }
        }
        //Tim kiem tho id
        public Person SearchByID(string maSo)
        {
            foreach (Person person in list)
            {
                if (person.MaSo.Equals(maSo))
                {
                    return person;
                }
            }
            return null;
        }
        //tim kiem theo ten
        public List<Person> SearchByName(string ten)
        {
            List<Person> listSearch = new List<Person>();
            foreach (Person person in list)
            {
                if (person.Ten.Equals(ten))
                {
                    listSearch.Add(person);
                }
            }
            return listSearch;
        }
        //sua

        //xoa
        //Remove (theo doi tuong)
        //RemoveAt (theo vi tri)


    }
}
