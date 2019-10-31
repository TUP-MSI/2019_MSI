using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class GestorArtista
    {
        static string cadena = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
        ConexionDB datos = new ConexionDB(cadena);

        //Método agregar
        public void agregar(Artista a){
            datos.actualizarDB("insert into artistas(nombre,apellido,fecha_nac,detalle,id_localidad) values('"+a.NombreArtista + "'" + " , '" + a.ApellidoArtista + "'" + " , " + "'" +a.FechaNac + "'" + " , '" + a.Detalle + "'" + " , " + a.Localidad.IdLocalidad + " )");
        }


        public List<Artista> ObtenerTodosA(){
            return ObtenerArtista("SELECT a.id_artista, a.nombre, a.apellido, a.fecha_nac, a.detalle, l.id_localidad, l.nombre_localidad FROM Artistas a JOIN Localidades l ON a.id_localidad = l.id_localidad");
        }

        public Artista ObtenerUnA(int id){
            return ObtenerArtista("SELECT a.id_artista, a.nombre, a.apellido, a.fecha_nac, a.detalle, l.id_localidad, l.nombre_localidad FROM Artistas a JOIN Localidades l ON a.id_localidad = l.id_localidad WHERE a.id_artista = " + id).ElementAt(0);
        }

        private List<Artista> ObtenerArtista(string query){
            List<Artista> listaA = new List<Artista>();
            datos.leerTabla2(query);
            while(datos.pLector.Read()){
                Artista a = new Artista();
                if (!datos.pLector.IsDBNull(0))
                    a.IdArtista = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    a.NombreArtista = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    a.ApellidoArtista = datos.pLector.GetString(2);
                if (!datos.pLector.IsDBNull(3))
                    a.FechaNac = datos.pLector.GetString(3);
                if (!datos.pLector.IsDBNull(4))
                    a.Detalle = datos.pLector.GetString(4);
                if (!datos.pLector.IsDBNull(5))
                    a.Localidad.IdLocalidad = datos.pLector.GetInt32(5);
                if (!datos.pLector.IsDBNull(6))
                    a.Localidad.NombreLocalidad = datos.pLector.GetString(6);
                listaA.Add(a);
            }
            datos.desconectar();
            return listaA;
        }
    }
}