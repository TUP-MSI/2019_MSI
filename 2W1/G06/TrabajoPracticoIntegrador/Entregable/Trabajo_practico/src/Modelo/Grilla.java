package Modelo;


public class Grilla {
    
    private String dia;
    private String artista;
    private String hora;
    private float duracion;

    public Grilla() {
    }

    public Grilla(String dia, String artista, String hora, float duracion) {
        this.dia = dia;
        this.artista = artista;
        this.hora = hora;
        this.duracion = duracion;
    }

    public String getDia() {
        return dia;
    }

    public void setDia(String dia) {
        this.dia = dia;
    }

    public String getArtista() {
        return artista;
    }

    public void setArtista(String artista) {
        this.artista = artista;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }

    public float getDuracion() {
        return duracion;
    }

    public void setDuracion(float duracion) {
        this.duracion = duracion;
    }
    
    
    
    
}
