using PurpleArt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurpleArt.Controllers
{
    public class ArtistaController : Controller
    {

        // GET: Artista
        public ActionResult ListarArtista()
        {
            List<Artista> ar = new List<Artista>();
            GestorArtista gestor = new GestorArtista();
            ar = gestor.ObtenerTodosA();
            return View(ar);
        }

        public ActionResult Agregar(){
            GestorArtista gestor = new GestorArtista();
            GestorOrigen gestorO = new GestorOrigen();
            VMTodo vmo = new VMTodo();
            vmo.Paises = gestorO.ObtenerPaises();
            vmo.Provincias = gestorO.ObtenerProvincias();
            vmo.Localidades = gestorO.ObtenerLocalidades();
            return View(vmo);
        }

        [HttpPost]
        public ActionResult Agregar(VMTodo nuevo){
            GestorArtista gestor = new GestorArtista();
            nuevo.Artista.Localidad.IdLocalidad = nuevo.Localidad;
            gestor.agregar(nuevo.Artista);
            List<Artista> ar = new List<Artista>();
            ar = gestor.ObtenerTodosA();
            return View("ListarArtista",ar);
        }
    }
}