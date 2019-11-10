namespace Trabajo_practico.Formularios
{
    partial class frmNoche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNoches = new System.Windows.Forms.Panel();
            this.lblIDNOCHE = new System.Windows.Forms.Label();
            this.txtNroLuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHoraCierre = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecNac = new System.Windows.Forms.Label();
            this.dtpFechaCom = new System.Windows.Forms.DateTimePicker();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.listBoxNoches = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlNoches.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNoches
            // 
            this.pnlNoches.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlNoches.Controls.Add(this.lblIDNOCHE);
            this.pnlNoches.Controls.Add(this.txtNroLuna);
            this.pnlNoches.Controls.Add(this.label2);
            this.pnlNoches.Controls.Add(this.dtpHoraCierre);
            this.pnlNoches.Controls.Add(this.label1);
            this.pnlNoches.Controls.Add(this.lbFecNac);
            this.pnlNoches.Controls.Add(this.dtpFechaCom);
            this.pnlNoches.Controls.Add(this.lbIdCliente);
            this.pnlNoches.Location = new System.Drawing.Point(12, 10);
            this.pnlNoches.Name = "pnlNoches";
            this.pnlNoches.Size = new System.Drawing.Size(370, 157);
            this.pnlNoches.TabIndex = 36;
            this.pnlNoches.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNoches_Paint);
            // 
            // lblIDNOCHE
            // 
            this.lblIDNOCHE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIDNOCHE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDNOCHE.Location = new System.Drawing.Point(176, 8);
            this.lblIDNOCHE.Name = "lblIDNOCHE";
            this.lblIDNOCHE.Size = new System.Drawing.Size(100, 20);
            this.lblIDNOCHE.TabIndex = 40;
            // 
            // txtNroLuna
            // 
            this.txtNroLuna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNroLuna.Location = new System.Drawing.Point(176, 39);
            this.txtNroLuna.Name = "txtNroLuna";
            this.txtNroLuna.Size = new System.Drawing.Size(100, 20);
            this.txtNroLuna.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nro de Noche";
            // 
            // dtpHoraCierre
            // 
            this.dtpHoraCierre.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dtpHoraCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraCierre.Location = new System.Drawing.Point(176, 108);
            this.dtpHoraCierre.Name = "dtpHoraCierre";
            this.dtpHoraCierre.Size = new System.Drawing.Size(142, 20);
            this.dtpHoraCierre.TabIndex = 32;
            this.dtpHoraCierre.Value = new System.DateTime(2019, 10, 28, 5, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha - Hora de Cierre";
            // 
            // lbFecNac
            // 
            this.lbFecNac.AutoSize = true;
            this.lbFecNac.Location = new System.Drawing.Point(18, 77);
            this.lbFecNac.Name = "lbFecNac";
            this.lbFecNac.Size = new System.Drawing.Size(133, 13);
            this.lbFecNac.TabIndex = 24;
            this.lbFecNac.Text = "Fecha - Hora de Comienzo";
            // 
            // dtpFechaCom
            // 
            this.dtpFechaCom.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dtpFechaCom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCom.Location = new System.Drawing.Point(176, 77);
            this.dtpFechaCom.Name = "dtpFechaCom";
            this.dtpFechaCom.Size = new System.Drawing.Size(142, 20);
            this.dtpFechaCom.TabIndex = 19;
            this.dtpFechaCom.Value = new System.DateTime(2019, 10, 28, 21, 48, 0, 0);
            this.dtpFechaCom.ValueChanged += new System.EventHandler(this.dtpFechaCom_ValueChanged);
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(18, 15);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(53, 13);
            this.lbIdCliente.TabIndex = 16;
            this.lbIdCliente.Text = "ID Noche";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(183, 173);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(640, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(102, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(559, 230);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 31;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // listBoxNoches
            // 
            this.listBoxNoches.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxNoches.FormattingEnabled = true;
            this.listBoxNoches.Location = new System.Drawing.Point(388, 12);
            this.listBoxNoches.Name = "listBoxNoches";
            this.listBoxNoches.Size = new System.Drawing.Size(543, 212);
            this.listBoxNoches.TabIndex = 30;
            this.listBoxNoches.SelectedIndexChanged += new System.EventHandler(this.listBoxNoches_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(21, 173);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // frmNoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 290);
            this.Controls.Add(this.pnlNoches);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.listBoxNoches);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmNoche";
            this.Text = "Noche";
            this.Load += new System.EventHandler(this.frmNoche_Load);
            this.pnlNoches.ResumeLayout(false);
            this.pnlNoches.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNoches;
        private System.Windows.Forms.Label lbFecNac;
        private System.Windows.Forms.DateTimePicker dtpFechaCom;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox listBoxNoches;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtpHoraCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroLuna;
        private System.Windows.Forms.Label lblIDNOCHE;
    }
}