using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Ubicacion
    {
        private int id;
        private Localidad localidad;
        private String torre;
        private String calle;
        private int numero;
        private int piso;
        private String depto;

        public Ubicacion(){
            localidad = new Localidad();
        }

        public int Id { get => id; set => id = value; }
        public string Torre { get => torre; set => torre = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Piso { get => piso; set => piso = value; }
        public string Depto { get => depto; set => depto = value; }
        internal Localidad Localidad { get => localidad; set => localidad = value; }
    }
}