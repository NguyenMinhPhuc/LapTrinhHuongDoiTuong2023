using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.Liskov_Substitution
{
    public interface IProject
    {
        public virtual string GetProjectDetails(int employeeId);

    }
}