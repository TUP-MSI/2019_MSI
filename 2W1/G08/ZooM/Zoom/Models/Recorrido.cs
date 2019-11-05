using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class Recorrido
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
        PuntoPaseo puntoPaseo1;
        PuntoPaseo puntoPaseo2;
        PuntoPaseo puntoPaseo3;
        PuntoPaseo puntoPaseo4;
        PuntoPaseo puntoPaseo5;

        public Recorrido()
        {
        }

        public Recorrido(int id, string nombre, int duracion, int cupo, double precio, string hora_ing, string hora_egr, DateTime fecha_inicio, DateTime fecha_final, PuntoPaseo puntoPaseo1, PuntoPaseo puntoPaseo2, PuntoPaseo puntoPaseo3, PuntoPaseo puntoPaseo4, PuntoPaseo puntoPaseo5)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.Cupo = cupo;
            this.Precio = precio;
            this.Hora_ing = hora_ing;
            this.Hora_egr = hora_egr;
            this.Fecha_inicio = fecha_inicio;
            this.Fecha_final = fecha_final;
            this.PuntoPaseo1 = puntoPaseo1;
            this.PuntoPaseo2 = puntoPaseo2;
            this.PuntoPaseo3 = puntoPaseo3;
            this.PuntoPaseo4 = puntoPaseo4;
            this.PuntoPaseo5 = puntoPaseo5;
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
        public PuntoPaseo PuntoPaseo1 { get => puntoPaseo1; set => puntoPaseo1 = value; }
        public PuntoPaseo PuntoPaseo2 { get => puntoPaseo2; set => puntoPaseo2 = value; }
        public PuntoPaseo PuntoPaseo3 { get => puntoPaseo3; set => puntoPaseo3 = value; }
        public PuntoPaseo PuntoPaseo4 { get => puntoPaseo4; set => puntoPaseo4 = value; }
        public PuntoPaseo PuntoPaseo5 { get => puntoPaseo5; set => puntoPaseo5 = value; }
    }
}