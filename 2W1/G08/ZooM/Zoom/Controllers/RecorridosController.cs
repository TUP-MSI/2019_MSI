using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoom.Models;

namespace Zoom.Controllers
{
    public class RecorridosController : Controller
    {
        // GET: Recorridos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            VMRecorridos vr = new VMRecorridos();
            GestorPuntos gp = new GestorPuntos();
            vr.Puntos = gp.ObtenerPuntos();
            return View(vr);
        }

        [HttpPost]
        public ActionResult Add(VMRecorridos vr)
        {
            GestorRecorridos gr = new GestorRecorridos();
            gr.AgregarRecorrido(vr.Recorrido);
            vr.Recorrido.Id=gr.ObtenerUltimoRecorrido();
            gr.AgregarPPRecorrido(vr.Recorrido);
            vr.Recorridos = gr.ObtenerRecorrido();
            return View("List", vr);
        }

        public ActionResult List()
        {
            VMRecorridos vr = new VMRecorridos();
            GestorRecorridos gr = new GestorRecorridos();
            vr.Recorridos = gr.ObtenerRecorrido();
            return View(vr);
        }

        public ActionResult Report()
        {
            VMReporte vr = new VMReporte();
            return View(vr);
        }

        [HttpPost]
        public ActionResult Report(VMReporte vr)
        {
            VMRecorridos recorridos = new VMRecorridos();
            GestorRecorridos gr = new GestorRecorridos();
            recorridos.Recorridos=gr.ObtenerRDisponibles(vr.Fecha_inicio,vr.Fecha_final);
            return View("List", recorridos);
        }
    }
}
