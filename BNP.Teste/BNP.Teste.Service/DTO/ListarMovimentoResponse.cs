using System.Collections.Generic;

namespace BNP.Teste.Service.DTO
{
    public class ListarMovimentoResponse
    {
        public MovimentoDto Movimento { get;set;}
        public List<ProdutoComboDto> Produtos { get; set; }
        public List<ListaMovimentoDto> Movimentos { get; set; }
        public bool IsNew { get; set; }
    }
}
