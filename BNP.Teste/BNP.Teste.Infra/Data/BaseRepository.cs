using BNP.Teste.Dominio.Repository;
using BNP.Teste.Infra.Context;
using System.Collections.Generic;

namespace BNP.Teste.Infra.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly BnpContext Context;
        public BaseRepository(BnpContext context) 
        {
            Context = context;
        }

        public void Inserir(T entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
        }

        public IEnumerable<T> List()
        {
            var list = Context.Set<T>();
            return list;
        }
        
        public T Find(string codigo)
        {
            T item = Context.Find<T>(codigo);
            return item;
        }
    }
}
