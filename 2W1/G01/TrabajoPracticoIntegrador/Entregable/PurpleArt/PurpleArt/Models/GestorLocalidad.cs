using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class GestorLocalidad
    {
    static string cadena = @"Data Source=CAYUN\SQLEXPRESS;Initial Catalog=PurpleArtDB;Integrated Security=True";
    ConexionDB datos = new ConexionDB(cadena);

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
                listaL.Add(l);
            }
            datos.desconectar();
            return listaL;
        }
    }
}