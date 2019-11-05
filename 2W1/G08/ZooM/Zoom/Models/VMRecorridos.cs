using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class VMRecorridos
    {
        List<RecorridoMostrar> recorridos;
        Recorrido recorrido;
        List<PuntoPaseo> puntos;

        public VMRecorridos()
        {
            this.Recorridos = new List<RecorridoMostrar>();
            this.Recorrido = new Recorrido();
            this.Puntos = new List<PuntoPaseo>();
        }

        public List<RecorridoMostrar> Recorridos { get => recorridos; set => recorridos = value; }
        public Recorrido Recorrido { get => recorrido; set => recorrido = value; }
        public List<PuntoPaseo> Puntos { get => puntos; set => puntos = value; }

 


    }
}