﻿using System;

namespace WafSolucoes.Quiz.API.Domain.Entities
{
    public class Questao
    {
        public string IdCliente { get; set; }
        public long IdPesquisa { get; set; }
        public long IdPergunta { get; set; }
        public long IdQuestao { get; set; }
        public bool Objetiva { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInc { get; set; }
        public DateTime DataAlt { get; set; }
    }
}
