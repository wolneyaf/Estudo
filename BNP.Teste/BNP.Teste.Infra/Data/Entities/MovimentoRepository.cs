using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Teste.Infra.Data.Entities
{
    public class MovimentoRepository : BaseRepository<Movimentacao>, IMovimentoRepository
    {
        public readonly BnpContext Context;
        public MovimentoRepository(BnpContext contex):base(contex)
        {
            Context = contex;
        }

        public IEnumerable<MovimentoProcedure> ListarMovimentoProcedure()
        {
            IEnumerable<MovimentoProcedure> lista = (IEnumerable<MovimentoProcedure>)Context.MovimentoManual.FromSql($"");
            return lista;
        }

        public long GerarLancamento()
        {
            int Mes = DateTime.Now.Month;
            int Ano = DateTime.Now.Year;
            var list = Context.MovimentoManual.Where(x=> x.Mes == Mes && x.Ano == Ano);
            long NrLancamento = list.Count() + 1;

            return NrLancamento;
        }

    }
}
