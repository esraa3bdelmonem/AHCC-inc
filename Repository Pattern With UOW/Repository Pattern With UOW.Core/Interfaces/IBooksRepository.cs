using Repository_Pattern_With_UOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_With_UOW.Core.Interfaces
{
    public interface IBooksRepository: IBaseRepository<Book>
      
    {
        IEnumerable<Book> SpecialMethod();
    }
}
