using System;

namespace WafSolucoes.Quiz.API.Domain.Entities
{
    public class Questionario
    {
        public string IdCliente { get; set; }
        public long IdQuestionario { get; set; }
        public char Sexo { get; set; } // M = Masculino // F = Feminino // G = LGBTQI+
        public int Religiao { get; set; } // 0 = Ateu // 1= Catolico // 2= Evangelico // 3= outros
        public int Idade { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public long Aplicativo { get; set; }
        public DateTime DataInc { get; set; }
        public DateTime DataAlt { get; set; }
    }
}
