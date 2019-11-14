/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controlador;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;

import modelo.DtoVisitas;
import modelo.Guia;
import modelo.Institucion;
import modelo.Recorrido;
import modelo.Usuario;
import modelo.Visita;
import vista.NewClass;


/**
 *
 * @author feder
 */
public class GestorVisita {
    
       private static final String cadena = "jdbc:sqlserver://DESKTOP-Q1S2VDH\\SQLEXPRESS:1433;databaseName=finalZoologico";
	private static final String user = "sa";
	private static final String pass = "sa";
        
        
        
            public int registrarInstitucion(Institucion g){
    try(Connection con = DriverManager.getConnection(cadena, user, pass)) {
      PreparedStatement ps = con.prepareStatement("insert into Institucion values (?,?,?)");
      ps.setString(1, g.getNombre());
    
      ps.setInt(2, g.getTelefono());
      ps.setString(3, g.getEmail());
      ps.executeUpdate();
      ps.close();
      
      Statement st =con.createStatement();
            ResultSet rs=st.executeQuery("select top 1 idInstitucion from institucion order by 1 desc");
            rs.next();
            int resultado = rs.getInt(1);
            rs.close();
            st.close();
            return resultado;
     }
                    
      catch (SQLException e) {
                    System.out.println(e);
                    return -1;
                    
                }
        
            }
            
            
        //  ps.setDate(7, (Date) FechaReservaATR(v));
            
