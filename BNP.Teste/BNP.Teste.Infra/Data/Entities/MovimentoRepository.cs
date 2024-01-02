using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Teste.Infra.Data.Entities
{
    public class MovimentoRepository : BaseRepository<MovimentacaoManual>, IMovimentoRepository
    {
        public readonly BnpContext Context;
        public MovimentoRepository(BnpContext context):base(context)
        {
            Context = context;
        }

        public IEnumerable<MovimentoProcedure> ListarMovimentoProcedure()
        {

            
            FormattableString query = $"EXECUTE ListarMovimento";
            var lista = Context.MovimentoProcedure.FromSql(query);

            return lista;
        }

        public long GerarLancamento(int mes, int ano)
        {
            var list = Context.MovimentoManual.Where(x=> x.Mes == mes && x.Ano == ano);
            long NrLancamento = list.Count() + 1;

            return NrLancamento;
        }

    }
}
