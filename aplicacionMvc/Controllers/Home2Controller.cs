using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace aplicacionMvc.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ver()
        {
           
            return View(Alumno.Obtener());
        }

        public ActionResult Guardar(Alumno alumno)
        {
            return Redirect("~/home/index");
        }
    }
}