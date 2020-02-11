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
    public partial class MateriasxCarrera : Form
    {
        public MateriasxCarrera()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "Select Carrera.Nombre as Carrera, Materia.nombre as Nombre, Horarios.Horario, Horarios.Dia from Carrera inner join Materia on Materia.Cod_especialidad=Carrera.Cod_Carrera inner join HorxMat on HorxMat.cod_mat=Materia.Cod_Materia inner join Horarios on Horarios.Cod_Horario = HorxMat.Cod_hor where Carrera.Nombre = '" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Carrera");
            dataGridView1.DataSource = dt;
        }
    }
}
