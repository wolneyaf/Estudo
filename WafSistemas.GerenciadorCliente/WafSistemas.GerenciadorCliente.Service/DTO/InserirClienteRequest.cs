using System.ComponentModel.DataAnnotations;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class InserirClienteRequest
    {
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo CPF/CNPJ é Obrigatório")]
        public string CPFCnpj { get; set; }
        [Required(ErrorMessage = "O campo Email é Obrigatório")]
        public string Email { get; set; }         
        public string Login { get; set; }         
        public string Senha { get; set; }
        public string Request { get; set; }
    }
}
