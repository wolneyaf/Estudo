namespace WafSistemas.GerenciadorCliente.Service.DTO.Projeto
{
    public class AlterarProjetoRequest
    {
        public long IdProjeto { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; } //0= Bloqueado 1=Liberado
    }
}
