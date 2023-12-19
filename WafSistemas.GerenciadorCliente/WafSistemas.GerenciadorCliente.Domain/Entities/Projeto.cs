
namespace WafSistemas.GerenciadorCliente.Domain.Entities
{
    public class Projeto
    {
        public decimal IdProjeto { get; set; }
        public string Nome { get; set; }
        public short Status { get; set; } //0= Bloqueado 1=Liberado

        //public virtual ICollection<Contrato> Contratos { get; set; }

    }
}
