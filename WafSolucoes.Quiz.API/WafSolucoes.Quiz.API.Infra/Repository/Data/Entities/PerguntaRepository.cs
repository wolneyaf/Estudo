using System;
using System.Collections.Generic;
using System.Linq;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data.Entities
{
    public class PerguntaRepository : BaseRepository<Pergunta>, IPerguntaRepository
    {
        private readonly QuizContext Context;
        public PerguntaRepository(QuizContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Pergunta> Listar(string idCliente, long idPesquisa)
        {
            var collection = Context.Set<Pergunta>().Where(l => l.IdCliente == idCliente && l.IdPesquisa == idPesquisa);
            return collection;
        }

        public Pergunta Pesquisar(long idPesquisa, string idCliente, long idPergunta)
        {
            var item = Context.Set<Pergunta>().FirstOrDefault(p => p.IdCliente == idCliente && p.IdPesquisa == idPesquisa && p.IdPergunta == idPergunta);
            return item;
        }
    }
}
