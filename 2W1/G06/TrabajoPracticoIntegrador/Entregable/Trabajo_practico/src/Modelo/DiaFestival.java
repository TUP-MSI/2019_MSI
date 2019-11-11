package Modelo;

public class DiaFestival {

    private int idDia;
    private String fecha;
    private String horaInicio;

    public DiaFestival(int idDia, String fecha, String horaInicio) {
        this.idDia = idDia;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
    }
    
    public DiaFestival(String fecha, String horaInicio) {
        this.fecha = fecha;
        this.horaInicio = horaInicio;
    }

    public DiaFestival() {

    }

    public int getIdDia() {
        return idDia;
    }

    public void setIdDia(int idDia) {
        this.idDia = idDia;
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public String getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(String horaInicio) {
        this.horaInicio = horaInicio;
    }

    
    
}
