using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac02_ThongThuong
{
    internal class ReportGeneration
    {
        public string ReportType { get; set; }

        public void GenerationReport(string reportType)
        {
            if (reportType == "Excel")
            {
                Console.WriteLine("xuat excel");
                //them code
            }
            else if (reportType == "PDF")
            {
                Console.WriteLine("xuat pdf");
                //them code
            }
            else if (reportType == "Power BI")
            {
                Console.WriteLine("xuat power BI");
                //code
            }
        }
    }
}
