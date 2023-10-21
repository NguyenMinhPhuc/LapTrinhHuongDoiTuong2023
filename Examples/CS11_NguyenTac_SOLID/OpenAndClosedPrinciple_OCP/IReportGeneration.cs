using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.OpenAndClosedPrinciple_OCP
{
    public interface IReportGeneration
    {
        public void GenerateReport(Employee employee);
    }
}