using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_Interface
{
    internal class Student : IStudents, ICloneable, IComparable, IExStudent
    {
        #region field
        string id, name, address;
        DateTime birthDay;
        #endregion

        #region Properties
        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Class { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region constructor
        public Student()
        {
            this.id = string.Empty;
            this.name = string.Empty;
            this.address = string.Empty;
            this.birthDay = new DateTime(1900, 1, 1);
        }

        public Student(string id, string name, string address, DateTime birthDay)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.birthDay = birthDay;

        }
        public Student(Student student)
        {
            this.id = student.id;
            this.name = student.name;
            this.address = student.address;
            this.birthDay = student.birthDay;
        }


        #endregion
        #region method
        protected virtual void Input(int index)
        {
            Console.WriteLine("Input");
        }

        public virtual string Output()
        {
            Console.WriteLine("output");
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            //-1,0,1
            return this.id.CompareTo(((Student)obj).id);
        }

        void IStudents.Input(int index)
        {
            throw new NotImplementedException();
        }

        public double GetMark(string id)
        {
            throw new NotImplementedException();
        }
        //kieu tham so
        //thu tu tham so
        //so luong tham so
        public void NhapThongTin()
        {

        }

        public string NhapThongTin(int id)
        {
            return string.Empty;
        }
        #endregion
    }
}
