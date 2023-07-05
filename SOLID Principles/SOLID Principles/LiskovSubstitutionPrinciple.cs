using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
      class LiskovSubstitutionPrinciple
    {
    }
    public abstract class Reports
    {
        public virtual string GetStockInformationDetails(int reoprtId)
        {
            return "Stock Information Details";
        }
        public virtual string GetProductInformationDetails(int reoprtId)
        {
            return "product Information Details";
        }

    }

    public class StockInformation : IStockInformation
    {
        //public override string GetStockInformationDetails(int reoprtId)
        //{
        //    return "Stock Information Details";
        //}

        //public override string GetProductInformationDetails(int reoprtId)
        //{
        //    return "product Information Details";
        //}
        public string GetStockInformationDetails(int reoprtId)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductInformation : IProductInformation
    {
        //public override string GetStockInformationDetails(int reoprtId)
        //{
        //    return "Stock Information Details";
        //}

        //public override string GetProductInformationDetails(int reoprtId)
        //{
        //  //  return "product Information Details";
        //  throw new NotImplementedException();
        //}
        public string GetProductInformationDetails(int reoprtId)
        {
            throw new NotImplementedException();
        }
    }
    public interface IStockInformation
    {
        string GetStockInformationDetails(int reoprtId);
   }
    public interface IProductInformation
    {
        string GetProductInformationDetails(int reoprtId);
    }

}
