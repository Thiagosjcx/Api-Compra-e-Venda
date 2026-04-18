using Microsoft.EntityFrameworkCore;
using Api_Compra_e_Venda.Models;

namespace Api_Compra_e_Venda.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Trade> Trades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=compra_venda;Username=postgres;Password=yourpassword");
            }
        }
    }
}