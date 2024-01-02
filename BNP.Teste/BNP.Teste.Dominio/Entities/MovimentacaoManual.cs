using System;

namespace BNP.Teste.Dominio.Entities
{
    public class MovimentacaoManual
    {
        public decimal Mes { get; set; }
        public decimal Ano { get; set; }
        public long NumLancamento { get; set; }
        public string CodProduto { get; set; }
        public string CodCosif { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string CodUsuario { get; set; }
        public decimal Valor { get; set; }
    }
}
