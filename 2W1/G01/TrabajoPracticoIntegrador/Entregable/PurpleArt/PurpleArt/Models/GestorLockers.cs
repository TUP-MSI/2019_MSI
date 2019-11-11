using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class GestorLockers
    {
        static string cadenaConexion = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
        ConexionDB datos = new ConexionDB(cadenaConexion);

        public void DesocuparLocker(int codigo){
            String query = "UPDATE Lockers SET id_obra = NULL WHERE id_locker= " + codigo;
            datos.actualizarDB(query);
        }

         public void OcuparLocker(Locker locker){
            String query = "UPDATE Lockers SET id_obra = "+ locker.Obra.Codigo +" WHERE id_locker= " + locker.Codigo;
            datos.actualizarDB(query);
        }


        public List<Locker> ObtenerTodos(){
            return ObtenerLocker("select l.id_locker, l.nombre, l.id_obra, o.nombre, l.dimension, " +
                                 "l.fecha_ingreso, l.fecha_egreso from Lockers l join Obras o on " +
                                 "l.id_obra=o.codigo");
        }   

          public Locker ObtenerUnLocker(int id){
            return ObtenerLocker("select l.id_locker, l.nombre, l.id_obra, 'nada', l.dimension, " +
                "l.fecha_ingreso, l.fecha_egreso from Lockers l WHERE id_locker = "+ id)[0];
        }   

        public List<Locker> ObtenerLockersDisponibles(){
            return ObtenerLocker("select l.id_locker, l.nombre, l.id_obra, 'nada', l.dimension, l.fecha_ingreso, l.fecha_egreso  from Lockers l where l.id_obra is null");
        }   

        public List<Locker> ObtenerLockerNoDisponibles(){
            return ObtenerLocker("select l.id_locker, l.nombre, l.id_obra, o.nombre, l.dimension, " +
                                 "l.fecha_ingreso, l.fecha_egreso from Lockers l join Obras o on " +
                                 "l.id_obra=o.codigo where l.id_obra is not null");
        }

        private List<Locker> ObtenerLocker(String query){
            List<Locker> lista = new List<Locker>();
            datos.leerTabla2(query);
            while(datos.pLector.Read()){
                Locker l = new Locker();
                if (!datos.pLector.IsDBNull(0))
                    l.Codigo = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    l.Nombre = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    l.Obra.Codigo = datos.pLector.GetInt32(2);
                if (!datos.pLector.IsDBNull(3))
                    l.Obra.Nombre = datos.pLector.GetString(3);
                if (!datos.pLector.IsDBNull(4))
                    l.Dimension = datos.pLector.GetString(4);
                if (!datos.pLector.IsDBNull(5))
                    l.FechaIngreso = datos.pLector.GetString(5);
                if (!datos.pLector.IsDBNull(6))
                l.FechaEgreso = datos.pLector.GetString(6);
                lista.Add(l);
            }
            datos.desconectar();
            return lista;
        }
    }
}
