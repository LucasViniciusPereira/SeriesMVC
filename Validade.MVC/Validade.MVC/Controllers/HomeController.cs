using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validade.MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace Validade.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pessoa pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult VerificaEmail(string email)
        {
            var BancoT = new string[] { "teste@gmail.com", "lucas@gmail.com", "teste@teste.com"};

           return Json(BancoT.All(x=> x.ToLower() != email.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}