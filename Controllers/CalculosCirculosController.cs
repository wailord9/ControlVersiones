using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
    public class CalculosCirculosController : Controller
    {
        // GET: CalculosCirculos
        public ActionResult Index()
        {
            return View("~/Views/CalculosCirculos/CalculosCirculo.cshtml");
        }

        public ActionResult calculoAreaCirculo()
        {
            string radio = Request["Valradio"];

            Double resultado = System.Math.Pow(Convert.ToDouble(radio), 2) * System.Math.PI ;

            return Json(new { Success = true, respuesta = resultado });

        }
    }
}