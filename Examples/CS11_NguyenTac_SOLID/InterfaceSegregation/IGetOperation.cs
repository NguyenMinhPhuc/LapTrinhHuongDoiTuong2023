using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.InterfaceSegregation
{
    public interface IGetOperation
    {
        bool ShowEmployeeDetail(int empId);
    }
}