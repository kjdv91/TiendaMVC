using Microsoft.EntityFrameworkCore;
using Tienda.Models;

namespace Tienda.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<Categoria> Category { get; set; }
        public DbSet<TipoAplication> TipoAplication { get; set; }
        public DbSet<Producto> Producto { get; set; }

    }
}
