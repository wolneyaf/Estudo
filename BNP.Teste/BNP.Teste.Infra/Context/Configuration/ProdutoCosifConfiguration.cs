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
                   .ToTable("PRODUTO_COSIF")
                   .Property(e => e.CodProduto).HasColumnName("COD_PRODUTO")
                   .IsRequired();

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("PRODUTO_COSIF")
                   .Property(e => e.CodCosif).HasColumnName("COD_COSIF");

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("PRODUTO_COSIF")
                   .Property(e => e.CodClassificacao).HasColumnName("COD_CLASSIFICACAO");

            modelBuilder.Entity<ProdutoCosif>()
                   .ToTable("PRODUTO_COSIF")
                   .Property(e => e.Status).HasColumnName("STA_STATUS");
        }
    }
}
