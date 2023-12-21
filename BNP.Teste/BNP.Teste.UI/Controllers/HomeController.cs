using BNP.Teste.Service.Interface;
using BNP.Teste.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BNP.Teste.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovimentoService ServiceMovimento;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMovimentoService serviceMovimento)
        {
            _logger = logger;
            ServiceMovimento = serviceMovimento;
        }

        public IActionResult Index()
        {
            var objResponse = ServiceMovimento.ListarMovimento();
            return View(objResponse);
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
