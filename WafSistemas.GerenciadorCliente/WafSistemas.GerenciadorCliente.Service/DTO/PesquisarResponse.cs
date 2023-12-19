using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WafSistemas.GerenciadorCliente.Service.DTO
{
    public class PesquisarResponse<T>
    {
        public T Objeto { get; set; }
        public List<T> Lista { get; set; }
        public string Return { get; set; }
    }
}
