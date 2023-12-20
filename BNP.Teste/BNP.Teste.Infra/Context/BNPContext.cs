using BNP.Teste.Dominio.Entities;
using BNP.Teste.Infra.Context.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BNP.Teste.Infra.Context
{
    public class BNPContext :DbContext
    {
        public BNPContext(DbContextOptions<BNPContext> options) : base(options) { }

        public DbSet<Produto>Produto { get; set; }
        public DbSet<ProdutoCosif> ProdutoCosif { get; set; }
        public DbSet<Movimentacao> MovimentoManual { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProdutoConfiguration.OnModelCreating(ref modelBuilder);
            ProdutoCosifConfiguration.OnModelCreating(ref modelBuilder);
            MovimentacaoConfiguration.OnModelCreating(ref modelBuilder);
        }
    }
}
