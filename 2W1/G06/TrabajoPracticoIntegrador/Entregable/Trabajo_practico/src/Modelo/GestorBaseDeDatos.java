package Modelo;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.ResultSetMetaData;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class GestorBaseDeDatos {

    private static Connection conector;

    private Connection getConexion() {

        String url = "jdbc:sqlserver://turcoDesktop\\MSSQLSERVER:1433;databaseName=festival";
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        } catch (ClassNotFoundException e) {
            JOptionPane.showMessageDialog(null, "No se pudo establecer la conexion, revisar DRIVER" + e.getMessage(), "Error de Conexion", JOptionPane.ERROR_MESSAGE);
        }

        try {
            conector = DriverManager.getConnection(url, "sa", "lucero");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error" + e.getMessage(), "Error de Conexion", JOptionPane.ERROR_MESSAGE);
        }

        return conector;
    }

    private void cerrarConexion() throws SQLException {
        conector.close();
    }

    public void cargarDiaFestival(DiaFestival r) {

        try {
            Connection conexion = getConexion();
            PreparedStatement stmt;

            stmt = conexion.prepareStatement("INSERT INTO dia_festival (fecha, hora_inicio) values (?, ?)");
            stmt.setString(1, r.getFecha());
            stmt.setString(2, r.getHoraInicio());

            stmt.executeUpdate();
            stmt.close();

            cerrarConexion();

            JOptionPane.showMessageDialog(null, "Carga realizada correctamente");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error" + e.getMessage(), "Error al cargar reparacion", JOptionPane.ERROR_MESSAGE);
        }
    }

    public void cargarArtista(Artista a) {

        try {
            Connection conexion = getConexion();
            PreparedStatement stmt;

            stmt = conexion.prepareStatement("INSERT INTO artistas (nombre, integrantes, precio_hora) values (?, ?, ?)");
            stmt.setString(1, a.getNombre());
            stmt.setInt(2, a.getCantidadIntegrantes());
            stmt.setFloat(3, a.getPrecioHora());

            stmt.executeUpdate();
            stmt.close();

            cerrarConexion();

            JOptionPane.showMessageDialog(null, "Carga realizada correctamente");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error" + e.getMessage(), "Error al cargar reparacion", JOptionPane.ERROR_MESSAGE);
        }
    }

    public void cargarPresentacion(Presentacion p) {

        try {
            Connection conexion = getConexion();
            PreparedStatement stmt;

            stmt = conexion.prepareStatement("INSERT INTO presentaciones (id_dia, id_artista, hora_inicio_aprox, duracion_hs) values (?, ?, ?, ?)");
            stmt.setInt(1, p.getIdDiaFestival());
            stmt.setInt(2, p.getIdArtista());
            stmt.setString(3, p.getHoraInicio());
            stmt.setFloat(4, p.getDuracion());

            stmt.executeUpdate();
            stmt.close();

            cerrarConexion();

            JOptionPane.showMessageDialog(null, "Carga realizada correctamente");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error" + e.getMessage(), "Error al cargar reparacion", JOptionPane.ERROR_MESSAGE);
        }
    }

    public ArrayList<DiaFestival> listarDiaFestival() {

        ArrayList<DiaFestival> listaCombo = new ArrayList<>();

        try {
            Connection conexion = getConexion();

            Statement declaracion = conexion.createStatement();

            ResultSet resultado = declaracion.executeQuery("SELECT * FROM dia_festival");

            while (resultado.next()) {

                int id = resultado.getInt("id_dia");
                String horaInicio = resultado.getString("hora_inicio");
                String fecha = resultado.getString("fecha");

                DiaFestival d = new DiaFestival(id, fecha, horaInicio);
                listaCombo.add(d);
            }

            resultado.close();

            declaracion.close();

            cerrarConexion();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage(), "Error al cargar combobox", JOptionPane.ERROR_MESSAGE);
        }

        return listaCombo;
    }

    public ArrayList<Artista> listarArtistas() {

        ArrayList<Artista> listaCombo = new ArrayList<>();

        try {
            Connection conexion = getConexion();

            Statement declaracion = conexion.createStatement();

            ResultSet resultado = declaracion.executeQuery("SELECT * FROM artistas");

            while (resultado.next()) {

                int id = resultado.getInt("id_artista");
                String nombre = resultado.getString("nombre");
                int integrantes = resultado.getInt("integrantes");
                float precioHora = resultado.getFloat("precio_hora");

                Artista d = new Artista(id, nombre, integrantes, precioHora);
                listaCombo.add(d);
            }

            resultado.close();

            declaracion.close();

            cerrarConexion();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage(), "Error al cargar combobox", JOptionPane.ERROR_MESSAGE);
        }

        return listaCombo;
    }

    public ArrayList<Grilla> listaGrilla() {

        ArrayList<Grilla> listaGrilla = new ArrayList<>();

        try {
            Connection conexion = getConexion();

            Statement declaracion = conexion.createStatement();

            ResultSet resultado = declaracion.executeQuery("select fecha, nombre, hora_inicio_aprox, duracion_hs \n" +
                                                           "from presentaciones p join artistas a  on p.id_artista = a.id_artista\n" +
                                                                                "join dia_festival d on p.id_dia = d.id_dia\n" +
                                                           "order by d.fecha asc, duracion_hs");

            while (resultado.next()) {

                String fecha = resultado.getString("fecha");
                String nombre = resultado.getString("nombre");
                String hora = resultado.getString("hora_inicio_aprox");
                float duracion = resultado.getFloat("duracion_hs");
                Grilla d = new Grilla(fecha, nombre, hora, duracion);
                listaGrilla.add(d);
            }

            resultado.close();

            declaracion.close();

            cerrarConexion();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage(), "Error al cargar grilla", JOptionPane.ERROR_MESSAGE);
        }

        return listaGrilla;
    }

}
