using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_With_UOW.EF.Repositories
{
    public class BooksRepository : BaseRepository<Book>, IBooksRepository
    {
        private readonly ApplicationDbContext _context;
        public BooksRepository (ApplicationDbContext context): base(context)
        {
            
        }
        public IEnumerable<Book> SpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
