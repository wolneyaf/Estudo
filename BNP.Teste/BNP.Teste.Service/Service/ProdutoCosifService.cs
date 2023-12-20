using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Service.DTO;
using BNP.Teste.Service.Interface;
using System;
using System.Collections.Generic;

namespace BNP.Teste.Service.Service
{
    public class ProdutoCosifService : IProdutoCosifService
    {
        private readonly IProdutoCosifRepository Server;
        public ProdutoCosifService(IProdutoCosifRepository server)
        {
            Server = server;
        }

        public List<ProdutoCosifComboDto> BuscarDadosParaCombo(string codigoProduto)
        {
            List<ProdutoCosifComboDto> response = new List<ProdutoCosifComboDto>();
            try
            {
                var Lista = Server.PesquisaProdutoCosifPorCodigo(codigoProduto);
                if(Lista != null)
                {
                    foreach(var item in Lista)
                    {
                        response.Add(new ProdutoCosifComboDto()
                        {
                            CodigoClassificacao = item.CodClassificacao,
                            CodigoCosif = item.CodCosif,
                            Item = item.CodCosif + "-" + item.CodClassificacao
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                response = new List<ProdutoCosifComboDto>();
            }

            return response;
        }
    }
}
