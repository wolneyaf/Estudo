using System;
using System.Collections.Generic;
using System.Linq;
using WafSistemas.GerenciadorCliente.Domain.Repository;
using WafSistemas.GerenciadorCliente.Infra.Repository.Context;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private readonly GerenciadorContext Context;
        public BaseRepository(GerenciadorContext context)
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

        public IEnumerable<T> Pesquisar(Func<T, bool> pre)
        {
            var Itens = Context.Set<T>().Where<T>(pre);
            return Itens;
        }        

    }
}
