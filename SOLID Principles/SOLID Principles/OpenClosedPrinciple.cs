using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class OpenClosedPrinciple
    {
        public string ReportType { get; set; }
        public void GenerateReport()
        {
            if (ReportType == "StockInformation")
            {
                //stock information report generation
            }
            if (ReportType == "ProductInformation")
            {
                //Product information report generation
            }
            if (ReportType == "EmployeeInformation")
            {
                //Employee information report generation
            }
        }
    }
    public class  ReportsGenerator
    {
        public virtual void GenerateReport()
        {
            //
        }

     }
    public class  StockInformationReport: ReportsGenerator
    {
        public override void GenerateReport()
            {
                //
            }

      }
    public class ProductInformationReport : ReportsGenerator
    {
        public override void GenerateReport()
        {
            //
        }

    }
    public class EmployeeInformationReport : ReportsGenerator
    {
        public override void GenerateReport()
        {
            //
        }

    }
}


     
 
