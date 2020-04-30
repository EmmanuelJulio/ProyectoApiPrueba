using System;
using Microsoft.EntityFrameworkCore;
using Datos.Clases;

namespace Datos
{
    public class ModelContext : DbContext
    {
        public DbSet<Producto> productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7H9VS1J;Database=VentaWebApi;Trusted_Connection=True;");
        }

    }
}
