using System;
using System.Collections.Generic;
using System.Linq;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data.Entities
{
    public class QuestaoRepository: BaseRepository<Questao>, IQuestaoRepository
    {
        private readonly QuizContext Context;
        public QuestaoRepository(QuizContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Questao> Listar(string idCliente, long idPesquisa, long idPergunta)
        {
            var collection = Context.Set<Questao>().Where(l => l.IdCliente == idCliente && l.IdPesquisa == idPesquisa && l.IdPergunta == idPergunta);
            return collection;
        }

        public Questao Pesquisar(long idPesquisa, string idCliente, long idPergunta, long idQuestao)
        {
            var item = Context.Set<Questao>().FirstOrDefault(p => p.IdCliente == idCliente && p.IdPesquisa == idPesquisa && p.IdPergunta == idPergunta && p.IdQuestao == idQuestao);
            return item;
        }
    }
}
