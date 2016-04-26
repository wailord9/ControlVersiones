using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
    public class CalculosRectanguloController : Controller
    {
        // GET: CalculosRectangulo
        public ActionResult Index()
        {
            return View("~/Views/CalculosRectangulo/CalculoRectangulo.cshtml");
        }

        public ActionResult obtenerValoresArea()
        {
            string bases = Request["valBase"];
            string altura = Request["valAltura"];

            int resultado = Convert.ToInt32(bases) * Convert.ToInt32(altura);

            return Json(new { Success = true, respuesta = resultado});
        }




    }
}