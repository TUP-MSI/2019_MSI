using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Obra
    {
        private int codigo;
        private String nombre;
        private Estilo estilo;
        private TipoObra tipoObra;
        private Artista artista;
        private String descripcion;
        private String dimension;
        private float valuacion;
        private String estadoObra;
        private Boolean disponibilidad;
        private String fechaCreacion;

        public Obra(){
            estilo = new Estilo();
            tipoObra = new TipoObra();
            artista = new Artista();
            fechaCreacion = DateTime.Today.ToString("dd/MM/yy");
            disponibilidad = true;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Estilo Estilo { get => estilo; set => estilo = value; }
        public TipoObra TipoObra { get => tipoObra; set => tipoObra = value; }
        public Artista Artista { get => artista; set => artista = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Dimension { get => dimension; set => dimension = value; }
        public float Valuacion { get => valuacion; set => valuacion = value; }
        public string EstadoObra { get => estadoObra; set => estadoObra = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public String FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}