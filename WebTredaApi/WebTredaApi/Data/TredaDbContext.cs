using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTredaApi.Data
{
    public class TredaDbContext: DbContext
    {

        public TredaDbContext(DbContextOptions<TredaDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Stores> Stores { get; set; }

        public virtual DbSet<Products> Products { get; set; }
    }
}
