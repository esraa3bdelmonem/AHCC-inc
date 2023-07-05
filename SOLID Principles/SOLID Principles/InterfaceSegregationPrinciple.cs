using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class InterfaceSegregationPrinciple
    {
    }
    public interface Ireport
    {
        bool AddReportDetails();
    }
    public interface IreportDataBase
    {
        bool AddReportDetails();
        bool ShowReportDetails(int reportId);
    }

    public interface IAddReport
    {
        bool AddReportDetails();
    }
    public interface IGetReport
    {
        bool ShowReportDetails(int reportId);
    }
}
