using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Locker
    {
        private int codigo;
        private String nombre;
        private Obra obra;
        private String dimension;
        private String fechaIngreso;
        private String fechaEgreso;

        public Locker(){
            obra = new Obra();
            fechaIngreso = DateTime.Today.ToString("dd/MM/yy");
            fechaEgreso = "";
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Obra Obra { get => obra; set => obra = value; }
        public string Dimension { get => dimension; set => dimension = value; }
        public String FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public String FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }
    }
}