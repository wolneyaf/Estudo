using WafSolucoes.Quiz.API.Service.DTO;
using WafSolucoes.Quiz.API.Service.DTO.Pesquisa;

namespace WafSolucoes.Quiz.API.Service.Interface
{
    public interface IPesquisaService
    {
        string Inserir(InserirPesquisaRequest request);
        string Alterar(AlterarPesquisaRequest request);
        PesquisarResponse<Pesquisa> Listar(long idCliente);
        PesquisarResponse<Pesquisa> Pesquisar(long idCliente, long id);
    }
}
