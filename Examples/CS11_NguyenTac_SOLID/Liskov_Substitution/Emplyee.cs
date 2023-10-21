using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.Liskov_Substitution
{
    public abstract class Emplyee
{
    public virtual string GetProjectDetails(int employeeId)
    {
        return "Base Project";
    }
    public virtual string GetEmployeeDetails(int employeeId)
    {
        return "Base Employee";
    }
}
}