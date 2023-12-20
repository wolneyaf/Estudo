using BNP.Teste.Dominio.Entities;
using System.Collections.Generic;

namespace BNP.Teste.Dominio.Repository.Entities
{
    public interface IMovimentoRepository : IBaseRepository<Movimentacao>
    {
        IEnumerable<MovimentoProcedure> ListarMovimentoProcedure();
        long GerarLancamento();
    }
}
