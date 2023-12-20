using BNP.Teste.Service.DTO;
using System.Collections.Generic;

namespace BNP.Teste.Service.Interface
{
    public interface IProdutoService
    {
        List<ProdutoComboDto> ListarCombo();
    }
}
