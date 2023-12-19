using System;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class AlterarStatusRequest
    {
        public string IdCliente { get; set; }       
        public short Status { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
