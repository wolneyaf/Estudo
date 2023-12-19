using System;
using System.Collections.Generic;
using WafSolucoes.Quiz.API.Domain.Repository;
using WafSolucoes.Quiz.API.Infra.Repository.Context;

namespace WafSolucoes.Quiz.API.Infra.Repository.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class 
    {
        private readonly QuizContext Context;
        public BaseRepository(QuizContext context)
        {
            Context = context;
        }

        public T Alterar(T entity)
        {
            var item = Context.Update<T>(entity);
            Context.SaveChanges();
            return item.Entity;
        }

        public T Inserir(T entity)
        {
            var item = Context.Add<T>(entity);
            Context.SaveChanges();
            return item.Entity;
        }
    }
}
