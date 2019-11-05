using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class RecorridoMostrar
    {
        int id;
        string nombre;
        int duracion;
        int cupo;
        double precio;
        string hora_ing;
        string hora_egr;
        DateTime fecha_inicio;
        DateTime fecha_final;
        //List<Tuple<PuntoPaseo, int>> puntoOrdenado;
        string puntoPaseo;
        int orden;

        public RecorridoMostrar()
        {
        }

        public RecorridoMostrar(int id, string nombre, int duracion, int cupo, double precio, string hora_ing, string hora_egr, DateTime fecha_inicio, DateTime fecha_final, string puntoPaseo, int orden)
        {
            this.id = id;
            this.nombre = nombre;
            this.duracion = duracion;
            this.cupo = cupo;
            this.precio = precio;
            this.hora_ing = hora_ing;
            this.hora_egr = hora_egr;
            this.fecha_inicio = fecha_inicio;
            this.fecha_final = fecha_final;
            this.PuntoPaseo = puntoPaseo;
            this.Orden = orden;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Hora_ing { get => hora_ing; set => hora_ing = value; }
        public string Hora_egr { get => hora_egr; set => hora_egr = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_final { get => fecha_final; set => fecha_final = value; }
        public string PuntoPaseo { get => puntoPaseo; set => puntoPaseo = value; }
        public int Orden { get => orden; set => orden = value; }
    }
}