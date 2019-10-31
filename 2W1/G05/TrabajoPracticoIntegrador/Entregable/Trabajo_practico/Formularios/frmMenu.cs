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
using Trabajo_practico.Formularios;

namespace Trabajo_practico
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\festival-cosquin.jpg");
            this.BackgroundImage=img;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoFolklorico GrupoFolklorico = new frmGrupoFolklorico();
            GrupoFolklorico.Show();
        }      

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nocheToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNoche fNoches = new frmNoche();
            fNoches.Show();
        }
    }
}
