using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class VMReporte
    {
        DateTime fecha_inicio;
        DateTime fecha_final;

        public VMReporte()
        {

        }

        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_final { get => fecha_final; set => fecha_final = value; }
    }
}