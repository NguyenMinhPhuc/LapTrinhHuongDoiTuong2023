using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_Interface
{
    internal interface IStudents
    {
        //properties
        string ID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        DateTime BirthDay { get; set; }


        //method
        void Input(int index);
        string Output();


    }
}
