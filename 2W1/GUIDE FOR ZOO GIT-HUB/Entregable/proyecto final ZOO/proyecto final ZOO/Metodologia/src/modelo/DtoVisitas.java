/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.Date;

/**
 *
 * @author feder
 */
public class DtoVisitas {
    
     int nroVisita;
     String institucion;
     String guia;
     String recorrido;
     String representante;
     int cantVisitantes;
     Date fechaReserva;
     String horaioRecorrido;

    public DtoVisitas() {
    }

    public DtoVisitas(int nroVisita, String institucion, String guia, String recorrido, String representante, int cantVisitantes, Date fechaReserva, String horarioRecorrido) {
        this.nroVisita = nroVisita;
        this.institucion = institucion;
        this.guia = guia;
        this.recorrido = recorrido;
        this.representante = representante;
        this.cantVisitantes = cantVisitantes;
        this.fechaReserva = fechaReserva;
        this.horaioRecorrido=horarioRecorrido;
    }
    public DtoVisitas(String institucion, String guia, String recorrido, String representante, int cantVisitantes, Date fechaReserva, String horarioRecorrido) {
        
        this.institucion = institucion;
        this.guia = guia;
        this.recorrido = recorrido;
        this.representante = representante;
        this.cantVisitantes = cantVisitantes;
        this.fechaReserva = fechaReserva;
        this.horaioRecorrido=horarioRecorrido;
    }
    
        public DtoVisitas(int nroVisita) {
        this.nroVisita = nroVisita;
           }

    
    public String getHoraioRecorrido() {
        return horaioRecorrido;
    }

    public void setHoraioRecorrido(String horaioRecorrido) {
        this.horaioRecorrido = horaioRecorrido;
    }
    
    

    public int getNroVisita() {
        return nroVisita;
    }

    public void setNroVisita(int nroVisita) {
        this.nroVisita = nroVisita;
    }

    public String getInstitucion() {
        return institucion;
    }

    public void setInstitucion(String institucion) {
        this.institucion = institucion;
    }

    public String getGuia() {
        return guia;
    }

    public void setGuia(String guia) {
        this.guia = guia;
    }

    public String getRecorrido() {
        return recorrido;
    }

    public void setRecorrido(String recorrido) {
        this.recorrido = recorrido;
    }

    public String getRepresentante() {
        return representante;
    }

    public void setRepresentante(String representante) {
        this.representante = representante;
    }

    public int getCantVisitantes() {
        return cantVisitantes;
    }

    public void setCantVisitantes(int cantVisitantes) {
        this.cantVisitantes = cantVisitantes;
    }

    public Date getFechaReserva() {
        return fechaReserva;
    }

    public void setFechaReserva(Date fechaReserva) {
        this.fechaReserva = fechaReserva;
    }

    
    public String toString() {
        return "DtoVisitas{" + "nroVisita=" + nroVisita + ", institucion=" + institucion + ", guia=" + guia + ", recorrido=" + recorrido + ", representante=" + representante + ", cantVisitantes=" + cantVisitantes + ", fechaReserva=" + fechaReserva + '}';
    }
       
    public String toStringNro()
    {
       return  "nro visita es " +nroVisita;
    }
    
    

    
    
    
    
    
    
    
    
    
    
}
