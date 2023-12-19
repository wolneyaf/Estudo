using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafSistemas.GerenciadorCliente.Service.DTO;

namespace WafSistemas.GerenciadorCliente.Service.Interface
{
    public interface IClienteService
    {
        string Inserir(InserirClienteRequest cliente);
        string SendEmail(SendClienteRequest cliente);
        string ConfirmarInclusao(ConfirmarInclusaoRequest cliente);
        string AlterarStatus(AlterarStatusRequest cliente);
        string Alterar(AlterarClienteRequest cliente);
        bool ClienteCadastrado(ClienteCadastradoRequest cliente);
        PesquisarResponse<Cliente> Pesquisar(string idCliente);
        PesquisarResponse<Cliente> Listar();

        ConfirmarInclusaoResponse ConfirmadInsert(string token);
    }
}
