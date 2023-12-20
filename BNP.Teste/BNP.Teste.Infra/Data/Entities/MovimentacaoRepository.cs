using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;

namespace BNP.Teste.Infra.Data.Entities
{
    public class MovimentacaoRepository : BaseRepository<Movimentacao>, IMovimentoRepository
    {
        public readonly BNPContext Context;
        public MovimentacaoRepository(BNPContext contex):base(contex)
        {

        }
    }
}
