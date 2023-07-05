using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public interface IBankAccountRepository
    {
        IEnumerable<IBankAccount> GetAllAccounts();
        IQueryable<IBankAccount> GetQueryableAccounts();
    }
}
