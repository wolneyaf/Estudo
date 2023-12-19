
using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration
{
    public static class QuestionarioConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questionario>()
                        .HasKey(k => k.IdQuestionario)
                        .HasName("PK_Questionario");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.IdQuestionario).HasColumnName("QUE_ID")
                        .IsRequired();

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.IdCliente).HasColumnName("QUE_CLI_ID")
                        .IsRequired();

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Sexo).HasColumnName("QUE_SX");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Idade).HasColumnName("QUE_IDA");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Religiao).HasColumnName("QUE_REL");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Latitude).HasColumnName("QUE_LAT");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Longitude).HasColumnName("QUE_LON");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.Aplicativo).HasColumnName("QUE_APL");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.DataInc).HasColumnName("QUE_DAT_INC")
                        .HasColumnType("datetime");

            modelBuilder.Entity<Questionario>()
                        .ToTable("Questionario")
                        .Property(e => e.DataAlt).HasColumnName("QUE_DAT_ALT")
                        .HasColumnType("datetime");
        }
    }
}