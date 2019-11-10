using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_practico.Clases
{
    class clsGrupoFolklorico
    {
      

        private int id_grupo_folklorico;
        private string nombre_grupo;
        private int cant_integrantes;
        private string procedencia;
        private string tele_contacto;
        private string email;
        private double salario;
        

        public int pId_grupo_folklorico { get => id_grupo_folklorico; set => id_grupo_folklorico = value; }
        public string pNombre_grupo { get => nombre_grupo; set => nombre_grupo = value; }
        public int pCant_integrantes { get => cant_integrantes; set => cant_integrantes = value; }
        public string pProcedencia { get => procedencia; set => procedencia = value; }
        public string pTel_contacto { get => tele_contacto; set => tele_contacto = value; }
        public string pEmail { get => email; set => email = value; }
        public double pSalario { get => salario; set => salario = value; }

        public clsGrupoFolklorico(int id_grupo_folklorico, string nombre_grupo, int cant_integrantes, string procedencia, string tel_contacto, string email, double salario)
        {
            this.id_grupo_folklorico = id_grupo_folklorico;
            this.nombre_grupo = nombre_grupo;
            this.cant_integrantes = cant_integrantes;
            this.procedencia = procedencia;
            this.tele_contacto = tel_contacto;
            this.email = email;
            this.salario = salario;
        }

        public clsGrupoFolklorico()
        {
            this.id_grupo_folklorico = 0;
            this.nombre_grupo = "";
            this.cant_integrantes = 0;
            this.procedencia = "";
            this.tele_contacto = "";
            this.email = "";
            this.salario = 0 ;
        }



        public override string ToString()
        {
          
            return "Nombre del Grupo: " + nombre_grupo +" - "+ "Integrantes: "+cant_integrantes;
        }

    }
}
