using BNP.Teste.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace BNP.Teste.Infra.Context.Configuration
{
    public static class ProdutoConfiguration
    {
        public static void OnModelCreating( ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(k => k.CodProduto).HasName("PK_PRODUTO");

            modelBuilder.Entity<Produto>()
               .ToTable("Produto")
               .Property(e => e.CodProduto).HasColumnName("COD_PRODUTO")
               .IsRequired();

            modelBuilder.Entity<Produto>()
               .ToTable("Produto")
               .Property(e => e.Descricao).HasColumnName("DES_PRODUTO");

            modelBuilder.Entity<Produto>()
               .ToTable("Produto")
               .Property(e => e.Status).HasColumnName("STA_STATUS");
        }
    }
}
