using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class GestorPuntos
    {
        static string conexion = @"Data Source=DESKTOP-153FVMS\MSSQLSERVER01;Initial Catalog = ZOOM; User ID = sa; Password=sa";
        AccesoDatos datos = new AccesoDatos(conexion);

        public void AgregarPunto(PuntoPaseo punto)
        {
            string consulta = "insert into puntospaseo(nombrepunto, descripcionpunto, disponible) values('"+punto.Nombre+"', '"+punto.Descripcion+"', "+convertDisponible(punto.Disponible)+")";
            datos.ActualizarBD(consulta);
        }

        public int convertDisponible(bool disp)
        {
            int res = -1;
            if (disp)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
            return res;
        }

        public List<PuntoPaseo> ObtenerPuntos()
        {
            List<PuntoPaseo> puntos = new List<PuntoPaseo>();
            string consulta = "select * from puntospaseo";
            datos.LeerBD(consulta);
            while (datos.Lector.Read())
            {
                PuntoPaseo punto = new PuntoPaseo();
                if (!datos.Lector.IsDBNull(0)) { punto.Id = datos.Lector.GetInt32(0); }
                if (!datos.Lector.IsDBNull(1)) { punto.Nombre = datos.Lector.GetString(1); }
                if (!datos.Lector.IsDBNull(2)) { punto.Descripcion = datos.Lector.GetString(2); }
                if (!datos.Lector.IsDBNull(3)) { punto.Disponible = datos.Lector.GetBoolean(3); }
                puntos.Add(punto);
            }
            datos.Desconectar();
            return puntos;
        }
    }
}