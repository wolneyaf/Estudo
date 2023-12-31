﻿
using AutoMapper;
using BNP.Teste.Dominio.Entities;
using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Service.DTO;
using BNP.Teste.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace BNP.Teste.Service.Service
{
    public class MovimentoService : IMovimentoService
    {
        private readonly IProdutoRepository ServicoProduto;
        private readonly IMovimentoRepository Servico;
        public MovimentoService(IMovimentoRepository servico, IProdutoRepository servicoProduto)
        {
            Servico = servico;
            ServicoProduto = servicoProduto;
        }

        public string Inserir(MovimentoDto obj)
        {
            try
            {
                MovimentacaoManual objRepository = new MovimentacaoManual();
                objRepository.Ano = obj.Ano;
                objRepository.Mes = obj.Mes;
                objRepository.CodProduto = obj.CodProduto;
                objRepository.DataMovimentacao = DateTime.Now;
                objRepository.Descricao = obj.Descricao;
                var NumLancamento = Servico.GerarLancamento(obj.Mes, obj.Ano);
                objRepository.NumLancamento = NumLancamento;
                objRepository.CodCosif = obj.CodCosif;
                objRepository.Valor = obj.Valor;
                objRepository.CodUsuario = "Usuario";
                Servico.Inserir(objRepository);

                return "";
            }
            catch(Exception ex) 
            {
                return ex.ToString();
            }
        }

        public ListarMovimentoResponse ListarMovimento()
        {
            ListarMovimentoResponse response = new ListarMovimentoResponse();
            response.Movimentos = new List<ListaMovimentoDto>();
            response.Produtos = new List<ProdutoComboDto>();
            try
            {
                //Carrega produtos
                var listaProd = ServicoProduto.List();
                if (listaProd != null)
                {
                    foreach (var item in listaProd)
                    {
                        response.Produtos.Add(new ProdutoComboDto()
                        {
                            Codigo= item.CodProduto,
                            Descricao = item.Descricao
                        });
                    }
                }

                //var lista = Servico.List();


                //Carrega Movimentos
                var lista = Servico.ListarMovimentoProcedure();                
                if (lista != null)
                {
                    foreach (var item in lista)
                    {
                        response.Movimentos.Add(new ListaMovimentoDto()
                        {
                            Ano = item.DAT_ANO,
                            Mes = item.DAT_MES,
                            CodProduto = item.COD_PRODUTO,
                            Descricao = item.DES_DESCRICAO,
                            DescricaoProduto = item.DES_PRODUTO,
                            NumLancamento = item.NUM_LANCAMENTO,
                            Valor = item.VAL_VALOR
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
