using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.Liskov_Substitution
{
    public class ThucThi
    {
        public void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new ContractualEmployee());
            employeeList.Add(new CasualEmployee());
            foreach (Employee e in employeeList)
            {
                e.GetEmployeeDetails(1245);
            }
        }
    }
}