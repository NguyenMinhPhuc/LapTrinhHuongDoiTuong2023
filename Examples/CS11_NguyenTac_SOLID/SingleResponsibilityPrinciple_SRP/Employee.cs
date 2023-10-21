using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.SingleResponsibilityPrinciple_SRP
{
    public class Employee
    {
        int empId;
        string empName;

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }

        public bool InsertIntoEmpTable(Employee employee){
            //Code insert
            return true;
        }
    }

    
}