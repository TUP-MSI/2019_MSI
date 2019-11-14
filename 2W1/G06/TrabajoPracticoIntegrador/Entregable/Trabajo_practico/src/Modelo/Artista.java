package Modelo;

public class Artista {

    private int idArtista;
    private String nombre;
    private int cantidadIntegrantes;
    private float precioHora;

    public Artista(int idArtista, String nombre, int cantidadIntegrantes, float precioHora) {
        this.idArtista = idArtista;
        this.nombre = nombre;
        this.cantidadIntegrantes = cantidadIntegrantes;
        this.precioHora = precioHora;
    }
    

    public Artista(String nombre, int cantidadIntegrantes, float precioHora) {
        this.nombre = nombre;
        this.cantidadIntegrantes = cantidadIntegrantes;
        this.precioHora = precioHora;
    }

    public Artista() {

    }

    public int getIdArtista() {
        return idArtista;
    }

    public void setIdArtista(int idArtista) {
        this.idArtista = idArtista;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCantidadIntegrantes() {
        return cantidadIntegrantes;
    }

    public void setCantidadIntegrantes(int cantidadIntegrantes) {
        this.cantidadIntegrantes = cantidadIntegrantes;
    }

    public float getPrecioHora() {
        return precioHora;
    }

    public void setPrecioHora(float precioHora) {
        this.precioHora = precioHora;
    }

    
    
    
}
