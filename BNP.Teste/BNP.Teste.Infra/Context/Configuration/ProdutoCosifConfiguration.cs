using BNP.Teste.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace BNP.Teste.Infra.Context.Configuration
{
    public static class ProdutoCosifConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoCosif>()
                .HasKey(k => new { k.CodCosif, k.CodProduto }).HasName("PK_PRODUTO_COSIF");

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("ProdutoCosif")
                   .Property(e => e.CodProduto).HasColumnName("COD_PRODUTO")
                   .IsRequired();

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("ProdutoCosif")
                   .Property(e => e.CodCosif).HasColumnName("COD_COSIF");

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("ProdutoCosif")
                   .Property(e => e.CodClassificacao).HasColumnName("COD_CLASSIFICACA");

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("ProdutoCosif")
                   .Property(e => e.Status).HasColumnName("STA_STATUS");
        }
    }
}
