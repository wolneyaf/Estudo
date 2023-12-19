using Microsoft.EntityFrameworkCore;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context.Configuration;

namespace WafSolucoes.Quiz.API.Infra.Repository.Context
{
    public class QuizContext: DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }


        //public DbSet<Questao> Questao { get; set; }
        //public DbSet<Questionario> Questionario { get; set; }
        public DbSet<Pesquisa> Pesquisa { get; set; }
        //public DbSet<Resposta> Resposta { get; set; }
        //public DbSet<Pergunta> Pergunta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PerguntaConfiguration.OnModelCreating(ref modelBuilder);
            PesquisaConfiguration.OnModelCreating(ref modelBuilder);
            //QuestionarioConfiguration.OnModelCreating(ref modelBuilder);
            //QuestaoConfiguration.OnModelCreating(ref modelBuilder);
            //RespostaConfiguration.OnModelCreating(ref modelBuilder);

            //modelBuilder.Entity<Pesquisa>()
            //   .HasKey(k => new { k.IdPesquisa, k.IdCliente })
            //   .HasName("PK_Pesquisa");

            ////modelBuilder.Entity<Pesquisa>()
            ////   .HasKey(k => k.IdPesquisa);

            //modelBuilder.Entity<Pesquisa>()
            //          .ToTable("Pesquisa")
            //          .Property(e => e.IdPesquisa).HasColumnName("PES_ID")
            //          .IsRequired();

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //           .Property(e => e.IdCliente).HasColumnName("PES_CLI_ID")
            //           .IsRequired();

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //            //.HasNoKey()
            //            .Property(e => e.Nome).HasColumnName("PES_NOME");

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //            //.HasNoKey()
            //           .Property(e => e.Descricao).HasColumnName("PES_DES");

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //            //.HasNoKey()
            //           .Property(e => e.Validade).HasColumnName("PES_VLD");

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //            //.HasNoKey()
            //            .Property(e => e.DataInc).HasColumnName("PES_DAT_INC")
            //            .HasColumnType("datetime");

            //modelBuilder.Entity<Pesquisa>()
            //            .ToTable("Pesquisa")
            //            //.HasNoKey()
            //            .Property(e => e.DataAlt).HasColumnName("PESQ_DAT_ALT")
            //            .HasColumnType("datetime");
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
