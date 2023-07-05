using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class DependencyInversionPrinciple
    {
    }
    public class EmailReport
    {
        public void SendEmailReport()
        {
            // send report mail
        }

    }
    public class CustomerNotification
    {
        private EmailReport _emailReport;
        public CustomerNotification()
        {
            _emailReport = new EmailReport();
        }
        public void YearEndSalesNotification()
        {
            _emailReport.SendEmailReport();
        }

    }
    public interface IReports
    {
        void SendMessage();
    }
    public class Email : IReports {
        public void SendMessage()
        {

        }
    }
    //constructor Injection
    public class CostructorInjection_Notification
    {
        private IReports _ireport;
        public CostructorInjection_Notification(IReports ireport)
        {
            _ireport = ireport;
        }
        public void DoNotify()
        {
            _ireport.SendMessage();
        }
    }

    //Property Injection
    public class PropertyInjection_Notification
    {
        private IReports _ireport;
        public PropertyInjection_Notification()
        {

        }
        public IReports MessageService
        {
            //private get;
            set
            {
                _ireport = value;
            }
        }
        public void DoNotify()
        {
            _ireport.SendMessage();
        }
    }
    //method injection
    public class MethodInjection_Notification
        {
        public void DoNotify(IReports ireport)

        {
            ireport.SendMessage();
        }

        }



}
