using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public static class BankAccountExtensions
    {
        public static IEnumerable<IBankAccount> GetAccountsByBalance(this IEnumerable<IBankAccount> accounts, decimal balance)
        {
            return accounts.Where(a => a.Balance > balance);
        }

        public static IQueryable<IBankAccount> GetAccountsByBalance(this IQueryable<IBankAccount> accounts, decimal balance)
        {
            return accounts.Where(a => a.Balance > balance);
        }
    }
}
