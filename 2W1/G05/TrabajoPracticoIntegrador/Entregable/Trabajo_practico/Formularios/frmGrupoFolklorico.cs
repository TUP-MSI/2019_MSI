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
    public partial class frmGrupoFolklorico : Form
    {
       
        clsAccesoBD oDatos = new clsAccesoBD(@"Data Source=NAHUEL-PC;Initial Catalog=FestivalSuquia;User ID=sa;Password=sa");

        const int tam = 50;
        clsGrupoFolklorico[] ArregloElenco = new clsGrupoFolklorico[tam];

        enum acciones
        {
            Nuevo, Modificar, Ninguna
        }

        acciones miAccion = acciones.Ninguna;

        public frmGrupoFolklorico()
        {
            InitializeComponent();
        }
        private void frmElenco_Load(object sender, EventArgs e)
        {
            //cargarCombo(cboTipoPais, "PAISES");
            cargarLista("grupo_folklorico");

            habilitar(false);
        }
        private void cargarLista(string nombreTabla)
        {
            oDatos.leerTabla(nombreTabla);
            int c = 0;
            while (oDatos.pLector.Read())
            {
                clsGrupoFolklorico elenco = new clsGrupoFolklorico();
                if (!oDatos.pLector.IsDBNull(0))
                    elenco.pId_grupo_folklorico = oDatos.pLector.GetInt32(0);
                if (!oDatos.pLector.IsDBNull(1))
                    elenco.pNombre_grupo = oDatos.pLector.GetString(1);
                if (!oDatos.pLector.IsDBNull(2))
                    elenco.pCant_integrantes = oDatos.pLector.GetInt32(2);           
                if (!oDatos.pLector.IsDBNull(3))
                    elenco.pProcedencia = oDatos.pLector.GetString(3);
                if (!oDatos.pLector.IsDBNull(4))
                    elenco.pTel_contacto = oDatos.pLector.GetString(4);
                if (!oDatos.pLector.IsDBNull(5))
                    elenco.pEmail = oDatos.pLector.GetString(5);
                if (!oDatos.pLector.IsDBNull(6))
                    elenco.pSalario = oDatos.pLector.GetDouble(6);

                ArregloElenco[c] = elenco;
                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();
            lstGrupo.Items.Clear();
            for (int i = 0; i < c; i++)
                lstGrupo.Items.Add(ArregloElenco[i].ToString());
            lstGrupo.SelectedIndex = -1;

        }

        private bool validar()
        {
            bool estado = true;

            foreach (Control C in pnlElenco.Controls)
            {
                if (C is TextBox && string.IsNullOrEmpty(C.Text))
                    estado = false;
            }

            if (estado == false)
                MessageBox.Show("No puede haber campos vacíos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            return estado;
        }

        private void limpiar()
        {
            lblIDGrupo.Text = "";          
            txtNombre.Clear();
            txtCantidad.Clear();
            txtProcedencia.Clear();
            txtContacto.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            lstGrupo.SelectedIndex = -1;
        }

        private void habilitar(bool x)
        {
            txtNombre.Enabled = x;
            txtCantidad.Enabled = x;
            txtProcedencia.Enabled = x;
            txtContacto.Enabled = x;
            txtEmail.Enabled = x;
            txtSalario.Enabled = x;
            btnGrabar.Enabled = x;
            lstGrupo.Enabled = x;

            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            lstGrupo.Enabled = !x;
        }

        private void cargarCampos(int posicion)
        {
            lblIDGrupo.Text = ArregloElenco[posicion].pId_grupo_folklorico.ToString();
            txtNombre.Text = ArregloElenco[posicion].pNombre_grupo;
            txtCantidad.Text = ArregloElenco[posicion].pCant_integrantes.ToString();
            txtProcedencia.Text = ArregloElenco[posicion].pProcedencia;
            txtContacto.Text = ArregloElenco[posicion].pTel_contacto;
            txtEmail.Text = ArregloElenco[posicion].pEmail;
            txtSalario.Text = ArregloElenco[posicion].pSalario.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
            miAccion = acciones.Nuevo;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el Grupo Folklorico " + ArregloElenco[lstGrupo.SelectedIndex].pId_grupo_folklorico + " ?"
                , "Borrar"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                string sql = "Delete from grupo_folklorico where id_grupo_folklorico =" + ArregloElenco[lstGrupo.SelectedIndex].pId_grupo_folklorico;
                oDatos.actualizarBD(sql);
                
                cargarLista("grupo_folklorico");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            miAccion = acciones.Modificar;
            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string sql;

                if (miAccion == acciones.Nuevo)
                {
                    clsGrupoFolklorico elenco = new clsGrupoFolklorico();
                    elenco.pNombre_grupo = txtNombre.Text;
                    elenco.pCant_integrantes = Convert.ToInt32(txtCantidad.Text);
                    elenco.pProcedencia = txtProcedencia.Text;
                    elenco.pTel_contacto = txtContacto.Text;
                    elenco.pEmail = txtEmail.Text;
                    elenco.pSalario =Convert.ToDouble(txtSalario.Text);
                    
                 
                    sql = "INSERT INTO grupo_folklorico VALUES ('"
                                            + elenco.pNombre_grupo + "', '"
                                            + elenco.pCant_integrantes + "', '"
                                            + elenco.pProcedencia+ "', '"
                                            + elenco.pTel_contacto + "', '"
                                            + elenco.pEmail + "', '"
                                            + elenco.pSalario + "')";
                    oDatos.actualizarBD(sql);
                    cargarLista("grupo_folklorico");
                                   
                }

                if (miAccion == acciones.Modificar)
                {
                    int i = lstGrupo.SelectedIndex;

                    if (MessageBox.Show("¿Seguro que desea modificar los datos del Grupo " + ArregloElenco[i].pNombre_grupo + " ?"
                        , "Modificar"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Warning
                        , MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        ArregloElenco[i].pNombre_grupo = txtNombre.Text;
                        ArregloElenco[i].pCant_integrantes = Convert.ToInt32(txtCantidad.Text);
                        ArregloElenco[i].pProcedencia = txtProcedencia.Text;
                        ArregloElenco[i].pTel_contacto = txtContacto.Text;
                        ArregloElenco[i].pEmail = txtEmail.Text;
                        ArregloElenco[i].pSalario =Convert.ToDouble(txtSalario.Text);
                        


                        sql = "UPDATE grupo_folklorico set nombre_grupo ='" + ArregloElenco[i].pNombre_grupo
                                                + "', cant_integrantes ='" + ArregloElenco[i].pCant_integrantes
                                                + "', procedencia= '" + ArregloElenco[i].pProcedencia
                                                + "', tele_contacto= '" + ArregloElenco[i].pTel_contacto
                                                + "', email= '" + ArregloElenco[i].pEmail
                                                + "', salario= '" + ArregloElenco[i].pSalario
                                                + "' Where id_grupo_folklorico=" + ArregloElenco[i].pId_grupo_folklorico;

                        oDatos.actualizarBD(sql);
                        cargarLista("grupo_folklorico");
                    }
                }
                habilitar(false);
                miAccion = acciones.Ninguna;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            miAccion = acciones.Ninguna;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGrupo.SelectedIndex != -1)
                cargarCampos(lstGrupo.SelectedIndex);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en el campo de apellido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
