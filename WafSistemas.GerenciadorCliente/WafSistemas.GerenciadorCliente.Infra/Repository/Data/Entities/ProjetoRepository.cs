using System.Collections.Generic;
using System.Linq;
using WafSistemas.GerenciadorCliente.Domain.Entities;
using WafSistemas.GerenciadorCliente.Domain.Repository.Entities;
using WafSistemas.GerenciadorCliente.Infra.Repository.Context;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Data.Entities
{
    public class ProjetoRepository : BaseRepository<Projeto>, IProjetoRepository
    {
        private readonly GerenciadorContext Context;
        public ProjetoRepository(GerenciadorContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Projeto> ListarAtivos()
        {
            var Items = Pesquisar(x => x.Status == 1);
            return Items;
        }

        public IEnumerable<Projeto> Listar()
        {
            var Items = Context.Set<Projeto>();
            return Items;
        }

        public Projeto Pesquisar(long id)
        {
            var item = Context.Set<Projeto>().FirstOrDefault(x => x.IdProjeto == id);
            return item;
        }        
    }

}
