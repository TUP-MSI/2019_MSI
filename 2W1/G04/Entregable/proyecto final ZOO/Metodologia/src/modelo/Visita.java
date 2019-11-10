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
public class Visita {
    int nroVisita;
    int idInstitucion;
    int idGuia;
    int nroRecorrido;
    String representante;
    int cantVisitantes;
    float montoSeña;
   Date fechaReserva;

    public Visita() {
    }

    public Visita(int nroVisita, int idInstitucion, int idGuia, int nroRecorrido, String representante, int cantVisitantes, float montoSeña, Date fechaReserva) {
        this.nroVisita = nroVisita;
        this.idInstitucion = idInstitucion;
        this.idGuia = idGuia;
        this.nroRecorrido = nroRecorrido;
        this.representante = representante;
        this.cantVisitantes = cantVisitantes;
        this.montoSeña = montoSeña;
        this.fechaReserva = fechaReserva;
    }
        public Visita(int idInstitucion, int idGuia, int nroRecorrido, String representante, int cantVisitantes, float montoSeña, Date fechaReserva) {
        
        this.idInstitucion = idInstitucion;
        this.idGuia = idGuia;
        this.nroRecorrido = nroRecorrido;
        this.representante = representante;
        this.cantVisitantes = cantVisitantes;
        this.montoSeña = montoSeña;
        this.fechaReserva = fechaReserva;
    }
        
               public Visita( int nroVisita, int nroRecorrido) {
         this.nroVisita = nroVisita;
       
        
        this.nroRecorrido = nroRecorrido;
        
    }

    public int getNroVisita() {
        return nroVisita;
    }

    public void setNroVisita(int nroVisita) {
        this.nroVisita = nroVisita;
    }

    public int getIdInstitucion() {
        return idInstitucion;
    }

    public void setIdInstitucion(int idInstitucion) {
        this.idInstitucion = idInstitucion;
    }

    public int getIdGuia() {
        return idGuia;
    }

    public void setIdGuia(int idGuia) {
        this.idGuia = idGuia;
    }

    public int getNroRecorrido() {
        return nroRecorrido;
    }

    public void setNroRecorrido(int nroRecorrido) {
        this.nroRecorrido = nroRecorrido;
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

    public float getMontoSeña() {
        return montoSeña;
    }

    public void setMontoSeña(float montoSeña) {
        this.montoSeña = montoSeña;
    }

    public Date getFechaReserva() {
        return fechaReserva;
    }

    public void setFechaReserva(Date fechaReserva) {
        this.fechaReserva = fechaReserva;
    }
 

    @Override
    public String toString() {
        return "Visita{" + "nroVisita=" + nroVisita + ", idInstitucion=" + idInstitucion + ", idGuia=" + idGuia + ", nroRecorrido=" + nroRecorrido + ", representante=" + representante + ", cantVisitantes=" + cantVisitantes + ", montoSe\u00f1a=" + montoSeña + ", fechaReserva=" + fechaReserva + '}';
    }
    
    
    
    
}
