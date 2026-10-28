using ExemploEF.Migrations;
using ExemploEF.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ExemploEF.Data
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public record Context(DbSet<Cliente> Clientes, DbSet<categoria> Categorias) : DbContext
    {
        public Context(DbContextOptions<Context>
          options) : this(default, default)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("tbClientes");
            modelBuilder.Entity<categoria>().ToTable("tbCategorias");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}