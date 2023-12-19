using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration
{
    public static class RespostaConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resposta>()
                        .HasKey(k => new { k.IdQuestionario, 
                                           k.IdQuestao, 
                                           k.IdPergunta, 
                                           k.IdPesquisa, 
                                           k.IdCliente })
                        .HasName("PK_Resposta");

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.IdQuestionario).HasColumnName("RES_QUE_ID")
                        .IsRequired();

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.IdQuestao).HasColumnName("RES_QTO_ID")
                        .IsRequired();

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.IdPergunta).HasColumnName("RES_QTO_PER_ID")
                        .IsRequired();

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.IdPesquisa).HasColumnName("RES_QTO_PER_PES_ID")
                        .IsRequired();

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.IdCliente).HasColumnName("RES_QTO_PER_PES_CLI_ID")
                        .IsRequired();

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.Descricao).HasColumnName("RES_DES");

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.DataInc).HasColumnName("RES_DAT_INC")
                        .HasColumnType("datetime");

            modelBuilder.Entity<Resposta>()
                        .ToTable("Resposta")
                        .Property(e => e.DataAlt).HasColumnName("RES_DAT_ALT")
                        .HasColumnType("datetime");
        }
    }
}