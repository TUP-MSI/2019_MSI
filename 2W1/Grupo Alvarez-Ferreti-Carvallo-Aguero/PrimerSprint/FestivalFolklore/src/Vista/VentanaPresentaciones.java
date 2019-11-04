package Vista;

import Modelo.*;
import javax.swing.DefaultComboBoxModel;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class VentanaPresentaciones extends javax.swing.JFrame {

    private GestorBaseDeDatos gestor;
    private DefaultComboBoxModel model;
    private Presentacion presentacion;
    private Validacion v;

    public VentanaPresentaciones() {
        initComponents();
        setVisible(true);
        gestor = new GestorBaseDeDatos();
        cargarComboDia();
        cargarComboArtista();
        this.setLocationRelativeTo(null);
        v = new Validacion();
    }

    private void limpiarCampos() {
        cbxDiaFestival.setSelectedIndex(0);
        cbxArtistas.setSelectedIndex(0);
        txtHoraInicio.setText("");
        txtDuracion.setText("");
    }

    private void cargarComboDia() {

        model = new DefaultComboBoxModel();

        ArrayList<DiaFestival> lista = gestor.listarDiaFestival();

        for (DiaFestival d : lista) {
            model.addElement(d.getFecha());
        }

        cbxDiaFestival.setModel(model);
    }

    private void cargarComboArtista() {

        model = new DefaultComboBoxModel();

        ArrayList<Artista> lista = gestor.listarArtistas();

        for (Artista d : lista) {
            model.addElement(d.getNombre());
        }

        cbxArtistas.setModel(model);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        cbxDiaFestival = new javax.swing.JComboBox<>();
        jLabel3 = new javax.swing.JLabel();
        cbxArtistas = new javax.swing.JComboBox<>();
        txtHoraInicio = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        txtDuracion = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        btnCargarPresentacion = new javax.swing.JButton();
        btnFinalizarCarga = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel1.setText("Ingrese las Presentaciones ");

        jLabel2.setText("Dia del Festival");

        jLabel3.setText("Artista");

        jLabel4.setText("Hora Inicio (hora:minutos)");

        jLabel5.setText("Duracion");

        btnCargarPresentacion.setText("Cargar Presentacion");
        btnCargarPresentacion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCargarPresentacionActionPerformed(evt);
            }
        });

        btnFinalizarCarga.setText("Finalizar Carga");
        btnFinalizarCarga.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnFinalizarCargaActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4)
                    .addComponent(jLabel5))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(txtHoraInicio, javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(cbxArtistas, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(cbxDiaFestival, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(txtDuracion, javax.swing.GroupLayout.Alignment.LEADING))
                    .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.TRAILING))
                .addGap(136, 136, 136))
            .addGroup(layout.createSequentialGroup()
                .addGap(56, 56, 56)
                .addComponent(btnCargarPresentacion, javax.swing.GroupLayout.PREFERRED_SIZE, 133, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(44, 44, 44)
                .addComponent(btnFinalizarCarga, javax.swing.GroupLayout.PREFERRED_SIZE, 133, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(19, 19, 19)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 21, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(cbxDiaFestival, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(24, 24, 24)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(cbxArtistas, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(27, 27, 27)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtHoraInicio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4))
                .addGap(33, 33, 33)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtDuracion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5))
                .addGap(29, 29, 29)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnCargarPresentacion)
                    .addComponent(btnFinalizarCarga))
                .addContainerGap(40, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnFinalizarCargaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnFinalizarCargaActionPerformed
        VentanaGrillaFestival ventana = new VentanaGrillaFestival();
        this.dispose();
    }//GEN-LAST:event_btnFinalizarCargaActionPerformed


    private void btnCargarPresentacionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCargarPresentacionActionPerformed

        if (validar()) {
            int idDia = cbxDiaFestival.getSelectedIndex() + 1;
            int idArtista = cbxArtistas.getSelectedIndex() + 1;
            String hora = txtHoraInicio.getText();
            float duracion = Float.parseFloat(txtDuracion.getText());

            presentacion = new Presentacion(idDia, idArtista, hora, duracion);

            gestor.cargarPresentacion(presentacion);

            limpiarCampos();
        }


    }//GEN-LAST:event_btnCargarPresentacionActionPerformed

    //METODO VALIDAR
    public boolean validar() {
        if (txtDuracion.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Debe ingresar la duracion");
            txtDuracion.requestFocus();
            return false;
        } else if (txtHoraInicio.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Debe ingresar una hora de inicio");
            txtHoraInicio.requestFocus();
            return false;
        } else if (txtHoraInicio.getText().length() < 5) {
            JOptionPane.showMessageDialog(this, "Error al ingresar el horario");
            txtHoraInicio.requestFocus();
            return false;
        } else if (!v.validarHora(txtHoraInicio.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar la fecha en formato correcto HH:MM");
            txtHoraInicio.requestFocus();
            return false;

        } else {
            return true;
        }

    }

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new VentanaPresentaciones().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCargarPresentacion;
    private javax.swing.JButton btnFinalizarCarga;
    private javax.swing.JComboBox<String> cbxArtistas;
    private javax.swing.JComboBox<String> cbxDiaFestival;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JTextField txtDuracion;
    private javax.swing.JTextField txtHoraInicio;
    // End of variables declaration//GEN-END:variables

}
