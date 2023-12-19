using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WafSistemas.GerenciadorCliente.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Inserir(TEntity entity);
        TEntity Alterar(TEntity entity);
        IEnumerable<TEntity> Pesquisar(Func<TEntity, bool> pre);
    }
}
