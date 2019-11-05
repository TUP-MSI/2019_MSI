using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class PuntoPaseo
    {
        int id;
        string nombre;
        string descripcion;
        bool disponible;

        public PuntoPaseo()
        {
        }

        public PuntoPaseo(int id, string nombre, string descripcion, bool disponible)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Disponible = disponible;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
    }
}