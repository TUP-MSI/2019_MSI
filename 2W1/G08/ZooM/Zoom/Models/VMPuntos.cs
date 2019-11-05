using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class VMPuntos
    {
        List<PuntoPaseo> puntos;
        PuntoPaseo punto;

        public VMPuntos()
        {
            this.puntos = new List<PuntoPaseo>();
            this.punto = new PuntoPaseo();
        }

        public List<PuntoPaseo> Puntos { get => puntos; set => puntos = value; }
        public PuntoPaseo Punto { get => punto; set => punto = value; }



    }
}