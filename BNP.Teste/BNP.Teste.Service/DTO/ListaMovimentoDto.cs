namespace BNP.Teste.Service.DTO
{
    public class ListaMovimentoDto
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string CodProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public long NumLancamento { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
