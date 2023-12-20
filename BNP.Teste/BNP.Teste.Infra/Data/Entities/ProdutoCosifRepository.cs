using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.Teste.Infra.Data.Entities
{
    public class ProdutoCosifRepository : BaseRepository<ProdutoCosif>, IProdutoCosifRepository
    {
        public readonly BNPContext Context;
        public ProdutoCosifRepository(BNPContext context) : base(context)
        {
            Context = context;
        }

    }
}
