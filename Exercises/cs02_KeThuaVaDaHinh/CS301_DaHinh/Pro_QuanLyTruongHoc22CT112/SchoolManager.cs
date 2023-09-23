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
                else  if (option == "S" || option == "s")
                {
                    person = new Student();
                }else{
                    break;
                }
                person.Nhap(++index)
                list.Add(person);
            }
            Console.Write("Nhap danh sach thanh cong");
        }
    }
}