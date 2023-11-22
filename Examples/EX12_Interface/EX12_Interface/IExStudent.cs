using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_Interface
{
    internal interface IExStudent : IStudents
    {
        string Class { get; set; }
        double GetMark(string id);
    }
}
