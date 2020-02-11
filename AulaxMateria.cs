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
    public partial class AulaxMateria : Form
    {
        public AulaxMateria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "select Aulas.Cod_Aula,Aulas.Computadoras,Aulas.Capacidad,Materia.nombre as Materia, Horarios.Dia, Horarios.Horario from Aulas inner join HorxMat on HorxMat.Cod_Aula=Aulas.Cod_Aula inner join Materia on Materia.Cod_Materia=HorxMat.cod_mat inner join Horarios on HorxMat.Cod_hor=Horarios.Cod_Horario where Aulas.Cod_Aula='" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Alumnos");
            dataGridView1.DataSource = dt;
        }
    }
}
