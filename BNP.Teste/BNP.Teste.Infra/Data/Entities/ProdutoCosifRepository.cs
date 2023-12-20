using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Teste.Infra.Data.Entities
{
    public class ProdutoCosifRepository : BaseRepository<ProdutoCosif>, IProdutoCosifRepository
    {
        public readonly BnpContext Context;
        public ProdutoCosifRepository(BnpContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<ProdutoCosif> PesquisaProdutoCosifPorCodigo(string CodigoProduto)
        {
            IEnumerable<ProdutoCosif> list = Context.ProdutoCosif.Where(x => x.CodProduto == CodigoProduto);
            return list;
        }
        
    }
}
