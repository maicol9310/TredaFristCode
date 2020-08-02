using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTredaApi.Data
{
    public class TredaDbContext: DbContext
    {
        public TredaDbContext()
        {
        }

        public TredaDbContext(DbContextOptions<TredaDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ONEKBJG\\MSSQLSERVERJAN;Initial Catalog=Treda;User ID=sa;Password=1234;");
            }
        }

        public virtual DbSet<Stores> Stores { get; set; }

        public virtual DbSet<Products> Products { get; set; }
    }
}
