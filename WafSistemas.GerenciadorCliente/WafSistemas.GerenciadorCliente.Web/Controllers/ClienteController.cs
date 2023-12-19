using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafSistemas.GerenciadorCliente.Service.DTO;

namespace WafSistemas.GerenciadorCliente.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Service.Interface.IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, Service.Interface.IClienteService clienteService)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var response = _clienteService.Listar();
            return View(response.Lista);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(string id)
        {
            var response = _clienteService.Pesquisar(id);
            return View(response.Objeto);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if (collection.Count > 0)
                {
                    InserirClienteRequest obj = new InserirClienteRequest();
                    obj.Email = collection["Email"];
                    obj.Nome = collection["Nome"];
                    obj.CPFCnpj = collection["CPFCnpj"];
                    obj.Request = Request.Scheme+"://" + Request.Host.Value + "/Cliente/ConfirmacaoCadastro?token={0}";

                    var response = _clienteService.Inserir(obj);

                    string Body = System.Web.HttpUtility.HtmlDecode(response);


                    var html = Body;
                    Response.WriteAsync(html);
                    return View();
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(string id)
        {
            var objModel = _clienteService.Pesquisar(id);
            return View(objModel.Objeto);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                if (collection.Count > 0)
                {
                    AlterarClienteRequest obj = new AlterarClienteRequest();
                    obj.Email = collection["Email"];
                    obj.Nome = collection["Nome"];
                    obj.CPF = collection["CPFCnpj"];
                    obj.Status = Convert.ToInt16(collection["ckStatus"]);
                    obj.IdCliente = id;

                    var response = _clienteService.Alterar(obj);

                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
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

        [HttpGet]
        public ActionResult ConfirmacaoCadastro(string token)
        {
            ConfirmarInclusaoResponse obj = _clienteService.ConfirmadInsert(token);
            if (obj.IsSucess)
                return View(obj.Obj);
            else
                return View("Retorno",  obj.IsSucess );
        }


        public ActionResult AtualizaConfirmacaoCadastro(ConfirmarInclusaoRequest obj)
        {
            _clienteService.ConfirmarInclusao(obj);
            return View("Retorno", true );
        }

        public void ViewEmail()
        {
            string HTML ="";
            Response.WriteAsync(HTML);
        }
    }
}
