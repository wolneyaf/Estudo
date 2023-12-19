using System;
using System.ComponentModel.DataAnnotations;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class AlterarClienteRequest
    {
        [Display(Name = "Id")]
        public string IdCliente { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; set; }
        [Display(Name = "Cpf/Cnpj")]
        public string CPF { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Display(Name = "Status")]
        public short Status { get; set; }
    }
}
