using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_practico.Clases;

namespace Trabajo_practico.Formularios
{
    public partial class frmNoche : Form
    {

        clsAccesoBD oDatos = new clsAccesoBD(@"Data Source=NAHUEL-PC;Initial Catalog=FestivalSuquia;User ID=sa;Password=sa");
        const int tam = 50;
        Noche[] ArregloNoches = new Noche[tam];

        enum acciones
        {
            Nuevo, Modificar, Ninguna
        }

        acciones miAccion = acciones.Ninguna;


        public frmNoche()
        {
            InitializeComponent();
        }



        private void cargarLista(string nombreTabla)
        {
            oDatos.leerTabla(nombreTabla);
            int n = 0;
            while (oDatos.pLector.Read())
            {
                Noche noche = new Noche();
                if (!oDatos.pLector.IsDBNull(0))
                    noche.Id_noche = oDatos.pLector.GetInt32(0);
                if (!oDatos.pLector.IsDBNull(1))
                    noche.Nro_luna = oDatos.pLector.GetInt32(1);
                if (!oDatos.pLector.IsDBNull(2))
                    noche.Fecha_horaComienzo = oDatos.pLector.GetDateTime(2);
                if (!oDatos.pLector.IsDBNull(3))
                    noche.Fecha_horaCierre = oDatos.pLector.GetDateTime(3);


                ArregloNoches[n] = noche;
                n++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();
            listBoxNoches.Items.Clear();
            for (int i = 0; i < n; i++)
                listBoxNoches.Items.Add(ArregloNoches[i].ToString());
            listBoxNoches.SelectedIndex = -1;

        }



        private void limpiar()
        {
            txtNroLuna.Text = "";
            dtpFechaCom.Value = DateTime.Today;
            dtpHoraCierre.Value = DateTime.Today;

        }

        private void habilitar(bool x)
        {
            txtNroLuna.Enabled = x;
            dtpFechaCom.Enabled = x;
            dtpHoraCierre.Enabled =x;

            btnGrabar.Enabled = x;
            listBoxNoches.Enabled = x;

            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            listBoxNoches.Enabled = !x;
        }

        private void cargarCampos(int posicion)
        {
            lblIDNOCHE.Text = ArregloNoches[posicion].Id_noche.ToString();
            txtNroLuna.Text= ArregloNoches[posicion].Nro_luna.ToString();
            dtpFechaCom.Value = ArregloNoches[posicion].Fecha_horaComienzo;
            dtpHoraCierre.Value = ArregloNoches[posicion].Fecha_horaCierre;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
            miAccion = acciones.Nuevo;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            miAccion = acciones.Modificar;
            txtNroLuna.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar la noche " + ArregloNoches[listBoxNoches.SelectedIndex].Id_noche + " ?"
                , "Borrar"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                string sql = "Delete from noche where id_cliente=" + ArregloNoches[listBoxNoches.SelectedIndex].Id_noche;
                oDatos.actualizarBD(sql);
                cargarLista("noche");
            }

        }

      

        private bool validar()
        {
           
                bool estado = true;

                foreach (Control C in pnlNoches.Controls)
                {
                    if (C is TextBox && string.IsNullOrEmpty(C.Text))
                        estado = false;
                }

                if (!estado)
                    MessageBox.Show("No puede haber campos vacíos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

              

                return estado;
            }

        private void frmNoche_Load(object sender, EventArgs e)
        {   
            cargarLista("noche");
            habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            miAccion = acciones.Ninguna;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
            miAccion = acciones.Nuevo;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            habilitar(true);
            miAccion = acciones.Modificar;
            txtNroLuna.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxNoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNoches.SelectedIndex != -1)
                cargarCampos(listBoxNoches.SelectedIndex);
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar la noche " + ArregloNoches[listBoxNoches.SelectedIndex].Nro_luna + " ?"
                , "Borrar"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                string sql = "Delete from noche where id_noche=" + ArregloNoches[listBoxNoches.SelectedIndex].Id_noche;
                oDatos.actualizarBD(sql);
                cargarLista("noche");
            }
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                string sql;

                if (miAccion == acciones.Nuevo)
                {
                    Noche noche = new Noche();
                    noche.Nro_luna = Convert.ToInt32(txtNroLuna.Text);
                    noche.Fecha_horaComienzo = dtpFechaCom.Value;
                    noche.Fecha_horaCierre = dtpHoraCierre.Value;


                    sql = "INSERT INTO NOCHE VALUES ('"
                                            + noche.Nro_luna + "','"
                                            + noche.Fecha_horaComienzo + "','"
                                            + noche.Fecha_horaCierre + "')";
                    oDatos.actualizarBD(sql);
                    cargarLista("NOCHE");

                }

                if (miAccion == acciones.Modificar)
                {
                    int i = listBoxNoches.SelectedIndex;

                    if (MessageBox.Show("¿Seguro que desea modificar los datos de la noche " + ArregloNoches[i].Nro_luna + " ?"
                        , "Modificar"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Warning
                        , MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        ArregloNoches[i].Nro_luna = Convert.ToInt32(txtNroLuna.Text);
                        ArregloNoches[i].Fecha_horaComienzo = dtpFechaCom.Value;
                        ArregloNoches[i].Fecha_horaCierre = dtpHoraCierre.Value;


                        sql = "UPDATE NOCHE set nro_luna ='" + ArregloNoches[i].Nro_luna
                                                + "', fecha_horaComienzo ='" + ArregloNoches[i].Fecha_horaComienzo
                                                + "', fecha_horaCierre ='" + ArregloNoches[i].Fecha_horaCierre
                                                + "' Where id_noche=" + ArregloNoches[i].Id_noche;

                        oDatos.actualizarBD(sql);
                        cargarLista("NOCHE");
                    }
                }
                habilitar(false);
                miAccion = acciones.Ninguna;
            }
        }

        private void txtNroLuna_Click(object sender, EventArgs e)
        {

        }

        private void pnlNoches_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFechaCom_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    }

