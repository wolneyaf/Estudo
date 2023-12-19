using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WafSistemas.GerenciadorCliente.Service.DTO.Projeto;

namespace WafSistemas.GerenciadorCliente.Web.Controllers
{
    public class ProjetoController : Controller
    {
        private readonly Service.Interface.IProjetoService _projetoService;
        private readonly ILogger<ProjetoController> _logger;

        public ProjetoController(ILogger<ProjetoController> logger, Service.Interface.IProjetoService projetoService)
        {
            _projetoService = projetoService;
            _logger = logger;
        }

        // GET: ProjetoController
        public ActionResult Index()
        {
            var Response = _projetoService.Listar();
            return View(Response.Lista);
        }

        // GET: ProjetoController/Details/5
        public ActionResult Details(int id)
        {
            var response = _projetoService.Pesquisar(id);
            return View(response.Objeto);
        }

        // GET: ProjetoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjetoController/Create
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

        // GET: ProjetoController/Edit/5
        public ActionResult Edit(int id)
        {
            var response = _projetoService.Pesquisar(id);
            return View(response.Objeto);
        }

        // POST: ProjetoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (collection.Count > 0)
                {
                    AlterarProjetoRequest obj = new AlterarProjetoRequest();
                    
                    obj.Nome = collection["Nome"];
                    obj.Status = Convert.ToInt16(collection["ckStatus"]);
                    obj.IdProjeto = id;

                    var response = _projetoService.Alterar(obj);

                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjetoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjetoController/Delete/5
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
