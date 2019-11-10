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
public class Guia {
    
    int idGuia;
    String legajoGuia;
    String nombreGuia;
    int telefono;

    public Guia() {
    }

    public Guia(int idGuia, String legajoGuia, String nombreGuia, int telefono) {
        this.idGuia = idGuia;
        this.legajoGuia = legajoGuia;
        this.nombreGuia = nombreGuia;
        this.telefono = telefono;
    }
    
        public Guia(int idGuia,String nombreGuia) {
        this.idGuia = idGuia;
        this.nombreGuia = nombreGuia;
 
    }

    public int getIdGuia() {
        return idGuia;
    }

    public void setIdGuia(int idGuia) {
        this.idGuia = idGuia;
    }

    public String getLegajoGuia() {
        return legajoGuia;
    }

    public void setLegajoGuia(String legajoGuia) {
        this.legajoGuia = legajoGuia;
    }

    public String getNombreGuia() {
        return nombreGuia;
    }

    public void setNombreGuia(String nombreGuia) {
        this.nombreGuia = nombreGuia;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Guia{" + "idGuia=" + idGuia + ", legajoGuia=" + legajoGuia + ", nombreGuia=" + nombreGuia + ", telefono=" + telefono + '}';
    }
    
    public String toStringComboGuia()
    {
        return nombreGuia;
    }
    
    
}
