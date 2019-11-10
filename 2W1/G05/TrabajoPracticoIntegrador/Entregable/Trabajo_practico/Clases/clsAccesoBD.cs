using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Trabajo_practico.Clases
{
    class clsAccesoBD
    {
        private SqlConnection conexion;
        private SqlCommand comando;        
        private SqlDataReader lector;        
        private string cadenaConexion;
        private DataTable tabla;
        
        public SqlConnection pConexion { get => conexion; set => conexion = value; }
        public SqlCommand pComando { get => comando; set => comando = value; }
        public SqlDataReader pLector { get => lector; set => lector = value; }
        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
             

        public clsAccesoBD()
        {
            this.conexion = new SqlConnection();
            this.comando = new SqlCommand();
            this.lector = null;
            this.cadenaConexion = "";
            this.tabla = new DataTable();
        }

        public clsAccesoBD(string cadenaConexion)
        {
            this.conexion = new SqlConnection();
            this.comando = new SqlCommand();
            this.lector = null;
            this.cadenaConexion = cadenaConexion;
            this.tabla = new DataTable ();
        }

        //Metodo para abrir la BD
        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            lector = comando.ExecuteReader();
        }

        public void actualizarBD(string consultaSQL) //Insert, update y delete
        {
            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();

        }

        public DataTable consultarBD(string consultaSQL)
        {
            conectar();
            comando.CommandText = consultaSQL;
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();

            return tabla;
        }
    }
}
