using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoom.Models;

namespace Zoom.Controllers
{
    public class GuiasController : Controller
    {
        // GET: Guias
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            VMGuias vg = new VMGuias();
            return View(vg);
        }

        [HttpPost]
        public ActionResult Add(VMGuias vg)
        {
            GestorGuias gg = new GestorGuias();
            gg.AgregarGuia(vg.Guia);
            vg.Guias = gg.ObtenerGuia();
            return View("List", vg);
        }

        public ActionResult List()
        {
            VMGuias vg = new VMGuias();
            GestorGuias gg = new GestorGuias();
            vg.Guias = gg.ObtenerGuia();
            return View(vg);
        }
    }
}
