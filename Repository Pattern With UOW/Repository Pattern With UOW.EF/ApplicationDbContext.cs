using Microsoft.EntityFrameworkCore;
using Repository_Pattern_With_UOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_With_UOW.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
