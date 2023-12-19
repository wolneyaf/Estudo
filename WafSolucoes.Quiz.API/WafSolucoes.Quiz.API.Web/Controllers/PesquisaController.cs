using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WafSolucoes.Quiz.API.Service.Interface;

namespace WafSolucoes.Quiz.API.Web.Controllers
{
    public class PesquisaController : Controller
    {
        private readonly Service.Interface.IPesquisaService _PesquisaService;
        private readonly IMapper Mapper;
        private readonly ILogger<PesquisaController> Logger;

        public PesquisaController(ILogger<PesquisaController> logger, Service.Interface.IPesquisaService pesquisaService, IMapper mapper)
        {
            _PesquisaService = pesquisaService;
            Logger = logger;
            Mapper = mapper;
        }

        // GET: PesquisaController
        public ActionResult Index()
        {
            var response = _PesquisaService.Listar(1);
            return View(response.Lista);
        }

        // GET: PesquisaController/Details/5
        public ActionResult Details(int id)
        {
            var response = _PesquisaService.Pesquisar(1, id);
            return View(response.Lista);
        }

        // GET: PesquisaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PesquisaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PesquisaController/Edit/5
        public ActionResult Edit(int id)
        {
            var response = _PesquisaService.Pesquisar(1, id);
            return View(response.Lista);
        }

        // POST: PesquisaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PesquisaController/Delete/5
        public ActionResult Delete(int id)
        {
            var response = _PesquisaService.Pesquisar(1, id);
            return View(response.Lista);
        }

        // POST: PesquisaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
