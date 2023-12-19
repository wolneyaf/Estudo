using Microsoft.EntityFrameworkCore;
using System;

namespace WafSolucoes.Quiz.API.Domain.Entities
{
    [Keyless]
    public class Pesquisa
    {
        public decimal IdPesquisa { get; set; }
        public string IdCliente { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Validade { get; set; }
        public DateTime DataInc { get; set; }
        public DateTime DataAlt { get; set; }
    }
}
