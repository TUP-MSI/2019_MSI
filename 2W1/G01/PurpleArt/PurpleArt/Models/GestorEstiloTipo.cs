using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class GestorEstiloTipo
    {
        static string cadenaConexion = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
        ConexionDB datos = new ConexionDB(cadenaConexion);

        public List<Estilo> ObtenerEstilos()
        {
            string query = "SELECT * FROM Estilos";
            List<Estilo> listaE = new List<Estilo>();
            datos.leerTabla2(query);
            while (datos.pLector.Read())
            {
                Estilo e = new Estilo();
                if (!datos.pLector.IsDBNull(0))
                    e.Id = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    e.NombreEstilo = datos.pLector.GetString(1);
                listaE.Add(e);
            }
            datos.desconectar();
            return listaE;
        }


        public List<TipoObra> ObtenerTipoObra()
        {
            string query = "SELECT * FROM TiposObra";
            List<TipoObra> listaT = new List<TipoObra>();
            datos.leerTabla2(query);
            while (datos.pLector.Read())
            {
                TipoObra t = new TipoObra();
                if (!datos.pLector.IsDBNull(0))
                    t.Id = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    t.NombreTipoObra = datos.pLector.GetString(1);
                listaT.Add(t);
            }
            datos.desconectar();
            return listaT;
        }

    }
}