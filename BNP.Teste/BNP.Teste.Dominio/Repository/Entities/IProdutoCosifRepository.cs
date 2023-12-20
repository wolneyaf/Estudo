using BNP.Teste.Dominio.Entities;
using System.Collections.Generic;

namespace BNP.Teste.Dominio.Repository.Entities
{
    public interface IProdutoCosifRepository: IBaseRepository<ProdutoCosif>
    {
        IEnumerable<ProdutoCosif> PesquisaProdutoCosifPorCodigo(string CodigoProduto);
    }
}
