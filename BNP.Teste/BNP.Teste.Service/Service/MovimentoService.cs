using BNP.Teste.Infra.Data.Entities;
using BNP.Teste.Service.DTO;
using BNP.Teste.Service.Interface;
using System;
using System.Collections.Generic;

namespace BNP.Teste.Service.Service
{
    public class MovimentoService : IMovimentoService
    {
        private readonly MovimentoRepository Servico;
        public MovimentoService(MovimentoRepository servico)
        {
            Servico = servico;
        }

        public ListarMovimentoResponse ListarMovimento()
        {
            ListarMovimentoResponse response = new ListarMovimentoResponse();
            response.Movimentos = new List<ListaMovimentoDto>();
            try
            {
                var lista = Servico.ListarMovimentoProcedure();
                if(lista != null)
                {
                    foreach(var item in lista)
                    {
                        response.Movimentos.Add(new ListaMovimentoDto() 
                        { 
                            Ano = item.Ano,
                            Mes = item.Mes,
                            CodProduto = item.CodProduto,
                            Descricao = item.Descricao,
                            DescricaoProduto = item.DescricaoProduto,
                            NumLancamento = item.NumLancamento,
                            Valor = item.Valor
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                response = new ListarMovimentoResponse();
            }

            return response;
        }
    }
}
