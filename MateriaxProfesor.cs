using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class MateriaxProfesor : Form
    {
        public MateriaxProfesor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "select Profesores.Apellido, Profesores.Nombre, Materia.nombre as Materia,Carrera.Nombre as Carrera, Horarios.Horario, Horarios.Dia from Profesores inner join ProfxMat on ProfxMat.Legajo=Profesores.Legajo inner join Materia on ProfxMat.Cod_Materia=Materia.Cod_Materia inner join Carrera on Materia.Cod_especialidad=Carrera.Cod_Carrera inner join HorxMat on HorxMat.cod_mat=Materia.Cod_Materia inner join Horarios on Horarios.Cod_Horario=HorxMat.Cod_hor where Profesores.Legajo = '" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Profesores");
            dataGridView1.DataSource = dt;
        }   
      
    }
}
