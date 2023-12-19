using System.Collections.Generic;

namespace WafSolucoes.Quiz.API.Service.DTO
{
    public class PesquisarResponse<T>
    {
        public T Objeto { get; set; }
        public List<T> Lista { get; set; }
        public string Return { get; set; }
    }
}
