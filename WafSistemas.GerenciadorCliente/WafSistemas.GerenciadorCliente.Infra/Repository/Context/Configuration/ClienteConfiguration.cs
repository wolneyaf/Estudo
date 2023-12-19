using Microsoft.EntityFrameworkCore;
using WafSistemas.GerenciadorCliente.Domain.Entities;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Context.Configuration
{
    public static class ClienteConfiguration
    {
        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(k => k.IdCliente).HasName("PK_Cliente");

            modelBuilder.Entity<Cliente>()
               .ToTable("Cliente")
               .Property(e => e.IdCliente).HasColumnName("CLI_ID")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.Login).HasColumnName("CLI_LOGIN");

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.Nome).HasColumnName("CLI_NAME");

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.CPFCnpj).HasColumnName("CLI_CPFCNPJ");

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.Email).HasColumnName("CLI_EMAIL");

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.Senha).HasColumnName("CLI_SENHA");

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.DataCriacao).HasColumnName("CLI_DAT_CRE")
               .HasColumnType("datetime"); 

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.DataAlteracao).HasColumnName("CLI_DAT_UPD")
               .HasColumnType("datetime"); 

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.DataLiberação).HasColumnName("CLI_DAT_LIB")
               .HasColumnType("datetime"); 

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
               .Property(e => e.Status).HasColumnName("CLI_STATUS");
        }
    }
}
