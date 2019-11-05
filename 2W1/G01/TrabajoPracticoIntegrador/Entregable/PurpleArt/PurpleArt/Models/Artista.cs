using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class Artista
    {
        private int idArtista;
        private String nombreArtista;
        private String apellidoArtista;
        private String fechaNac;
        private String detalle;
        private Localidad localidad;


        public Artista(){
            localidad = new Localidad();
            fechaNac = DateTime.Today.ToString("dd/MM/yy"); 
        }

        public int IdArtista { get => idArtista; set => idArtista = value; }
        public string NombreArtista { get => nombreArtista; set => nombreArtista = value; }
        public string ApellidoArtista { get => apellidoArtista; set => apellidoArtista = value; }
        public String FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Localidad Localidad { get => localidad; set => localidad = value; }
       
    }
}