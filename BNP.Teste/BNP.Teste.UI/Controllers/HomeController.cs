using BNP.Teste.Service.DTO;
using BNP.Teste.Service.Interface;
using BNP.Teste.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BNP.Teste.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovimentoService ServiceMovimento;
        private readonly IProdutoCosifService ServiceProdutoCosifService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMovimentoService serviceMovimento, IProdutoCosifService serviceProdutoCosifService)
        {
            _logger = logger;
            ServiceMovimento = serviceMovimento;
            ServiceProdutoCosifService = serviceProdutoCosifService;
        }

        public IActionResult Index()
        {
            var objResponse = ServiceMovimento.ListarMovimento();
            return View(objResponse);
        }

        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if (collection.Count > 0)
                {
                    MovimentoDto obj = new MovimentoDto();
                    obj.Ano = Convert.ToInt32(collection["Movimento.Ano"]);
                    obj.Mes = Convert.ToInt32(collection["Movimento.Mes"]);
                    obj.CodProduto = collection["Movimento.CodProduto"];
                    obj.CodCosif = collection["Movimento.CodCosif"];
                    obj.Descricao = collection["Movimento.Descricao"];
                    string valor = collection["Movimento.Valor"];
                    obj.Valor = Convert.ToDecimal(valor.Replace(".",","));

                    var ret = ServiceMovimento.Inserir(obj);     

                }
            }
            catch
            {
                return View();
            }

            return RedirectToAction(nameof(Index));
            
        }

        public string BuscaProdutoCosif(string Codigo)
        {
            var objResponse = ServiceProdutoCosifService.BuscarDadosParaCombo(Codigo);
            return JsonConvert.SerializeObject(objResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
