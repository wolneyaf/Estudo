using System;
using System.Collections.Generic;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Domain.Repository.Entities
{
    public interface IQuestionarioRepository: IBaseRepository<Questionario>
    {
        Questionario Pesquisar(string idCliente, long idQuestionario);
        IEnumerable<Questionario> Listar(string idCliente);
    }
}
