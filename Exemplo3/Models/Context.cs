using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Exemplo3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options)
        { }

        public DbSet<Produto> Produtos { get; set; }    
        public DbSet<Fabricante> Fabricantes { get; set;}
    }
}
