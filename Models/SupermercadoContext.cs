using Microsoft.EntityFrameworkCore;

namespace SupermercadoAPI.Models
{
    public class SupermercadoContext : DbContext
    {
        public SupermercadoContext(DbContextOptions<SupermercadoContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
