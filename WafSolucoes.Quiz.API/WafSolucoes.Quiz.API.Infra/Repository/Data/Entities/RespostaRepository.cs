using System;
using System.Collections.Generic;
using System.Linq;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data.Entities
{
    public class RespostaRepository : BaseRepository<Resposta>, IRespostaRepository
    {        
        private readonly QuizContext Context;
        public RespostaRepository(QuizContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Resposta> Listar()
        {
            var collection = Context.Set<Resposta>();
            return collection;
        }

        public IEnumerable<Resposta> Listar(string idCliente, long idPesquisa, long idPergunta, long idQuestionario)
        {
            var collection = Context.Set<Resposta>().Where(l => l.IdCliente == idCliente && l.IdPesquisa == idPesquisa && l.IdPergunta == idPergunta && l.IdQuestionario == idQuestionario);
            return collection;
        }

        public Resposta Pesquisar(string idCliente, long idPesquisa, long idPergunta, long idQuestao, long idQuestionario)
        {
            var item = Context.Set<Resposta>().FirstOrDefault(p => p.IdCliente == idCliente && p.IdPesquisa == idPesquisa && p.IdPergunta == idPergunta && p.IdQuestao == idQuestao && p.IdQuestionario == idQuestionario);
            return item;
        }
    }
}
