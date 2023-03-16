using Microsoft.EntityFrameworkCore;
using RgmTeste.Infra.Entities;

namespace RgmTeste.Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }

    }
}
