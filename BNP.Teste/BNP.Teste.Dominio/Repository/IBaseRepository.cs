using System.Collections.Generic;

namespace BNP.Teste.Dominio.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Inserir(TEntity entity);
        IEnumerable<TEntity> List();
    }
}
