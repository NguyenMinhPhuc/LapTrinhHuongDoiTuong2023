using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_Interface
{
    internal class MainStudent : IStudents
    {
        public string ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


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
