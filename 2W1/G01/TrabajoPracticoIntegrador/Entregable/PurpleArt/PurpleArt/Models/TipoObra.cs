using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class TipoObra
    {
        private int id;
        private String nombreTipoObra;

        public TipoObra(){
        }

        public int Id { get => id; set => id = value; }
        public string NombreTipoObra { get => nombreTipoObra; set => nombreTipoObra = value; }
    }
}