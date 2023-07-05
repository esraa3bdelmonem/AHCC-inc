using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public class InMemoryBankAccountRepository : IBankAccountRepository
    {
        private readonly List<IBankAccount> _accounts;

        public InMemoryBankAccountRepository()
        {
            _accounts = new List<IBankAccount>
        {
            new BankAccount { AccountNumber = 1, Balance = 10000, OwnerName = "Esraa", IsClosed = false },
            new BankAccount { AccountNumber = 2, Balance = 500, OwnerName = "Laila", IsClosed = false },
            new BankAccount { AccountNumber = 3, Balance = 20000, OwnerName = "Soaad", IsClosed = true },
            new BankAccount { AccountNumber = 4, Balance = 300, OwnerName = "Afnan", IsClosed = false }
        };
        }

        public IEnumerable<IBankAccount> GetAllAccounts()
        {
            return _accounts;
        }

        public IQueryable<IBankAccount> GetQueryableAccounts()
        {
            return _accounts.AsQueryable();
        }
    }
}
