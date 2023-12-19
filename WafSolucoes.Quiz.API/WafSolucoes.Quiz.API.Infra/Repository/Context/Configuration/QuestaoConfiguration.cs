
using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration
{
    public static class QuestaoConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questao>()
               .HasKey(k => new { k.IdCliente, 
                                  k.IdPesquisa })
               .HasName("PK_Questao");

            modelBuilder.Entity<Questao>()
                        .ToTable("Questao")
                        .Property(e => e.IdQuestao).HasColumnName("QTO_ID")
                        .IsRequired();

            modelBuilder.Entity<Questao>()
                        .ToTable("Questao")
                        .Property(e => e.IdPergunta).HasColumnName("QTO_PER_ID")
                        .IsRequired();

            modelBuilder.Entity<Questao>()
                        .ToTable("Questao")
                        .Property(e => e.IdPesquisa).HasColumnName("QTO_PER_PES_ID")
                        .IsRequired();

            modelBuilder.Entity<Questao>()
                        .ToTable("Questao")
                        .Property(e => e.IdCliente).HasColumnName("QTO_PER_PES_CLI_ID")
                        .IsRequired();

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.Descricao).HasColumnName("QTO_DES");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.Descricao).HasColumnName("QTO_OBJ");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.Descricao).HasColumnName("QTO_DAT_INC")
                        .HasColumnType("datetime");

            modelBuilder.Entity<Pesquisa>()
                        .ToTable("Pesquisa")
                        .Property(e => e.Descricao).HasColumnName("QTO_DAT_ALT")
                        .HasColumnType("datetime");
        }
    }
}
