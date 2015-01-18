using Rotas.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> _TodasNoticias;
        public HomeController()
        {
            _TodasNoticias = new Noticia().lstNoticias().OrderByDescending(c => c.Data);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = _TodasNoticias.Take(5).ToList();
            var categorias = _TodasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = categorias;

            return View(ultimasNoticias);
        }
       
        public ActionResult TodasNoticias()
        {
            return View(_TodasNoticias);
        }

        public ActionResult MostraNoticia(int NoticiaID, string Categoria)
        {
            var result = _TodasNoticias.Where(c => c.NoticiaID == NoticiaID).Single();
            ViewBag.Noticia = string.Format("{0} - {1}", Categoria.ToString(), result.Titulo.ToString());

            return View(result);
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var result = _TodasNoticias.Where(c => c.Categoria == categoria).ToList();

            return View(result);
        }
    }
}