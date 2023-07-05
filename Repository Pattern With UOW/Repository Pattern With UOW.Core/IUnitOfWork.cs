using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_With_UOW.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Author> Authors { get; }
        IBooksRepository Books { get; }

        int Complete();
    }
}
