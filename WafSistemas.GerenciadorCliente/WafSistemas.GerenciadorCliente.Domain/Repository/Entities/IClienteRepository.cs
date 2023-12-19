using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafSistemas.GerenciadorCliente.Domain.Entities;

namespace WafSistemas.GerenciadorCliente.Domain.Repository.Entities
{
    public interface IClienteRepository : IBaseRepository<Cliente> 
    {
        Cliente Pesquisar(string IdCliente);
        Cliente ExistCliente(string email, string CpfCnpj);
    }
}
