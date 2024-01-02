using System;
using System.ComponentModel.DataAnnotations;

namespace BNP.Teste.Service.DTO
{
    public class MovimentoDto
    {
        [Range(1, 12)]
        [Required]
        public int Mes { get; set; }
        [Range(1900, 9999)]
        [Required]
        public int Ano { get; set; }
        public long NumLancamento { get; set; }
        [Required]
        public string CodProduto { get; set; }
        [Required]
        public string CodCosif { get; set; }
        [Required]
        public string Descricao { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string CodUsuario { get; set; }
        [Required]
        public decimal Valor { get; set; }
    }
}
