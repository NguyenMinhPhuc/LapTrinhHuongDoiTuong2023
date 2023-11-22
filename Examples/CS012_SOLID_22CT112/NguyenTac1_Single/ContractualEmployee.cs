using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTac1_Single
{
    internal class ContractualEmployee : Employee, IProject
    {
        public void GetProjectDetail()
        {
            Console.WriteLine("Get Project Detail");
        }
    }
}
