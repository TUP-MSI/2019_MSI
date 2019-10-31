using PurpleArt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurpleArt.Controllers
{
    public class LockerController : Controller
    {
        // GET: Locker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult  ListarLockerDisponible(){
            GestorLockers gest = new GestorLockers();
            List<Locker> lo = new List<Locker>();
            lo = gest.ObtenerLockersDisponibles();
            return View(lo);
        }

        public ActionResult ListarLockerNoDisponible(){
            List<Locker> lo = new List<Locker>();
            GestorLockers ges = new GestorLockers();
            lo = ges.ObtenerLockerNoDisponibles();
            return View(lo);
        }

        
        public ActionResult Ocupar(int id){
            List<Locker> lo = new List<Locker>();
            GestorLockers ges = new GestorLockers();
            GestorObra gestO = new GestorObra();
            VMTodo vmt = new VMTodo();
            lo = ges.ObtenerLockerNoDisponibles();
            List<Obra> o = new List<Obra>();
            o = gestO.ObtenerTodas();
            vmt.Locker = ges.ObtenerUnLocker(id);

           vmt.ListaObra = gestO.ObtenerObrasDisponibles();
            return View(vmt);
        }

        [HttpPost]
        public ActionResult Ocupar(VMTodo vmt)
        {
            GestorLockers ges = new GestorLockers();
            ges.OcuparLocker(vmt.Locker);
            List<Locker> lo = new List<Locker>();
            lo = ges.ObtenerLockersDisponibles();
            return View("ListarLockerDisponible",lo);
        }


        public ActionResult Desocupar(int id){
            List<Locker> l = new List<Locker>();
            GestorLockers ges = new GestorLockers();
            ges.DesocuparLocker(id);
            l = ges.ObtenerLockerNoDisponibles();
            return View("ListarLockerNoDisponible",l);
        }
    }
}