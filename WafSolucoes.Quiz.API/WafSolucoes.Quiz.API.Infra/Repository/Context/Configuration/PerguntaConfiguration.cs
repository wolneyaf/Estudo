
using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration
{
    public static class PerguntaConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pergunta>()
               .HasKey(k => new { k.IdPergunta, 
                                  k.IdPesquisa, 
                                  k.IdCliente }).HasName("PK_Pergunta");

            modelBuilder.Entity<Pergunta>()
               .ToTable("Pergunta")
               .Property(e => e.IdPergunta).HasColumnName("PER_ID")
               .IsRequired();

            modelBuilder.Entity<Pergunta>()
               .ToTable("Pergunta")
               .Property(e => e.IdPesquisa).HasColumnName("PER_PES_ID")
               .IsRequired();

            modelBuilder.Entity<Pergunta>()
               .ToTable("Pergunta")
               .Property(e => e.IdCliente).HasColumnName("PER_PES_CLI_ID")
               .IsRequired();

            modelBuilder.Entity<Pergunta>()
                .ToTable("Pergunta")
                .Property(e => e.Descricao).HasColumnName("PER_DES");

            modelBuilder.Entity<Pergunta>()
                .ToTable("Pergunta")
                .Property(e => e.DataInc).HasColumnName("PER_DAT_INC")
                .HasColumnType("datetime");

            modelBuilder.Entity<Pergunta>()
                .ToTable("Pergunta")
                .Property(e => e.DataAlt).HasColumnName("PER_DAT_ALT")
                .HasColumnType("datetime");
        }
    }
}