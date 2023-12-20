using BNP.Teste.Dominio.Repository;
using BNP.Teste.Infra.Context;
using System.Collections.Generic;

namespace BNP.Teste.Infra.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly BNPContext Context;
        public BaseRepository(BNPContext context) 
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
            throw new System.NotImplementedException();
        }
    }
}
