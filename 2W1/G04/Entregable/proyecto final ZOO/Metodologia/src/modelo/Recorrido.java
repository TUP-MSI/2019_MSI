/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

/**
 *
 * @author feder
 */
public class Recorrido {
    int nroRecorrido;
    String puntosDePaseo;
    int precioXpersona;
    int duracionMinutos;
    String horarioRecorrido;
    int cupo;
    String nombre;
    

    public Recorrido() {
    }

    public Recorrido(int nroRecorrido, String puntosDePaseo, int precioXpersona, int duracionMinutos, String horarioRecorrido ,int cupo, String nombre) {
        this.nroRecorrido = nroRecorrido;
        this.puntosDePaseo = puntosDePaseo;
        this.precioXpersona = precioXpersona;
        this.duracionMinutos = duracionMinutos;
        this.horarioRecorrido= horarioRecorrido;
        this.cupo = cupo;
        this.nombre = nombre;
    }

    public String getHorarioRecorrido() {
        return horarioRecorrido;
    }

    public void setHorarioRecorrido(String horarioRecorrido) {
        this.horarioRecorrido = horarioRecorrido;
    }
    
    
        public Recorrido(int nroRecorrido, String nombre, String horarioRecorrido) {
        this.nroRecorrido = nroRecorrido;
        this.nombre = nombre;
        this.horarioRecorrido=horarioRecorrido;
    }

    public int getNroRecorrido() {
        return nroRecorrido;
    }

    public void setNroRecorrido(int nroRecorrido) {
        this.nroRecorrido = nroRecorrido;
    }

    public String getPuntosDePaseo() {
        return puntosDePaseo;
    }

    public void setPuntosDePaseo(String puntosDePaseo) {
        this.puntosDePaseo = puntosDePaseo;
    }

    public int getPrecioXpersona() {
        return precioXpersona;
    }

    public void setPrecioXpersona(int precioXpersona) {
        this.precioXpersona = precioXpersona;
    }

    public int getDuracionMinutos() {
        return duracionMinutos;
    }

    public void setDuracionMinutos(int duracionMinutos) {
        this.duracionMinutos = duracionMinutos;
    }

    public int getCupo() {
        return cupo;
    }

    public void setCupo(int cupo) {
        this.cupo = cupo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public String toString() {
        return "Recorrido{" + "nroRecorrido=" + nroRecorrido + ", puntosDePaseo=" + puntosDePaseo + ", precioXpersona=" + precioXpersona + ", duracionMinutos=" + duracionMinutos + ", cupo=" + cupo + ", nombre=" + nombre + '}';
    }
    
    public String toStringComboRecorrido()
            {
                return nombre + " HS: "+horarioRecorrido;
            }
    
    
}
