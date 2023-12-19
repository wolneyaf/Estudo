using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafSistemas.GerenciadorCliente.Domain.Entities;
using WafSistemas.GerenciadorCliente.Domain.Repository.Entities;
using WafSistemas.GerenciadorCliente.Infra.Repository.Context;

namespace WafSistemas.GerenciadorCliente.Infra.Repository.Data.Entities
{
    public class ClienteRepository: BaseRepository<Cliente>, IClienteRepository
    {

        private readonly GerenciadorContext Context;
        public ClienteRepository(GerenciadorContext context) : base(context)
        {
            Context = context;
        }

        public Cliente ExistCliente(string email, string CpfCnpj)
        {
            var Item = Context.Set<Cliente>().FirstOrDefault(x => x.Email == email && x.CPFCnpj== CpfCnpj);
            return Item;
        }

        public Cliente Pesquisar(string IdCliente)
        {
            var Item = Context.Set<Cliente>().FirstOrDefault(x=> x.IdCliente == IdCliente);
            return Item;
        }
    }
}
