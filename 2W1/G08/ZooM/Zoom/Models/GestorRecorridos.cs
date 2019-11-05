using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoom.Models
{
    public class GestorRecorridos
    {
        static string conexion = @"Data Source=DESKTOP-153FVMS\MSSQLSERVER01;Initial Catalog = ZOOM; User ID = sa; Password=sa";
        AccesoDatos datos = new AccesoDatos(conexion);
        GestorPuntos gestorPuntos = new GestorPuntos();

        public void AgregarRecorrido(Recorrido recorrido)
        {
            string consulta = "insert into Recorridos(nombreRecorrido, duracion, cupo, precio, horario_ingreso, horario_egreso, fecha_inicio, fecha_final)values('" + recorrido.Nombre + "', " + recorrido.Duracion + ", " + recorrido.Cupo + ", " + recorrido.Precio + ", '" + recorrido.Hora_ing + "', '" + recorrido.Hora_egr + "', '" + recorrido.Fecha_inicio + "', '" + recorrido.Fecha_final + "') ";
            datos.ActualizarBD(consulta);
            
        }

        internal int ObtenerUltimoRecorrido()
        {
            int id = 0;
            string consulta = "select MAX(Recorridos.id) from Recorridos";
            datos.LeerBD(consulta);
            if (datos.Lector.Read())
            {
                if (!datos.Lector.IsDBNull(0)) { id= datos.Lector.GetInt32(0); }
            }
            datos.Desconectar();
            return id;
        }

        public void AgregarPPRecorrido(Recorrido recorrido)
        {
            string consulta =    "insert into PP_RECORRIDOS(id_pp, id_rec, orden) values(" + recorrido.PuntoPaseo1.Id + ", " + recorrido.Id + ", " + 1 + ") "
                               + "insert into PP_RECORRIDOS(id_pp, id_rec, orden) values(" + recorrido.PuntoPaseo2.Id + ", " + recorrido.Id + ", " + 2 + ") "
                               + "insert into PP_RECORRIDOS(id_pp, id_rec, orden) values(" + recorrido.PuntoPaseo3.Id + ", " + recorrido.Id + ", " + 3 + ") "
                               + "insert into PP_RECORRIDOS(id_pp, id_rec, orden) values(" + recorrido.PuntoPaseo4.Id + ", " + recorrido.Id + ", " + 4 + ") "
                               + "insert into PP_RECORRIDOS(id_pp, id_rec, orden) values(" + recorrido.PuntoPaseo5.Id + ", " + recorrido.Id + ", " + 5 + ")";
            datos.ActualizarBD(consulta);

        }

        public List<RecorridoMostrar> ObtenerRDisponibles(DateTime inicio,DateTime final)
        {
            List<RecorridoMostrar> recorridos = new List<RecorridoMostrar>();
            string consulta = "select r.*,p.nombrePunto,pr.orden from PP_RECORRIDOS pr, PuntosPaseo p,Recorridos r where pr.id_pp = p.id and pr.id_rec = r.id and r.fecha_inicio <= '"+ final+"' and r.fecha_final >= '"+inicio + "'and p.nombrePunto not like ' ' order by pr.id_rec,orden";
            datos.LeerBD(consulta);
            while (datos.Lector.Read())
            {
                RecorridoMostrar recorrido = new RecorridoMostrar();
                if (!datos.Lector.IsDBNull(0)) { recorrido.Id = datos.Lector.GetInt32(0); }
                if (!datos.Lector.IsDBNull(1)) { recorrido.Nombre = datos.Lector.GetString(1); }
                if (!datos.Lector.IsDBNull(2)) { recorrido.Duracion = datos.Lector.GetInt32(2); }
                if (!datos.Lector.IsDBNull(3)) { recorrido.Cupo = datos.Lector.GetInt32(3); }
                if (!datos.Lector.IsDBNull(4)) { recorrido.Precio = datos.Lector.GetDouble(4); }
                if (!datos.Lector.IsDBNull(5)) { recorrido.Hora_ing = datos.Lector.GetString(5); }
                if (!datos.Lector.IsDBNull(6)) { recorrido.Hora_egr = datos.Lector.GetString(6); }
                if (!datos.Lector.IsDBNull(7)) { recorrido.Fecha_inicio = datos.Lector.GetDateTime(7); }
                if (!datos.Lector.IsDBNull(8)) { recorrido.Fecha_final = datos.Lector.GetDateTime(8); }
                if (!datos.Lector.IsDBNull(9)) { recorrido.PuntoPaseo = datos.Lector.GetString(9); }
                if (!datos.Lector.IsDBNull(10)) { recorrido.Orden = datos.Lector.GetInt32(10); }
                recorridos.Add(recorrido);
            }
            datos.Desconectar();
            return recorridos;
        }


        public List<RecorridoMostrar> ObtenerRecorrido()
        {
            List<RecorridoMostrar> recorridos = new List<RecorridoMostrar>();
            string consulta = "select r.*,p.nombrePunto,pr.orden from PP_RECORRIDOS pr, PuntosPaseo p,Recorridos r where pr.id_pp = p.id and pr.id_rec = r.id and p.nombrePunto not like ' ' order by pr.id_rec,orden";
            datos.LeerBD(consulta);
            while (datos.Lector.Read())
            {
                RecorridoMostrar recorrido = new RecorridoMostrar();
                if (!datos.Lector.IsDBNull(0)) { recorrido.Id = datos.Lector.GetInt32(0); }
                if (!datos.Lector.IsDBNull(1)) { recorrido.Nombre = datos.Lector.GetString(1); }
                if (!datos.Lector.IsDBNull(2)) { recorrido.Duracion = datos.Lector.GetInt32(2); }
                if (!datos.Lector.IsDBNull(3)) { recorrido.Cupo = datos.Lector.GetInt32(3); }
                if (!datos.Lector.IsDBNull(4)) { recorrido.Precio = datos.Lector.GetDouble(4); }
                if (!datos.Lector.IsDBNull(5)) { recorrido.Hora_ing = datos.Lector.GetString(5); }
                if (!datos.Lector.IsDBNull(6)) { recorrido.Hora_egr = datos.Lector.GetString(6); }
                if (!datos.Lector.IsDBNull(7)) { recorrido.Fecha_inicio = datos.Lector.GetDateTime(7); }
                if (!datos.Lector.IsDBNull(8)) { recorrido.Fecha_final = datos.Lector.GetDateTime(8); }
                if (!datos.Lector.IsDBNull(9)) { recorrido.PuntoPaseo = datos.Lector.GetString(9); }
                if (!datos.Lector.IsDBNull(10)) { recorrido.Orden = datos.Lector.GetInt32(10); }
                recorridos.Add(recorrido);
            }
            datos.Desconectar();
            return recorridos;
        }
    }
}