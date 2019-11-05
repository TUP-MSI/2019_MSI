using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class GestorGuias
    {
        static string conexion = @"Data Source=DESKTOP-153FVMS\MSSQLSERVER01;Initial Catalog = ZOOM; User ID = sa; Password=sa";
        AccesoDatos datos = new AccesoDatos(conexion);

        public void AgregarGuia(Guia guia)
        {
            string consulta = "insert into Guias(nombre, apellido, dni) values('"+ guia.Nombre +"', '"+ guia.Apellido +"', '"+ guia.Dni +"')";
            datos.ActualizarBD(consulta);
        }

        public List<Guia> ObtenerGuia()
        {
            List<Guia> guias = new List<Guia>();
            string consulta = "select * from guias";
            datos.LeerBD(consulta);
            while (datos.Lector.Read())
            {
                Guia guia = new Guia();
                if (!datos.Lector.IsDBNull(0)) { guia.Id = datos.Lector.GetInt32(0); }
                if (!datos.Lector.IsDBNull(1)) { guia.Nombre = datos.Lector.GetString(1); }
                if (!datos.Lector.IsDBNull(2)) { guia.Apellido = datos.Lector.GetString(2); }
                if (!datos.Lector.IsDBNull(3)) { guia.Dni = datos.Lector.GetString(3); }
                guias.Add(guia);
            }
            datos.Desconectar();
            return guias;
        }

    }
}