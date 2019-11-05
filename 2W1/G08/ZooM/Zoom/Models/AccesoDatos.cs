using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Zoom.Models
{
    public class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        DataTable tabla;
        string stringConexion;

        public AccesoDatos(string stringConexion)
        {
            this.conexion = new SqlConnection(stringConexion);
            this.comando = new SqlCommand();
            this.lector = null;
            this.tabla = new DataTable();
            this.stringConexion = stringConexion;
        }

        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
        public SqlDataReader Lector { get => lector; set => lector = value; }

        public void Conectar()
        {
            conexion.ConnectionString = stringConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public void LeerBD(string consulta)
        {
            Conectar();
            comando.CommandText = consulta;
            lector = Comando.ExecuteReader();
        }

        public void ActualizarBD(string consulta)
        {
            Conectar();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            Desconectar();
        }
    }
}