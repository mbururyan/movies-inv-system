#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test1.Models;

namespace test1.Data
{
    public class test1Context : DbContext
    {
        public test1Context (DbContextOptions<test1Context> options)
            : base(options)
        {
        }

        public DbSet<test1.Models.Movie> Movie { get; set; }
    }
}
