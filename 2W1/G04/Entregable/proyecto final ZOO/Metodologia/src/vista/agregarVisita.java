/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vista;

import com.toedter.calendar.JDateChooser;
import controlador.GestorVisita;
import java.awt.event.KeyEvent;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import modelo.DtoVisitas;
import modelo.Guia;
import modelo.Institucion;
import modelo.Recorrido;
import modelo.Visita;

/**
 *
 * @author PC
 */
public class agregarVisita extends javax.swing.JFrame {

    /**
     * Creates new form agregarVisita
     */
    ArrayList<Visita> listaVerificarVisita = new ArrayList();
    ArrayList<Recorrido> listaRec = new ArrayList();
    ArrayList<Guia> listaGuia = new ArrayList();
    ArrayList<Institucion> listaInstitucion = new ArrayList();
   

    public agregarVisita() {
        initComponents();

        fechaAnterior();
        cargarComboGuia();
        cargarComboInstitucion();
        cargarComboRecorrido();

    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        cbRecorrido = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        btnGuardarReserva = new javax.swing.JButton();
        btnVolverMenu = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();
        CFechaReserva = new com.toedter.calendar.JDateChooser();
        jLabel3 = new javax.swing.JLabel();
        cbInstitucion = new javax.swing.JComboBox<>();
        btnAgregar = new javax.swing.JButton();
        jLabel8 = new javax.swing.JLabel();
        txtRepresentante = new javax.swing.JTextField();
        jLabel7 = new javax.swing.JLabel();
        cbGuia = new javax.swing.JComboBox<>();
        jLabel10 = new javax.swing.JLabel();
        txtMonto = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        txtCantVisitantes = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        cbRecorrido.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 36)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Reserva De Visitas Guiadas");

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jLabel2.setText("Fecha De Reserva: ");
        jLabel2.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);

        btnGuardarReserva.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        btnGuardarReserva.setText("GUARDAR RESERVA");
        btnGuardarReserva.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarReservaActionPerformed(evt);
            }
        });

        btnVolverMenu.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        btnVolverMenu.setText("VOLVER");
        btnVolverMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnVolverMenuActionPerformed(evt);
            }
        });

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel5.setText("Recorrido:");

        CFechaReserva.setDateFormatString("yyyy/MM/dd");
        CFechaReserva.setMinSelectableDate(new Date());
        CFechaReserva.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                CFechaReservaMouseClicked(evt);
            }
        });

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jLabel3.setText("Institución: ");
        jLabel3.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);

        cbInstitucion.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N

        btnAgregar.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        btnAgregar.setText("Agregar");
        btnAgregar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregarActionPerformed(evt);
            }
        });

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel8.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jLabel8.setText("Nombre Representante:");
        jLabel8.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);

        txtRepresentante.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        txtRepresentante.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtRepresentanteActionPerformed(evt);
            }
        });
        txtRepresentante.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtRepresentanteKeyTyped(evt);
            }
        });

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel7.setText("Guia asignado:");

        cbGuia.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel10.setText("Monto / Seña:  $");

        txtMonto.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        txtMonto.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtMontoKeyTyped(evt);
            }
        });

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel9.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jLabel9.setText("Cantidad Visitantes:");
        jLabel9.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);

        txtCantVisitantes.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        txtCantVisitantes.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCantVisitantesKeyTyped(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnGuardarReserva, javax.swing.GroupLayout.PREFERRED_SIZE, 238, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnVolverMenu, javax.swing.GroupLayout.PREFERRED_SIZE, 259, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(287, 287, 287))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(189, 189, 189)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel8)
                            .addComponent(jLabel5)
                            .addComponent(jLabel7)
                            .addComponent(jLabel10)
                            .addComponent(jLabel9)
                            .addComponent(jLabel3))
                        .addGap(30, 30, 30)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(CFechaReserva, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(txtRepresentante, javax.swing.GroupLayout.PREFERRED_SIZE, 202, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                        .addComponent(txtCantVisitantes, javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(txtMonto, javax.swing.GroupLayout.PREFERRED_SIZE, 202, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGap(179, 179, 179))
                                .addComponent(cbGuia, javax.swing.GroupLayout.PREFERRED_SIZE, 202, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(cbInstitucion, javax.swing.GroupLayout.PREFERRED_SIZE, 202, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(45, 45, 45)
                                .addComponent(btnAgregar, javax.swing.GroupLayout.PREFERRED_SIZE, 135, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(cbRecorrido, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(221, 221, 221)
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 547, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(173, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(89, 89, 89)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cbInstitucion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel3)
                    .addComponent(btnAgregar))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(43, 43, 43)
                        .addComponent(jLabel8)
                        .addGap(18, 19, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(txtRepresentante, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(CFechaReserva, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(36, 36, 36)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(cbRecorrido, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5))
                .addGap(61, 61, 61)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel7)
                    .addComponent(cbGuia, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(49, 49, 49)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtMonto, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel10))
                .addGap(54, 54, 54)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtCantVisitantes, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel9))
                .addGap(93, 93, 93)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnVolverMenu, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnGuardarReserva, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(31, 31, 31))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtRepresentanteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtRepresentanteActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtRepresentanteActionPerformed

    private void CFechaReservaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_CFechaReservaMouseClicked


    }//GEN-LAST:event_CFechaReservaMouseClicked

    private void btnAgregarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregarActionPerformed
        altaInstitucion vi = new altaInstitucion();
        vi.setLocationRelativeTo(null);
        vi.setVisible(true);
        vi.setTitle("Agregar Nueva Institucion");
        this.dispose();

    }//GEN-LAST:event_btnAgregarActionPerformed

    private void btnGuardarReservaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarReservaActionPerformed
     
      GestorVisita gv = new GestorVisita();
    int      listaNro = gv.listaVisitaNro()+1;
        
        
        try {
            if (validar()) 
            {
                int idInstitucion = devolveridInstitucion(cbInstitucion.getSelectedItem().toString());
                int idGuia = devolveridGuia((cbGuia.getSelectedItem().toString()));
                int idRecorrido = devolveridRecorrido((cbRecorrido.getSelectedItem().toString()));
                String nombreRepresentante = txtRepresentante.getText();
                int cantVisi = Integer.parseInt(txtCantVisitantes.getText());
                float monto = Float.parseFloat(txtMonto.getText());
                Date fecha = NewClass.convert(CFechaReserva.getDate());
                //   Date fechaReserva = jCalendar1.getDate();
                // Date fechaReserva = CFechaReserva.getDate();

                int resultado = new GestorVisita().registrarVisita(new Visita(0, idInstitucion, idGuia, idRecorrido, nombreRepresentante, cantVisi, monto, fecha));
                if (resultado == -1) {
                    JOptionPane.showMessageDialog(null, "ERROR AL CARGAR");
                } else {
                    JOptionPane.showMessageDialog(null, "VISITA GUARDADA EXITOSAMENTE SU NUMERO DE VISITA ES " + listaNro);
                }

            }
        } catch (Exception e) {
           System.out.println(e);
           JOptionPane.showMessageDialog(null, "ERROR AL CARGAR");
        }

    }//GEN-LAST:event_btnGuardarReservaActionPerformed

    private void btnVolverMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnVolverMenuActionPerformed
        menuEmpleado e = new menuEmpleado();
        e.setVisible(true);
        e.setLocationRelativeTo(null);
        e.setTitle("Menu Principal");
        this.dispose();
    }//GEN-LAST:event_btnVolverMenuActionPerformed

    private void txtRepresentanteKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtRepresentanteKeyTyped
        // TODO add your handling code here:
        char validar = evt.getKeyChar();
        if (Character.isDigit(validar)) {
            getToolkit().beep();
            evt.consume();
            JOptionPane.showMessageDialog(null, "NO PUEDE INGRESAR NUMEROS EN EL NOMBRE DEL REPRESENTANTE");

        }
    }//GEN-LAST:event_txtRepresentanteKeyTyped

    private void txtMontoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtMontoKeyTyped
        // TODO add your handling code here:
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();
            JOptionPane.showMessageDialog(null, "ERROR !!!  NO PUEDE INGRESAR LETRAS");

    }//GEN-LAST:event_txtMontoKeyTyped
    }
    
    
    public void keyTyped(KeyEvent e)
    {
        if(txtCantVisitantes.getText().length()==3)
        {
            e.consume();
        }
        
    }
    
    
    
    
    private void txtCantVisitantesKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCantVisitantesKeyTyped
        // TODO add your handling code here:

        char validar = evt.getKeyChar();
        

        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();
            JOptionPane.showMessageDialog(null, "EEROR !!!  NO PUEDE INGRESAR LETRAS");
        }
       if (txtCantVisitantes.getText().length() == 3) {
            evt.consume();
        }
    }//GEN-LAST:event_txtCantVisitantesKeyTyped
    

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(agregarVisita.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(agregarVisita.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(agregarVisita.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(agregarVisita.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new agregarVisita().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private com.toedter.calendar.JDateChooser CFechaReserva;
    private javax.swing.JButton btnAgregar;
    private javax.swing.JButton btnGuardarReserva;
    private javax.swing.JButton btnVolverMenu;
    private javax.swing.JComboBox<String> cbGuia;
    private javax.swing.JComboBox<String> cbInstitucion;
    private javax.swing.JComboBox<String> cbRecorrido;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JTextField txtCantVisitantes;
    private javax.swing.JTextField txtMonto;
    private javax.swing.JTextField txtRepresentante;
    // End of variables declaration//GEN-END:variables

    private void fechaAnterior() {

        Calendar now = Calendar.getInstance();
        int year = now.get(Calendar.YEAR);
        int month = now.get(Calendar.MONTH) + 1; // Note: zero based!
        int day = now.get(Calendar.DAY_OF_MONTH);
        int hour = now.get(Calendar.HOUR_OF_DAY);
        int minute = now.get(Calendar.MINUTE);
        int second = now.get(Calendar.SECOND);
        int millis = now.get(Calendar.MILLISECOND);

        Date hoy = new Date();
        Date ayer = new Date();

        JDateChooser chooser = new JDateChooser();
        chooser.setMaxSelectableDate(ayer);

        chooser.setDateFormatString("dd-MM-yyyy");

        chooser.setDate(new Date());
    }

    
    
    
    private int devolveridRecorrido(String recNombre) {
        for (Recorrido rec : listaRec) {
            if (recNombre.equals(rec.toStringComboRecorrido())) {
                return rec.getNroRecorrido();
            }
        }
        return 0;
    }

    private void cargarComboRecorrido() {
        listaRec = new GestorVisita().ListaRecorrido();

        DefaultComboBoxModel dc = new DefaultComboBoxModel();

        for (Recorrido rec : listaRec) {
            dc.addElement(rec.toStringComboRecorrido());

        }
        cbRecorrido.setModel(dc);

    }

    private int devolveridGuia(String nombreGuia) {
        for (Guia gui : listaGuia) {
            if (nombreGuia.equals(gui.toStringComboGuia())) {
                return gui.getIdGuia();
            }
        }
        return 0;
    }

    private void cargarComboGuia() {
        listaGuia = new GestorVisita().ListaGuia();

        DefaultComboBoxModel dc = new DefaultComboBoxModel();

        for (Guia rec : listaGuia) {
            dc.addElement(rec.toStringComboGuia());

        }
        cbGuia.setModel(dc);

    }

    private int devolveridInstitucion(String nombreInstitucion) {
        for (Institucion inst : listaInstitucion) {
            if (nombreInstitucion.equals(inst.toStringComboInstitucion())) {
                return inst.getIdInstitucion();
            }
        }
        return 0;
    }

    public void cargarComboInstitucion() {
        listaInstitucion = new GestorVisita().ListaInstitucion();

        DefaultComboBoxModel dc = new DefaultComboBoxModel();

        for (Institucion rec : listaInstitucion) {
            dc.addElement(rec.toStringComboInstitucion());

        }
        cbInstitucion.setModel(dc);

    }

    Calendar now = Calendar.getInstance();
    int year = now.get(Calendar.YEAR);
    int month = now.get(Calendar.MONTH) + 1; // Note: zero based!
    int day = now.get(Calendar.DAY_OF_MONTH);
    int hour = now.get(Calendar.HOUR_OF_DAY);
    int minute = now.get(Calendar.MINUTE);
    int second = now.get(Calendar.SECOND);
    int millis = now.get(Calendar.MILLISECOND);

    private boolean validar() {
        boolean flag = true;
        String mensaje = "";
      int a=Integer.parseInt(txtCantVisitantes.getText());
           
        if(a>100){
            flag = false;
            mensaje += "EL CUPO MAXIMO ES 100 \n";
        }
         
        if (txtRepresentante.getText().isEmpty()) {
            flag = false;
            mensaje += "EL NOMBRE DEL REPRESENTANTE NO PUEDE QUEDAR VACIO \n";
        }

        if (txtMonto.getText().isEmpty()) {
            flag = false;
            mensaje += "El MONTO DE LA SEÑA NO PUEDE QUEDAR VACIO! \n";
        } else {
            try {
                Double.parseDouble(txtMonto.getText());
            } catch (Exception e) {
                flag = false;
                mensaje += "El MONTO DE LA SEÑA TIENE QUE SER NUMERICO! \n";
            }
        }

        if (txtCantVisitantes.getText().isEmpty()) {
            flag = false;
            mensaje += "LA CANTIDAD DE VISITANTES NO PUEDE QUEDAR VACIA \n";
        } else {
            try {
                Double.parseDouble(txtMonto.getText());
            } catch (Exception e) {
                flag = false;
                mensaje += "LA CANTIDAD DE VISITANTES TIENE QUE SER NUMERICO";
            }
        }

        if (!flag) {
            JOptionPane.showMessageDialog(null, mensaje);

        }
        return flag;
    }
}
