using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Zavod> Zavods { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
          : base(options)
        {
            Database.EnsureCreated();        }
    }
}
