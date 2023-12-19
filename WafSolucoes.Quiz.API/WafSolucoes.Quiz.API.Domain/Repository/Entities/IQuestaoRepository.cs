using System;
using System.Collections.Generic;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Domain.Repository.Entities
{
    public interface IQuestaoRepository: IBaseRepository<Questao>
    {
        Questao Pesquisar(long idPesquisa, string idCliente, long idPergunta, long idQuestao);
        IEnumerable<Questao> Listar(string idCliente, long idPesquisa, long idPergunta);
    }
}
