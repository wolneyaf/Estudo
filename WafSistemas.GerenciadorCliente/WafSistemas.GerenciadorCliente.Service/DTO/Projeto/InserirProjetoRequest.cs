namespace WafSistemas.GerenciadorCliente.Service.DTO.Projeto
{
    public class InserirProjetoRequest
    {        
        public string Nome { get; set; }
        public int Status { get; set; } //0= Bloqueado 1=Liberado
    }
}
