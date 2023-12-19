using System;
using System.Collections.Generic;
using System.Text;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Domain.Repository.Entities
{
    public interface IRespostaRepository: IBaseRepository<Resposta>
    {
        Resposta Pesquisar(string idCliente, long idPesquisa, long idPergunta, long idQuestao, long idQuestionario);
        IEnumerable<Resposta> Listar(string idCliente, long idPesquisa, long idPergunta, long idQuestionario);
        IEnumerable<Resposta> Listar();
    }
}
