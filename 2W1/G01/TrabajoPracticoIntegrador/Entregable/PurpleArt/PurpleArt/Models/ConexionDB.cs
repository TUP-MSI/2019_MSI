using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PurpleArt.Models
{
    public class ConexionDB
    {
        SqlCommand comando;
        SqlConnection conexion;
        DataTable tabla;
        String cadenaConexion;
        SqlDataReader lector;

        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public SqlDataReader pLector { get => lector; set => lector = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }

        public ConexionDB(string cadenaConexion)
        {
            this.Comando = new SqlCommand();
            this.conexion = new SqlConnection(cadenaConexion);
            this.conexion.ConnectionString = cadenaConexion;
            this.tabla = new DataTable();
            this.cadenaConexion = cadenaConexion;
            this.lector = null;
        }

        public ConexionDB()
        {
            this.Comando = new SqlCommand();
            this.conexion = new SqlConnection();
            this.tabla = new DataTable();
            this.cadenaConexion = "";
            this.lector = null;
        }

        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            Comando.Connection = conexion;
            Comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            tabla = new DataTable();
            conectar();
            Comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(Comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultarTablaSQL(string nombreTabla)
        {
            tabla = new DataTable();
            conectar();
            Comando.CommandText = nombreTabla;
            tabla.Load(Comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        //public void leerTabla(string nombreTabla)
        //{
        //    conectar();
        //    Comando.CommandText = "SELECT * FROM " + nombreTabla;
        //    lector = Comando.ExecuteReader();
        //}

        public void leerTabla2(string comando)
        {
            conectar();
            Comando.CommandText = comando;
            lector = Comando.ExecuteReader();
        }

        public void actualizarDB(string consultaSQL)
        {
            conectar();
            Comando.CommandText = consultaSQL;
            Comando.ExecuteNonQuery();
            desconectar();
        }

    }
}