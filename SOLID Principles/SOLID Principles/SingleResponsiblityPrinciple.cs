using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
     class SingleResponsiblityPrinciple
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        public bool AddNewEmployee(Emplyee emplyee)
        {
            return true;
        }
        //public void GenerateEmployeeReport(Emplyee emplyee)
        //{
        //    //return report data
        //}
    }
    public class ReportGeneration
    {
        public void GenerateReport(Emplyee emplyee)
        {
            //Report reneration with employee data.
        }
    }

}
