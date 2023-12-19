using System;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class SendClienteRequest
    {
        public string IdCliente { get; set; }       
        public string Nome { get; set; }          
        public DateTime DataCriacao { get; set; } 
        public string CPF { get; set; }
        public string Email { get; set; }         
        public string Login { get; set; }
        public string Request { get; set; }
    }
}
