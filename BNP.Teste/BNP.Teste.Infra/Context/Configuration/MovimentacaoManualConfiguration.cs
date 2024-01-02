using BNP.Teste.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace BNP.Teste.Infra.Context.Configuration
{
    public static class MovimentacaoManualConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovimentacaoManual>()
                .HasKey(k => new { k.Mes, k.Ano, k.NumLancamento, k.CodProduto, k.CodCosif }).HasName("PK_MOVIMENTO_MANUAL");

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.Mes ).HasColumnName("DAT_MES")
                   .IsRequired();

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.Ano).HasColumnName("DAT_ANO");

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.NumLancamento).HasColumnName("NUM_LANCAMENTO");

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.CodProduto).HasColumnName("COD_PRODUTO");

            modelBuilder.Entity<MovimentacaoManual>()
                  .ToTable("MOVIMENTO_MANUAL")
                  .Property(e => e.CodCosif).HasColumnName("COD_COSIF");

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.Descricao).HasColumnName("DES_DESCRICAO");

            modelBuilder.Entity<MovimentacaoManual>()                   
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.DataMovimentacao).HasColumnName("DAT_MOVIMENTO");

            modelBuilder.Entity<MovimentacaoManual>()
                  .ToTable("MOVIMENTO_MANUAL")
                  .Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

            modelBuilder.Entity<MovimentacaoManual>()
                   .ToTable("MOVIMENTO_MANUAL")
                   .Property(e => e.Valor).HasColumnName("VAL_VALOR");

        }
    }
}
