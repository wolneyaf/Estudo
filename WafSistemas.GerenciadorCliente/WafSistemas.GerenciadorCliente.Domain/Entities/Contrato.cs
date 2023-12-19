using System;
using System.Collections.Generic;

namespace WafSistemas.GerenciadorCliente.Domain.Entities
{
    public class Contrato
    {
        public Guid IdCliente { get; set; }
        public long IdProjeto { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; } //0= Bloqueado 1=Liberado
        public DateTime Date { get; set; }

        //public virtual ICollection<Cliente> Clientes { get; set; }

        //public virtual ICollection<Permissao> Permissaos { get; set; }
    }
}
