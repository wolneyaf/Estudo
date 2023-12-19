
using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration
{
    public static class PesquisaConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pesquisa>()
                .HasKey(k => new { k.IdCliente, k.IdPesquisa })
                .HasName("PK_Pesquisa");

            modelBuilder.Entity<Pesquisa>()
                      .ToTable("Pesquisa")
                      .Property(e => e.IdPesquisa).HasColumnName("PES_ID")
                      .IsRequired();

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                       .Property(e => e.IdCliente).HasColumnName("PES_CLI_ID")
                       .IsRequired();

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                       .Property(e => e.Nome).HasColumnName("PES_NOME");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                       .Property(e => e.Descricao).HasColumnName("PES_DES");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                       .Property(e => e.Validade).HasColumnName("PES_VLD");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.DataInc).HasColumnName("PES_DAT_INC")
                        .HasColumnType("datetime");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.DataAlt).HasColumnName("PESQ_DAT_ALT")
                        .HasColumnType("datetime");
        }
    }
}
