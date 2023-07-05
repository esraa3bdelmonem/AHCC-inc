using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public class BankAccount : IBankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string OwnerName { get; set; }
        public bool IsClosed { get; set; }
    }
}
