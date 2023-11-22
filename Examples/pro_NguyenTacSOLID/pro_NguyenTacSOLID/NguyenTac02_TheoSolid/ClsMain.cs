using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac02_TheoSolid
{
    internal class ClsMain
    {
        IReportGeneration reportGeneration;
        public ClsMain()
        {
            reportGeneration = new PDFReport();
        }

        public void Main()
        {
            reportGeneration.GenerationReport("");
        }


    }
}
