using System;
using System.Collections.Generic;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Domain.Repository.Entities
{
    public interface IPesquisaRepository: IBaseRepository<Pesquisa>
    {
        Pesquisa Pesquisar(long idPesquisa, string idCliente);
        IEnumerable<Pesquisa> Listar(string idCliente);
        IEnumerable<Pesquisa> Listar();
    }
}
