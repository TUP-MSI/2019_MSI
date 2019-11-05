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
public class Institucion {
    
    int idInstitucion;
    String nombre;
    int telefono;
    String email;

    public Institucion() {
    }

    public Institucion(int idInstitucion, String nombre, int telefono, String email) {
        this.idInstitucion = idInstitucion;
        this.nombre = nombre;
        this.telefono = telefono;
        this.email = email;
    }
    
        public Institucion( String nombre, int telefono, String email) {
     
        this.nombre = nombre;
        this.telefono = telefono;
        this.email = email;
    }
    
            public Institucion(int idInstitucion, String nombre) {
        this.idInstitucion = idInstitucion;
        this.nombre = nombre;
            }

    

    public int getIdInstitucion() {
        return idInstitucion;
    }

    public void setIdInstitucion(int idInstitucion) {
        this.idInstitucion = idInstitucion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    @Override
    public String toString() {
        return "Institucion{" + "idInstitucion=" + idInstitucion + ", nombre=" + nombre + ", telefono=" + telefono + ", email=" + email + '}';
    }
 
  public String toStringComboInstitucion()  {
    
    return nombre;
}
}
