using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTac1_Single
{
    internal class CasualEmployee : Employee, IEmployee, IProject
    {
        public void GetEmployeeDetail()
        {
            Console.WriteLine("Get Employee Detail");
        }

        public void GetProjectDetail()
        {
            Console.WriteLine("Get Project Detail");
        }
    }
}
