using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public interface IBankAccount
    {
        int AccountNumber { get; set; }
        decimal Balance { get; set; }
        string OwnerName { get; set; }
        bool IsClosed { get; set; }
    }
}
