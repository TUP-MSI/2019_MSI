using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_practico.Clases
{
    class Noche
    {
        private int id_noche;
        private int nro_luna;
        private DateTime fecha_horaComienzo;
        private DateTime fecha_horaCierre;


        public int Id_noche { get => id_noche; set => id_noche = value; }
        public int Nro_luna { get => nro_luna; set => nro_luna = value; }
        public DateTime Fecha_horaComienzo { get => fecha_horaComienzo; set => fecha_horaComienzo = value; }
        public DateTime Fecha_horaCierre { get => fecha_horaCierre; set => fecha_horaCierre = value; }

        public Noche(int id_noche, int nro_luna, DateTime fecha_horaComienzo, DateTime fecha_horaCierre)
        {
            this.id_noche = id_noche;
            this.nro_luna = nro_luna;
            this.fecha_horaComienzo = fecha_horaComienzo;
            this.fecha_horaCierre = fecha_horaCierre;
        }

        public Noche()
        {
        }

        public override string ToString()
        {

            return "Noche: " + nro_luna +" - "+ " Fecha y Horario de Comiezo: " + fecha_horaComienzo +" - "+ " Fecha y Horario de Cierre: " + fecha_horaCierre;
        }

    }
}
