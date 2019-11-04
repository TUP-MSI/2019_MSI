package Modelo;

public class Presentacion {

    private int idPresentacion;
    private int idDiaFestival;
    private int idArtista;
    private String horaInicio;
    private float duracion;

    public Presentacion(int idDiaFestival, int idArtista, String horaInicio, float duracion) {
        this.idDiaFestival = idDiaFestival;
        this.idArtista = idArtista;
        this.horaInicio = horaInicio;
        this.duracion = duracion;
    }

    public Presentacion() {
    }

    public int getIdPresentacion() {
        return idPresentacion;
    }

    public void setIdPresentacion(int idPresentacion) {
        this.idPresentacion = idPresentacion;
    }

    public int getIdDiaFestival() {
        return idDiaFestival;
    }

    public void setIdDiaFestival(int idDiaFestival) {
        this.idDiaFestival = idDiaFestival;
    }

    public int getIdArtista() {
        return idArtista;
    }

    public void setIdArtista(int idArtista) {
        this.idArtista = idArtista;
    }

    public String getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(String horaInicio) {
        this.horaInicio = horaInicio;
    }

    public float getDuracion() {
        return duracion;
    }

    public void setDuracion(float duracion) {
        this.duracion = duracion;
    }
    
    
    
}
