using System;
using System.ComponentModel.DataAnnotations;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class ConfirmarInclusaoRequest
    {
        [Display(Name = "ID")]
        public string IdCliente { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
    
        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve conter de {2} à {1} de caracter.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "A senha e aconfirmação de Senha não são iguais.")]
        public string ConfSenha { get; set; }
    }
}
