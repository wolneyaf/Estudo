using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WafSistemas.GerenciadorCliente.Domain.Repository.Entities;
using WafSistemas.GerenciadorCliente.Service.DTO;
using WafSistemas.GerenciadorCliente.Service.DTO.Projeto;
using WafSistemas.GerenciadorCliente.Service.Interface;

namespace WafSistemas.GerenciadorCliente.Service.Service
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository ProjetoRepository;
        private readonly IMapper Mapper;
        private readonly ILogger<ProjetoService> Logger;

        //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        public ProjetoService(IProjetoRepository projetoRepository, IMapper mapper, ILogger<ProjetoService> logger)
        {
            ProjetoRepository = projetoRepository;
            Mapper = mapper;
            Logger = logger;
        }

        public string Alterar(AlterarProjetoRequest request)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Projeto ProjetoEntity = new Domain.Entities.Projeto();
                ProjetoEntity = Mapper.Map<Domain.Entities.Projeto>(request);
                ProjetoRepository.Alterar(ProjetoEntity);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response = "{ isSucesso: 'true'}";

                return Response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }
        }

        public string Inserir(InserirProjetoRequest request)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Projeto ProjetoEntity = new Domain.Entities.Projeto();
                ProjetoEntity = Mapper.Map<Domain.Entities.Projeto>(request);
                ProjetoRepository.Inserir(ProjetoEntity);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response = "{ isSucesso: 'true'}";

                return Response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }
        }

        public PesquisarResponse<Projeto> Listar()
        {
            PesquisarResponse<Projeto> Response = new PesquisarResponse<Projeto>();

            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                var Projeto = ProjetoRepository.Listar().ToList();
                Response.Lista = Mapper.Map<List<Projeto>>(Projeto);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response.Return = "{ isSucesso: 'true'}";

                return Response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response.Return = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }
        }

        public PesquisarResponse<Projeto> ListarAtivos()
        {
            PesquisarResponse<Projeto> Response = new PesquisarResponse<Projeto>();

            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                var clientes = ProjetoRepository.ListarAtivos().ToList();
                Response.Lista = Mapper.Map<List<Projeto>>(clientes);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response.Return = "{ isSucesso: 'true'}";

                return Response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response.Return = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }
        }

        public PesquisarResponse<Projeto> Pesquisar(long id)
        {
            PesquisarResponse<Projeto> Response = new PesquisarResponse<Projeto>();
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Projeto ProjetoEntity = new Domain.Entities.Projeto();
                ProjetoEntity = ProjetoRepository.Pesquisar(id);
                if (ProjetoEntity == null)
                {
                    Response.Return = "{ isSucesso: 'true'," +
                        "'msg': 'Cliente não encontrado.'}";
                    return Response;
                }

                Response.Objeto = Mapper.Map<Projeto>(ProjetoEntity);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response.Return = "{ isSucesso: true}";

                return Response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Response.Return = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }
        }
    }
}
