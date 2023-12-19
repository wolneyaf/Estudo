
namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class ObjectResponse
    {
        public bool isSucesso { get; set; }
        public string msg { get; set; }
        public string msgException { get; set; }
        public string StackTrace { get; set; }
        public string file { get; set; }
    }
}
