using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class VMGuias
    {
        List<Guia> guias;
        Guia guia;

        public VMGuias()
        {
            this.guias = new List<Guia>();
            this.guia = new Guia();
        }

        public List<Guia> Guias { get => guias; set => guias = value; }
        public Guia Guia { get => guia; set => guia = value; }
    }
}