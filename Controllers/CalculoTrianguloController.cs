using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
    public class CalculoTrianguloController : Controller
    {
        // GET: CalculoTriangulo
        public ActionResult Index()
        {
            return View("~/Views/CalculoTriangulo/CalculoTriangulo.cshtml");
        }

        public ActionResult calcularAreaTriangulo()
        {
            string catetoA = Request["CatetoA"];
            string catetoB = Request["CatetoB"];

            int resultado = (Convert.ToInt32(catetoA) * Convert.ToInt32(catetoB))/2;

            return Json(new { Success = true, respuesta = resultado });
        }
    }
}