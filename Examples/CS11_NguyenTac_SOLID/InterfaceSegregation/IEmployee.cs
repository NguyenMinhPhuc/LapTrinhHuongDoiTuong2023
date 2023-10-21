using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.InterfaceSegregation
{
    public interface IEmployee:IGetOperation,IAddOperation
    {
        bool AddEmployeeDetail();
        bool ShowEmployeeDetail();
    }
}