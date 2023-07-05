using Repository_Pattern_With_UOW.Core;
using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;
using Repository_Pattern_With_UOW.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_With_UOW.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBaseRepository<Author> Authors { get; private set; }
        public IBooksRepository Books { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BooksRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
