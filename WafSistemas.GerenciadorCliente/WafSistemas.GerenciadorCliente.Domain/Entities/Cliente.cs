using System;
using System.Collections.Generic;

namespace WafSistemas.GerenciadorCliente.Domain.Entities
{
    public class Cliente
    {
        public string IdCliente { get; set; }       // => Cadastro Adm
        public string Nome { get; set; }          // => Cadastro Adm
        public DateTime DataCriacao { get; set; } // => Cadastro Adm
        public string CPFCnpj { get; set; }
        public string Email { get; set; }         // => Cadastro Adm
        public string Login { get; set; }         // => Cadastro Adm
        public string Senha { get; set; }
        public DateTime DataAlteracao { get; set; }
        public short Status { get; set; }           //0= bloqueado 1= Liberadado 2= Pendente 3= Inadiplemte 4= Cortesia 5= Vip 6= Teste
        public DateTime? DataLiberação { get; set; }

        //public virtual ICollection<Contrato> Contratos { get; set; }

        //public virtual ICollection<Permissao> Permissaos { get; set; }
    }
}

