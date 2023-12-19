using Microsoft.EntityFrameworkCore;
using WafSistemas.GerenciadorCliente.Domain.Entities;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Context.Configuration
{
    public static class ProjetoConfiguration
    {

        public static void OnModelCreating(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>()
               .HasKey(k => k.IdProjeto).HasName("PK_Projeto");

            modelBuilder.Entity<Projeto>()
               .ToTable("Projeto")
               .Property(e => e.IdProjeto).HasColumnName("PRJ_ID")
               .IsRequired();

            modelBuilder.Entity<Projeto>()
                .ToTable("Projeto")
               .Property(e => e.Nome).HasColumnName("PRJ_NAME");

            modelBuilder.Entity<Projeto>()
                .ToTable("Projeto")
               .Property(e => e.Status).HasColumnName("PRJ_STA");
        }

    }
}
