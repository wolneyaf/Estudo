using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Service.DTO;
using WafSolucoes.Quiz.API.Service.DTO.Pesquisa;
using WafSolucoes.Quiz.API.Service.Interface;

namespace WafSolucoes.Quiz.API.Service.Service
{
    public class PesquisaService : IPesquisaService
    {
        private readonly IPesquisaRepository _PesquisaRepository;
        private readonly IMapper Mapper;
        private readonly ILogger<PesquisaService> Logger;

        public PesquisaService(IPesquisaRepository pesquisaRepository, IMapper mapper, ILogger<PesquisaService> logger)
        {
            _PesquisaRepository = pesquisaRepository;
            Mapper = mapper;
            Logger = logger;
        }

        public string Alterar(AlterarPesquisaRequest request)
        {
            throw new System.NotImplementedException();
        }

        public string Inserir(InserirPesquisaRequest request)
        {
            throw new System.NotImplementedException();
        }

        public PesquisarResponse<Pesquisa> Listar(long idCliente)
        {
            PesquisarResponse<Pesquisa> Response = new PesquisarResponse<Pesquisa>();

            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                var PesquisaObj = _PesquisaRepository.Listar().ToList();
                Response.Lista = Mapper.Map<List<Pesquisa>>(PesquisaObj);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response.Return = "{ isSucesso: 'true'}";
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response.Return = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";
            }

            return Response;
        }

        public PesquisarResponse<Pesquisa> Pesquisar(long idCliente, long id)
        {
            PesquisarResponse<Pesquisa> Response = new PesquisarResponse<Pesquisa>();

            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                var PesquisaObj = _PesquisaRepository.Pesquisar(1,"1");
                Response.Objeto = Mapper.Map<Pesquisa>(PesquisaObj);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response.Return = "{ isSucesso: 'true'}";
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response.Return = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";
            }

            return Response;
        }
    }
}
