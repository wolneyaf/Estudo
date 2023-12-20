using BNP.Teste.Service.DTO;
using System.Collections.Generic;

namespace BNP.Teste.Service.Interface
{
    public interface IProdutoCosifService
    {
        List<ProdutoCosifComboDto> BuscarDadosParaCombo(string codigoProduto);
    }
}
