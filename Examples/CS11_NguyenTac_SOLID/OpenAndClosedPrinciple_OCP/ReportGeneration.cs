using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.OpenAndClosedPrinciple_OCP
{
    public class ReportGeneration
    {
        public string ReportType{get;set;}

        public void CreateReport(Employee employee){
            if(ReportType=="XLS"){
                //Tao report bang Excel
            }
            if(ReportType=="PDF"){
                //tao report bang PDF
            }
        }
    }
}