using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class GestorOrigen
    {
    static string cadena = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
    ConexionDB datos = new ConexionDB(cadena);


        public List<Pais> ObtenerPaises()
        {
            string query = "SELECT * FROM Paises";
            List<Pais> listaP = new List<Pais>();
            datos.leerTabla2(query);

            while (datos.pLector.Read())
            {
                Pais p = new Pais();
                if (!datos.pLector.IsDBNull(0))
                    p.IdPais = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    p.NombrePais = datos.pLector.GetString(1);
                listaP.Add(p);
            }
            datos.desconectar();
            return listaP;
        }

        public List<Provincia> ObtenerProvincias()
        {
            string query = "SELECT * FROM Provincias ";
            List<Provincia> listaP = new List<Provincia>();
            datos.leerTabla2(query);
            while (datos.pLector.Read())
            {
                Provincia p = new Provincia();
                if (!datos.pLector.IsDBNull(0))
                    p.IdProvincia = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    p.NombreProvincia = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    p.Pais.IdPais = datos.pLector.GetInt32(2);
               
                listaP.Add(p);
            }
            datos.desconectar();
            return listaP;
        }


        public List<Localidad> ObtenerLocalidades() {
            string query = "SELECT * FROM Localidades";
            List<Localidad> listaL = new List<Localidad>();
            datos.leerTabla2(query);

            while (datos.pLector.Read()) {
                Localidad l = new Localidad();
                if (!datos.pLector.IsDBNull(0))
                    l.IdLocalidad = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    l.NombreLocalidad = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    l.Provincia.IdProvincia = datos.pLector.GetInt32(2);
                listaL.Add(l);
            } 
            datos.desconectar();
            return listaL;
        }

    }
}