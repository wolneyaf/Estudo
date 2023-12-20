using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Service.DTO;
using BNP.Teste.Service.Interface;
using System;
using System.Collections.Generic;

namespace BNP.Teste.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository Server;
        public ProdutoService(IProdutoRepository server)
        {
            Server = server;
        }

        public List<ProdutoComboDto> ListarCombo()
        {
            List<ProdutoComboDto> response = new List<ProdutoComboDto>();
            try
            {
                var Lista = Server.List();
                if (Lista != null)
                {
                    foreach (var item in Lista)
                    {
                        response.Add(new ProdutoComboDto() 
                        { 
                        Codigo = item.CodProduto,
                        Descricao = item.Descricao
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                response = new List<ProdutoComboDto>();
            }
            return response;
        }
    }
}
