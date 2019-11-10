using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Estilo{
        private int id;
        private String nombreEstilo;

        public Estilo(){
        }

        public int Id { get => id; set => id = value; }
        public string NombreEstilo { get => nombreEstilo; set => nombreEstilo = value; }
    }
}

