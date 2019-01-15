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
        private Alumno alumno = new Alumno();
        // GET: Home2
        public ActionResult Index()
        {
            return View(alumno.Listar());
        }

        public ActionResult Ver(int id)
        {
           
            return View(alumno.Obtener(id));
        }

        public JsonResult Guardar(Alumno model)
        {
            var rm = new ResponseModel();

            if (ModelState.IsValid)
            {
                rm = model.Guardar();
                
                if (rm.response)
                {
                    rm.href = Url.Content("~/home2");
                }
            }


            return Json(rm);
        }

        public ActionResult Crud( int id = 0)
        {
            return View(
                id == 0 ? new Alumno()
                    : alumno.Obtener(id)
                );
        }

        public ActionResult Eliminar(int id)
        {
            alumno.id = id;
            alumno.Eliminar();
            return Redirect("~/home2");
        }
    }
}