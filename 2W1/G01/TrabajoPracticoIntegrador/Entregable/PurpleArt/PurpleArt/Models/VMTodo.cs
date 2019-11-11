using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class VMTodo
    {
        private Artista artista = new Artista();
        private Obra obra = new Obra();

        private Locker locker = new Locker();
        private int localidad;

        public List<Locker> ListaLocker {get; set;}

        public List<Obra> ListaObra {get; set;}
        public List<TipoObra> ListaTipo {get; set;}
        public List<Estilo> ListaEstilo {get; set;} 
        public List<Artista> ListaArtistas { get; set; }
        public List<Localidad> Localidades { get; set; }
        public List<Provincia> Provincias { get; set; }
        public List<Pais> Paises { get; set; }
        public Artista Artista { get => artista; set => artista = value; }
        public Obra Obra { get => obra; set => obra = value; }
        public int Localidad { get => localidad; set => localidad = value; }
        public Locker Locker { get => locker; set => locker = value; }
    }
}