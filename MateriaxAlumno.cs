using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prueba1
{
    public partial class MateriaxAlumno : Form
    {
        public MateriaxAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "Select Materia.nombre as Materias,Carrera.Nombre as Carrera, Horarios.Horario, Horarios.Dia, Horarios.Turno from Materia inner join AlumxMat on AlumxMat.Cod_Materia=Materia.Cod_Materia inner join Carrera on Materia.Cod_especialidad=Carrera.Cod_Carrera inner join HorxMat on HorxMat.cod_mat=Materia.Cod_Materia inner join Horarios on Horarios.Cod_Horario=HorxMat.Cod_hor where AlumxMat.DNI_Alumno = '" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Materia");
            dataGridView1.DataSource = dt;
        }
        
    }
}
