using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_Interface
{
    internal class SubStudent : IExStudent, IComparable, ICloneable
    {
        public string ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Class { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            IStudents student;
            if (obj is IStudents)
            {
                student = (IStudents)obj;
                student = obj as IStudents;
            }

        }

        public double GetMark(string id)
        {
            throw new NotImplementedException();
        }

        public void Input(int index)
        {
            throw new NotImplementedException();
        }

        public string Output()
        {
            throw new NotImplementedException();
        }
    }
}
