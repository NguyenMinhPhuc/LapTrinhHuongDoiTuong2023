using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.Liskov_Substitution
{
    public class ContractualEmployee : IEmployee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        
    }
}