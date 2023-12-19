using System;
using System.Collections.Generic;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Domain.Repository.Entities
{
    public interface IPerguntaRepository: IBaseRepository<Pergunta>
    {
        Pergunta Pesquisar(long idPesquisa, string idCliente, long idPergunta);
        IEnumerable<Pergunta> Listar(string idCliente, long idPesquisa);
    }
}
