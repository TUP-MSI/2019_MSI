using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoom.Models;

namespace Zoom.Controllers
{
    public class PuntosPaseoController : Controller
    {
        // GET: ZooM
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            VMPuntos vp = new VMPuntos();
            return View(vp);
        }

        [HttpPost]
        public ActionResult Add(VMPuntos vp)
        {
            GestorPuntos gp = new GestorPuntos();
            gp.AgregarPunto(vp.Punto);
            vp.Puntos = gp.ObtenerPuntos();
            return View("List", vp);
        }

        public ActionResult List()
        {
            VMPuntos vp = new VMPuntos();
            GestorPuntos gp = new GestorPuntos();
            vp.Puntos = gp.ObtenerPuntos();
            return View(vp);
        }

    }
}
