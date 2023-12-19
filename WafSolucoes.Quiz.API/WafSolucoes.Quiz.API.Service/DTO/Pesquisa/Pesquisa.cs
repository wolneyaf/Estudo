using System;
using System.ComponentModel.DataAnnotations;

namespace WafSolucoes.Quiz.API.Service.DTO.Pesquisa
{
    public class Pesquisa
    {
        public string IdCliente { get; set; }
        [Display(Name = "ID")]
        public string IdPesquisa { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        [Display(Name = "Validade")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Validade { get; set; }
    }
}