         public int registrarVisita(Visita v){
    try(Connection con = DriverManager.getConnection(cadena, user, pass)) {
        
         NewClass convertor = new NewClass();
      PreparedStatement ps = con.prepareStatement("insert into visita values (?,?,?,?,?,?,?)");
      
      
      ps.setInt(1, v.getIdInstitucion());
       ps.setInt(2, v.getIdGuia());
        ps.setInt(3, v.getNroRecorrido());
      ps.setString(4, v.getRepresentante());
      ps.setInt(5, v.getCantVisitantes());
      ps.setFloat(6, v.getMontoSeña());
       ps.setDate(7, convertor.convert(v.getFechaReserva()));
      
      
            
        
      
      ps.executeUpdate();
      ps.close();
         
      Statement st =con.createStatement();
            ResultSet rs=st.executeQuery("select top 1 NroVisita from visita order by 1 desc");
            rs.next();
            int resultado = rs.getInt(1);
            rs.close();
            st.close();
            return resultado;
     }
    
    
                    
      catch (SQLException e) {
                    System.out.println(e);
                    return -1;
                    
                }
        
            }
          
            
      public ArrayList<Recorrido> ListaRecorrido()
        {
            ArrayList<Recorrido> lista = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select nroRecorrido, nombre , horarioRecorrido from recorrido ");
      
       while(rs.next())
       {
           int idRecorrido= rs.getInt(1);
          String nombre = rs.getString(2);
          String horarioRecorrido = rs.getString(3);
           
          
          Recorrido r = new Recorrido(idRecorrido,nombre,horarioRecorrido);
	 lista.add(r);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return lista;
            
  }

       public ArrayList<Guia> ListaGuia()
        {
            ArrayList<Guia> lista = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select idGuia, nombreGuia from Guia");
      
       while(rs.next())
       {
           int idGuia= rs.getInt(1);
          String nombreGuia = rs.getString(2);
           
          
          Guia g = new Guia(idGuia,nombreGuia);
	 lista.add(g);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return lista;
            
  }

    public ArrayList<Institucion> ListaInstitucion()
        {
            ArrayList<Institucion> lista = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select idInstitucion, nombre from Institucion");
      
       while(rs.next())
       {
           int idInstitucion= rs.getInt(1);
          String nombre = rs.getString(2);
           
          
          Institucion g = new Institucion(idInstitucion,nombre);
	 lista.add(g);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return lista;
            
  }
    
    
                 public int registrarUss(Usuario u){
    try(Connection con = DriverManager.getConnection(cadena, user, pass)) {
      PreparedStatement ps = con.prepareStatement("insert into usuario values (?,?,?)");
      ps.setString(1, u.getUsuario());
        ps.setString(2, u.getPass());
      ps.setInt(3, u.getAccesLevel());
      
      ps.executeUpdate();
      ps.close();
      
      Statement st =con.createStatement();
            ResultSet rs=st.executeQuery("select top 1 usuario from usuario order by 1 desc");
            rs.next();
            int resultado = rs.getInt(1);
            rs.close();
            st.close();
            return resultado;
     }
                    
      catch (SQLException e) {
                    System.out.println(e);
                    return -1;
                    
                }
        
            }
  
        

                 
                     public ArrayList<Visita> listaVisitaReal()
        {
            ArrayList<Visita> lista = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select nroVisita,nroRecorrido from visita");
      
       while(rs.next())
       {
             int nrovisita= rs.getInt(1);
              int nrorecorrido = rs.getInt(2);
           
          
         Visita g = new Visita(nrovisita,nrorecorrido);
	 lista.add(g);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return lista;
            
  }
    
    
               
             

         
        public ArrayList<DtoVisitas> listaVisita()
        {
            ArrayList<DtoVisitas> listav = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select v.NroVisita,i.nombre,g.nombreGuia,r.nombre,v.representante,v.cantVisitantes,v.fechaReserva, r.horarioRecorrido from visita v inner join Guia g on g.idGuia = v.idGuia inner join Institucion i on i.idInstitucion = v.idInstitucion inner join recorrido r on r.nroRecorrido = v.NroRecorrido");
      
       while(rs.next())
       {
           int nroVisita= rs.getInt(1);
          String ins = rs.getString(2);
          String guia = rs.getString(3);
          String reco = rs.getString(4);
          String repre = rs.getString(5);
           int cantvisi= rs.getInt(6);
           Date fechaReserva = rs.getDate(7);
           String horarioRecorrido = rs.getString(8);
           
          
           DtoVisitas dtov = new DtoVisitas(nroVisita, ins, guia, reco, repre, cantvisi, fechaReserva,horarioRecorrido);
	   listav.add(dtov);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return listav;
            
  }
        
          
         public int  listaVisitaNro()
        {
           int listav = 0;
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select top 1 NroVisita from visita  order by  nroVisita desc");
      
       while(rs.next())
       {
           int nroVisita= rs.getInt(1);
          
           
          
           listav= nroVisita;
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return listav;
            
  }
        
//        
//         public ArrayList<DtoVisitas> listaVisitaNro()
//        {
//            ArrayList<DtoVisitas> listav = new ArrayList();
//            
//             try(Connection con=DriverManager.getConnection(cadena, user, pass))
//   {
//       
//       Statement stmt = con.createStatement();
//       ResultSet rs = stmt.executeQuery("select top 1 NroVisita from visita  order by  nroVisita desc");
//      
//       while(rs.next())
//       {
//           int nroVisita= rs.getInt(1);
//          
//           
//          
//           DtoVisitas dtov = new DtoVisitas(nroVisita);
//	   listav.add(dtov);
//       }
//       
//        rs.close();
//       stmt.close();
//        }
//     catch(SQLException ex)
//   {
//       System.out.println(ex);
//   }
//   return listav;
//            
//  }
        
        
        public void verificarFechayRecorrido(Date fecha , int nro)
        {
              try(Connection con=DriverManager.getConnection(cadena, user, pass))
              {
       
         Statement stmt = con.createStatement();
             String query = "exec verificarFecha ?,?";
       
          PreparedStatement ps = con.prepareStatement(query);
            ps.setDate(1, NewClass.convert(fecha));
            ps.setInt(2, nro);
            ResultSet rs = ps.executeQuery();
            
            
            
        }
              
              catch(Exception e)
              {
                  System.out.println("e");
              }
            
       
        }
  
        
          public ArrayList<DtoVisitas> listaVisitaParametrizada(int buscarID)
        {
            ArrayList<DtoVisitas> listav = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       String query = "exec visitaParametrizada2 ?";
       
          PreparedStatement ps = con.prepareStatement(query);
            ps.setInt(1, buscarID);
            ResultSet rs = ps.executeQuery();
            
      
       while(rs.next())
       {
           int nroVisita= rs.getInt(1);
          String ins = rs.getString(2);
          String guia = rs.getString(3);
          String reco = rs.getString(4);
          String repre = rs.getString(5);
           int cantvisi= rs.getInt(6);
           Date fechaReserva = rs.getDate(7);
           String horarioRecorrido=rs.getString(8);
           
          
           DtoVisitas dtov = new DtoVisitas(nroVisita, ins, guia, reco, repre, cantvisi, fechaReserva,horarioRecorrido);
	   listav.add(dtov);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return listav;
            
  }
          
          public void deleteVisita(int id){
        try(Connection conn = DriverManager.getConnection(cadena, user, pass)){
            String query = "delete from visita where NroVisita = ?";
            PreparedStatement ps = conn.prepareStatement(query);
            ps.setInt(1, id);
            ps.executeUpdate();
            ps.close();
            
        }
        catch(SQLException e){
            System.out.println(e);
        }
    }
          
          
          
                 public ArrayList<Usuario> listaUsuario()
        {
            ArrayList<Usuario> listau = new ArrayList();
            
             try(Connection con=DriverManager.getConnection(cadena, user, pass))
   {
       
       Statement stmt = con.createStatement();
       ResultSet rs = stmt.executeQuery("select * from usuario");
      
       while(rs.next())
       {
           String us= rs.getString(1);
          String pass = rs.getString(2);
             int nivel = rs.getInt(3);
     ;
           
          
          Usuario dtov = new Usuario(us,pass,nivel);
	   listau.add(dtov);
       }
       
        rs.close();
       stmt.close();
        }
     catch(SQLException ex)
   {
       System.out.println(ex);
   }
   return listau;
            
  }
      
          
          
    
}


