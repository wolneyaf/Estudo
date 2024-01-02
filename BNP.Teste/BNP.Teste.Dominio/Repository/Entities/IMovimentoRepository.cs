using BNP.Teste.Dominio.Entities;
using System.Collections.Generic;

namespace BNP.Teste.Dominio.Repository.Entities
{
    public interface IMovimentoRepository : IBaseRepository<MovimentacaoManual>
    {
        IEnumerable<MovimentoProcedure> ListarMovimentoProcedure();
        long GerarLancamento(int mes, int ano);
    }
}
