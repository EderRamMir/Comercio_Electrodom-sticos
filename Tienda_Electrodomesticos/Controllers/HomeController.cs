using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tienda_Electrodomesticos.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaEntities1 bd = new Models.TiendaEntities1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string id="")
        {
            //logica de bd
            var productos = bd.Producto.Where(x=>x.Denominacion.Contains(id)).Take(20).ToList();
            //devuelve una vista
            ViewBag.clave = id;
            return View(productos);
        }
    }
}