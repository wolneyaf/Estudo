using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;

namespace BNP.Teste.Infra.Data.Entities
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public readonly BnpContext Context; 
        public ProdutoRepository(BnpContext context) : base(context)
        {
            Context = context;
        }

    }
}
