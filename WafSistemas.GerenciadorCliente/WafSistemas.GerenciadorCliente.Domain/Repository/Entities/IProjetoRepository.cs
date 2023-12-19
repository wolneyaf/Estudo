using System.Collections.Generic;
using WafSistemas.GerenciadorCliente.Domain.Entities;

namespace WafSistemas.GerenciadorCliente.Domain.Repository.Entities
{
    public interface IProjetoRepository : IBaseRepository<Projeto>
    {
        Projeto Pesquisar(long id);
        IEnumerable<Projeto> Listar();
        IEnumerable<Projeto> ListarAtivos();
    }
}
