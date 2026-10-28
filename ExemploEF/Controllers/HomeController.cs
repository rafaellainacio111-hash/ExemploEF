using ExemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploEF.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>
          options) : base(options)
        { }

        protected Context()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<categoria> Categorias { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("tbClientes");
            modelBuilder.Entity<categoria>().ToTable("tbCategorias");
        }
    }
}