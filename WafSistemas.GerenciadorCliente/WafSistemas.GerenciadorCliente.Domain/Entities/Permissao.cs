using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WafSistemas.GerenciadorCliente.Domain.Entities
{
    public class Permissao
    {
        public Guid IdCliente { get; set; }
        public long IdProjeto { get; set; }
        public long IdPermissao { get; set; } //{CodigoProjeto+AutoNumeracao}010000000001
        public string Nome { get; set; }
        public bool Liberado { get; set; }
        public long Quantidade { get; set; } //valor em dias
        public int Status { get; set; } //0= Bloqueado 1=Liberado

        //public virtual Projeto Projeto { get; set; }

        //public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
