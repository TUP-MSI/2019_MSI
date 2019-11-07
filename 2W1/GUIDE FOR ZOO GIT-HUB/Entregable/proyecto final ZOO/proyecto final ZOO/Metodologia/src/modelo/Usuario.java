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
public class Usuario {
    String usuario;
    String pass;
    int accesLevel;

    public Usuario() {
    }

    public Usuario(String usuario, String pass, int accesLevel) {
        this.usuario = usuario;
        this.pass = pass;
        this.accesLevel = accesLevel;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getPass() {
        return pass;
    }

    public void setPass(String pass) {
        this.pass = pass;
    }

    public int getAccesLevel() {
        return accesLevel;
    }

    public void setAccesLevel(int accesLevel) {
        this.accesLevel = accesLevel;
    }

    @Override
    public String toString() {
        return "Usuario{" + "usuario=" + usuario + ", pass=" + pass + ", accesLevel=" + accesLevel + '}';
    }
    
    
    
}
