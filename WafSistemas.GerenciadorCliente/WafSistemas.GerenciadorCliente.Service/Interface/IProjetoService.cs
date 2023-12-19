using WafSistemas.GerenciadorCliente.Service.DTO;
using WafSistemas.GerenciadorCliente.Service.DTO.Projeto;

namespace WafSistemas.GerenciadorCliente.Service.Interface
{
    public interface IProjetoService
    {
        string Inserir(InserirProjetoRequest request);
        string Alterar(AlterarProjetoRequest request);
        PesquisarResponse<Projeto> Pesquisar(long id);
        PesquisarResponse<Projeto> Listar();
        PesquisarResponse<Projeto> ListarAtivos();
    }
}
