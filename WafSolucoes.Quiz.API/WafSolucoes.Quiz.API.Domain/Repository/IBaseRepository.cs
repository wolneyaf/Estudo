using System.Collections.Generic;

namespace WafSolucoes.Quiz.API.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Inserir(TEntity entity);
        TEntity Alterar(TEntity entity); 
        //pesquisa dimanica verificar IEnumerable<TEntity> Pesquisar(Func<TEntity, bool> pre);
    }
}
