using PurpleArt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurpleArt.Controllers
{
    public class ObraController : Controller
    {
        // GET: Obra
        public ActionResult Listar()
        {
            List<Obra> ob = new List<Obra>();
            GestorObra ges = new GestorObra();
            ob = ges.ObtenerTodas();
            return View(ob);
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar()
        {
            GestorObra gest = new GestorObra();
            GestorArtista gestA = new GestorArtista();
            GestorEstiloTipo gestT = new GestorEstiloTipo();
            VMTodo vmo = new VMTodo();
            vmo.ListaEstilo = gestT.ObtenerEstilos();
            vmo.ListaTipo = gestT.ObtenerTipoObra();
            vmo.ListaArtistas = gestA.ObtenerTodosA();
            return View(vmo);
        }

        [HttpPost]
        public ActionResult Agregar(VMTodo vmo)
        {
            GestorObra gest = new GestorObra();
            gest.agregar(vmo.Obra);

            List<Obra> ob = new List<Obra>();
            ob = gest.ObtenerTodas();
            return View("Listar",ob);
        }
    }
}