using Microsoft.EntityFrameworkCore;
using WafSistemas.GerenciadorCliente.Domain.Entities;
using WafSistemas.GerenciadorCliente.Infra.Repository.Context.Configuration;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Context
{
    public class GerenciadorContext : DbContext
    {
        public GerenciadorContext(DbContextOptions<GerenciadorContext> options) : base(options) {}


        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        //public DbSet<Permissao> Permissao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ClienteConfiguration.OnModelCreating(ref modelBuilder);
            ProjetoConfiguration.OnModelCreating(ref modelBuilder);

        }
    }
}
