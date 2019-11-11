using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Provincia{
        private int idProvincia;
        private String nombreProvincia;
        private Pais pais;

        public Provincia(){
            Pais = new Pais();
        }

        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public string NombreProvincia { get => nombreProvincia; set => nombreProvincia = value; }
  
        public Pais Pais { get => pais; set => pais = value; }
    }
}