using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Localidad
    {
        private int idLocalidad;
        private String nombreLocalidad;
        private Provincia provincia;

        public Localidad(){
            provincia = new Provincia();
        }

        public int IdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public string NombreLocalidad { get => nombreLocalidad; set => nombreLocalidad = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }
    }
}