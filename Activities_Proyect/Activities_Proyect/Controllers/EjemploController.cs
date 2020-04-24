using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Activities_Proyect.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }

        public int promo()
        {
            return 1000;            
        }
    }
}