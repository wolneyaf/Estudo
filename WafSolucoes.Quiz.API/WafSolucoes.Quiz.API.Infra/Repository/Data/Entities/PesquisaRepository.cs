using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data.Entities
{
    public class PesquisaRepository: BaseRepository<Pesquisa>, IPesquisaRepository
    {
        private readonly QuizContext Context;
        public PesquisaRepository(QuizContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Pesquisa> Listar()
        {
            var collection = Context.Set<Pesquisa>();
            return collection;
        }

        public IEnumerable<Pesquisa> Listar(string idCliente)
        {
            var collection = Context.Set<Pesquisa>().Where(l => l.IdCliente == idCliente);
            return collection;
        }

        public Pesquisa Pesquisar(long idPesquisa, string idCliente)
        {
            var item = Context.Set<Pesquisa>().FirstOrDefault(p => p.IdCliente == idCliente && p.IdPesquisa == idPesquisa);
            return item;
        }
    }
}
