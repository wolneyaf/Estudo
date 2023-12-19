using System;
using System.Collections.Generic;
using System.Linq;
using WafSolucoes.Quiz.API.Domain.Entities;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data.Entities
{
    public class QuestionarioRepository : BaseRepository<Questionario>, IQuestionarioRepository
    {
        private readonly QuizContext Context;
        public QuestionarioRepository(QuizContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Questionario> Listar(string idCliente)
        {
            var collection = Context.Set<Questionario>().Where(l => l.IdCliente == idCliente);
            return collection;
        }

        public Questionario Pesquisar(string idCliente, long idQuestionario)
        {
            var item = Context.Set<Questionario>().FirstOrDefault(p => p.IdCliente == idCliente && p.IdQuestionario == idQuestionario );
            return item;
        }
    }
}
