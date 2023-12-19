using System;
using System.ComponentModel.DataAnnotations;

namespace WafSistemas.GerenciadorCliente.Service.DTO.Projeto
{
    public class Projeto
    {
        [Display(Name = "ID")]
        public decimal IdProjeto { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Status")]
        public short Status { get; set; } //0= Bloqueado 1=Liberado
    }
}
