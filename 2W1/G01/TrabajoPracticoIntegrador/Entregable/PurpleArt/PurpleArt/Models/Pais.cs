using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Pais
    {
        private int idPais;
        private String nombrePais;
      

        public Pais(){

        }

        public int IdPais { get => idPais; set => idPais = value; }
        public string NombrePais { get => nombrePais; set => nombrePais = value; }

    }
}