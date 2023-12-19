using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WafSistemas.GerenciadorCliente.Domain.Repository.Entities;
using WafSistemas.GerenciadorCliente.Service.DTO;
using WafSistemas.GerenciadorCliente.Service.Interface;
using WafSistemas.GerenciadorCliente.Util;
using WafSistemas.GerenciadorCliente.Util.Enums;

namespace WafSistemas.GerenciadorCliente.Service.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository ClienteRepository;
        private readonly IMapper Mapper;
        private readonly ILogger<ClienteService> Logger;


        public ClienteService(IClienteRepository clienteRepository,  IMapper mapper, ILogger<ClienteService> logger)
        {
            ClienteRepository = clienteRepository;
            Mapper = mapper;
            Logger = logger;
        }

        public string Alterar(AlterarClienteRequest cliente)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Cliente ClienteEntity = ClienteRepository.Pesquisar(cliente.IdCliente);
                if (ClienteEntity != null)
                {
                    int StatusAnt = ClienteEntity.Status;

                    ClienteEntity.Nome = cliente.Nome;
                    ClienteEntity.CPFCnpj = cliente.CPF;
                    ClienteEntity.Email = cliente.Email;
                    ClienteEntity.Status = cliente.Status;

                    if (StatusAnt != cliente.Status)
                        ClienteEntity.DataLiberação = DateTime.Now;
                    else if (cliente.Status == 9)
                        ClienteEntity.DataLiberação = null;

                    ClienteEntity.DataAlteracao = DateTime.Now;
                    ClienteRepository.Alterar(ClienteEntity);

                    Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                    Response = "{ isSucesso: 'true'}";
                }
                else
                {
                    Logger.LogError("Cliente não encontrado.");
                    Response = "{ 'isSucesso': 'false'," +
                        "'msg': 'Erro inesperado consulte suporte.'," +
                        "'msgException':'Cliente não encontrado.'}";
                }

                return Response;
            }
            catch(Exception ex)
            {
                Logger.LogError(ex.Message);
                Response = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                return Response;
            }

        }

        public string AlterarStatus(AlterarStatusRequest cliente)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Cliente ClienteEntity = new Domain.Entities.Cliente();
                ClienteEntity = ClienteRepository.Pesquisar(cliente.IdCliente);
                if(ClienteEntity==null)
                {
                    Response = "{ isSucesso: 'true'," +
                        "'msg': 'Cliente não encontrado.'}";
                    return Response;
                }
                    
                ClienteEntity.Status = cliente.Status;
                ClienteEntity.DataAlteracao = DateTime.Now;

                ClienteRepository.Alterar(ClienteEntity);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response = "{ isSucesso: true}";

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

        public bool ClienteCadastrado(ClienteCadastradoRequest cliente)
        {
            
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Cliente ClienteEntity = new Domain.Entities.Cliente();
                ClienteEntity = ClienteRepository.ExistCliente(cliente.Email, cliente.CPFCnpj);

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                if (ClienteEntity == null)
                    return false;
                else
                    return true;
                
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                return true;
            }
                
            
        }

        public string ConfirmarInclusao(ConfirmarInclusaoRequest cliente)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Cliente ClienteEntity = ClienteRepository.Pesquisar(cliente.IdCliente);
                if (ClienteEntity != null)
                {
                    ClienteEntity.Status = Convert.ToInt16(StatusCliente.Liberadado);
                    ClienteEntity.Senha = Function.EncodePassword(cliente.Senha);
                    ClienteEntity.DataAlteracao = DateTime.Now;
                    ClienteEntity.DataLiberação = DateTime.Now;
                    ClienteRepository.Alterar(ClienteEntity);
                    
                    Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                    Response = "{ isSucesso: 'true'}";
                }
                else
                {
                    Response = "{ isSucesso: 'false'}" +
                        "'msg':'Cliente não encontrado.'";
                }

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

        public string Inserir(InserirClienteRequest cliente)
        {
            string Response = "";
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                //Inserir Cliente
                Domain.Entities.Cliente ClienteEntity = new Domain.Entities.Cliente();
                ClienteEntity.Nome = cliente.Nome.ToUpper();
                ClienteEntity.CPFCnpj = cliente.CPFCnpj;
                ClienteEntity.Email = cliente.Email.ToLower();
                ClienteEntity.Login = Function.ReturnHexa(CountCliente());
                ClienteEntity.IdCliente = Function.GenerateGuid();
                ClienteEntity.DataCriacao = DateTime.Now;
                ClienteEntity.DataAlteracao = DateTime.Now;
                ClienteEntity.Status = Convert.ToInt16(StatusCliente.Cadastro);
                
                ClienteRepository.Inserir(ClienteEntity);

                //Envia email de confirmação
                SendClienteRequest ClienteSend = new SendClienteRequest();
                ClienteSend.CPF = ClienteEntity.CPFCnpj;
                ClienteSend.Nome = ClienteEntity.Nome;
                ClienteSend.DataCriacao = ClienteEntity.DataCriacao;
                ClienteSend.Email = ClienteEntity.Email;
                ClienteSend.Login = ClienteEntity.Login;
                ClienteSend.IdCliente = ClienteEntity.IdCliente;
                ClienteSend.Request = cliente.Request;
                var retorno = SendEmail(ClienteSend);

                Response = retorno;
                return Response;

                var Objretorno = JsonConvert.DeserializeObject<ObjectResponse>(retorno);              
                if (!Objretorno.isSucesso)
                    throw new Exception(Objretorno.msgException);

                //Alterar Status
                retorno = AlterarStatus(new AlterarStatusRequest() { Status = Convert.ToInt16(StatusCliente.Pendente), IdCliente = ClienteSend.IdCliente });
                Objretorno = JsonConvert.DeserializeObject<ObjectResponse>(retorno);
                if (!Objretorno.isSucesso)
                    throw new Exception(Objretorno.msgException);

                Response = "{ isSucesso: 'true'}";

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

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

        private int CountCliente()
        {
            try
            {
                var response = Listar();
                return response.Lista.Count;
            }
            catch
            {
                return 0;
            }
        }

        public PesquisarResponse<Cliente> Listar()
        {
            PesquisarResponse<Cliente> Response = new PesquisarResponse<Cliente>();

            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                var clientes = ClienteRepository.Pesquisar(x=> x.IdCliente == x.IdCliente).ToList();
                Response.Lista = Mapper.Map<List<Cliente>>(clientes);               

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

        public PesquisarResponse<Cliente> Pesquisar(string idCliente)
        {
            PesquisarResponse<Cliente> Response = new PesquisarResponse<Cliente>();
            try
            {
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Domain.Entities.Cliente ClienteEntity = new Domain.Entities.Cliente();
                ClienteEntity = ClienteRepository.Pesquisar(idCliente);
                if (ClienteEntity == null)
                {
                    Response.Return = "{ isSucesso: 'true'," +
                        "'msg': 'Cliente não encontrado.'}";
                    return Response;
                }

                Response.Objeto = Mapper.Map<Cliente>(ClienteEntity);

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

        public string SendEmail(SendClienteRequest cliente)
        {
            string Response = "";
            ObjectResponse ObjBody = new ObjectResponse();
            try
            {
                string Assunto = "EMAIL DE CONFIRMAÇÃO DO CADASTRO";
                Logger.LogInformation("Inicio do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Util.Email.SendEmail Send = new Util.Email.SendEmail();

                //Monta Corpo do Email
                var Body = Send.GetModelo(Util.Enums.ModeloEmail.ConfirmarCadastro);
                string documento = cliente.CPF.Substring(0, 3) + "".PadLeft(cliente.CPF.Length-5,'*') + cliente.CPF.Substring(cliente.CPF.Length-2,2);
                 ObjBody = JsonConvert.DeserializeObject<ObjectResponse>(Body);                
                if (!ObjBody.isSucesso)                
                    throw new Exception(ObjBody.msgException);


                string chave = Security.JWT.JwtSecurity.GenerateTokenConfirmad(cliente.IdCliente.ToString(), cliente.Login, cliente.Email);
                var token64 = Encoding.ASCII.GetBytes(chave);
                string link = cliente.Request.Replace("{0}", Convert.ToBase64String(token64));
                ObjBody.file = ObjBody.file.Replace("{0}", cliente.Login).Replace("{1}", cliente.Nome).Replace("{2}", cliente.Email).Replace("{3}", documento).Replace("{4}", link);
                //Destinatario
                Dictionary<string, string> Destino = new Dictionary<string, string>();
                Destino.Add(cliente.Email, cliente.Nome);

                //Envia Email
                var retorno = Send.Send(destinos: Destino, body: ObjBody.file, assunto: Assunto);
                var ObjRetorno = JsonConvert.DeserializeObject<ObjectResponse>(retorno);
                if (!ObjRetorno.isSucesso)
                {
                    throw new Exception(ObjBody.msgException);
                }

                Logger.LogInformation("Fim do Método: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                Response = "{ 'isSucesso': 'true'}";
            }
            catch(Exception ex)
            {
                Logger.LogError(ex.Message);
                Response = System.Web.HttpUtility.HtmlEncode(ObjBody.file);
                    //"{ 'isSucesso': 'false'," +
                    //"'msg': 'Erro inesperado consulte suporte.'," +
                    //"'msgException':'" + ex.Message + "'," +
                    //"'StackTrace': '" + ex.StackTrace + "}";
            }

            return Response;
        }

        public ConfirmarInclusaoResponse ConfirmadInsert(string token)
        {
            try
            {
                var Token64 = Convert.FromBase64String(token);
                var Token = Encoding.ASCII.GetString(Token64);

                if (Security.JWT.JwtSecurity.ValidateToken(Token))
                {                    
                    var claims = Security.JWT.JwtSecurity.DecodeToken(Token);
                    string login = "";
                    string email = "";
                    string idCliente = "";

                    foreach (Claim claim in claims)
                    {
                        switch (claim.Type) {
                            case "certserialnumber":
                                idCliente = claim.Value;
                                break;
                            case "email":
                                email = claim.Value;
                                break;
                            case "unique_name":
                                login = claim.Value;
                                break;
                        }
                    }

                    var obj = new ConfirmarInclusaoRequest() {IdCliente = idCliente, Login = login, Email = email };


                    return new ConfirmarInclusaoResponse() { IsSucess = true, Obj = obj };
                }
                else
                    return new ConfirmarInclusaoResponse() { IsSucess = false };
            }
            catch
            {
                return new ConfirmarInclusaoResponse() { IsSucess = false };
            }

        }
    }
}
