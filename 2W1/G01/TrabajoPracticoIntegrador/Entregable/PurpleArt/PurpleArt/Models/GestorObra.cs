using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
   

    public class GestorObra
    {
    static string cadenaConexion = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
    ConexionDB datos = new ConexionDB(cadenaConexion);

    public void agregar(Obra o){
        datos.actualizarDB("insert into Obras(nombre,id_estilo,id_tipo_obra,id_artista,descripcion,dimension,valuacion,estado_obra,disponible,fecha_creacion)"+
                           "values('" + o.Nombre + "', " + o.Estilo.Id + ", " + o.TipoObra.Id + ", " + o.Artista.IdArtista + ", '" + o.Descripcion + "', '" + o.Dimension + "', " + Convert.ToDecimal(o.Valuacion) + ", '" + o.EstadoObra + "', " + Convert.ToInt32(o.Disponibilidad)  + " , " + "'" +  o.FechaCreacion + "')");
    }

    public List<Obra> ObtenerTodas(){
        return ObtenerObras("select o.codigo, o.nombre, e.id_estilo, e.nombreEstilo, ti.id_tipo, ti.nombre_tipo, "+
                            "a.id_artista, a.nombre, o.descripcion, o.dimension, o.valuacion, o.estado_obra, "+
                            "o.disponible, o.fecha_creacion from Obras o join TiposObra ti on "+
                            "ti.id_tipo=o.id_tipo_obra join estilos e on e.id_estilo=o.id_estilo join Artistas a "+
                            "on a.id_artista=o.id_artista");
    }

    public List<Obra> ObtenerObrasDisponibles(){
        return ObtenerObras("select o.codigo, o.nombre, e.id_estilo, e.nombreEstilo, ti.id_tipo, ti.nombre_tipo, "+
                            "a.id_artista, a.nombre, o.descripcion, o.dimension, o.valuacion, o.estado_obra, "+
                            "o.disponible, o.fecha_creacion from Obras o join TiposObra ti on "+
                            "ti.id_tipo=o.id_tipo_obra join estilos e on e.id_estilo=o.id_estilo join "+
                            "Artistas a on a.id_artista=o.id_artista where o.disponible=1");
    }

  

    public Obra ObtenerUnaObra(int id){
        return ObtenerObras("select o.codigo, o.nombre, o.id_estilo, o.tipo_obra, o.id_artista, o.descripcion, " +
                            "o.dimension, o.valuacion, o.estado_obra, o.disponible,o.fecha_creacion from " +
                            "Obras o where o.codigo =" + id)[0];
    }

    private List<Obra> ObtenerObras(String query){
        List<Obra> lista = new List<Obra>();
        datos.leerTabla2(query);
            while(datos.pLector.Read()){
                Obra o = new Obra();
                if (!datos.pLector.IsDBNull(0))
                    o.Codigo = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    o.Nombre = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    o.Estilo.Id = datos.pLector.GetInt32(2);
                if (!datos.pLector.IsDBNull(3))
                    o.Estilo.NombreEstilo = datos.pLector.GetString(3);
                if (!datos.pLector.IsDBNull(4))
                    o.TipoObra.Id = datos.pLector.GetInt32(4);
                if (!datos.pLector.IsDBNull(5))
                    o.TipoObra.NombreTipoObra = datos.pLector.GetString(5);
                if (!datos.pLector.IsDBNull(6))
                    o.Artista.IdArtista = datos.pLector.GetInt32(6);
                if (!datos.pLector.IsDBNull(7))
                    o.Artista.NombreArtista = datos.pLector.GetString(7);
                if (!datos.pLector.IsDBNull(8))
                    o.Descripcion = datos.pLector.GetString(8);
                if (!datos.pLector.IsDBNull(9))
                    o.Dimension = datos.pLector.GetString(9);
                if (!datos.pLector.IsDBNull(10))
                    o.Valuacion = datos.pLector.GetFloat(10);    
                if (!datos.pLector.IsDBNull(11))
                    o.EstadoObra = datos.pLector.GetString(11);
                if (!datos.pLector.IsDBNull(12))
                    o.Disponibilidad = datos.pLector.GetBoolean(12); 
                if (!datos.pLector.IsDBNull(13))
                    o.FechaCreacion = datos.pLector.GetString(13);   
                lista.Add(o);
            }
            datos.desconectar();
            return lista;
            }
    }
}