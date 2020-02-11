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
    public partial class TutorxAlumno : Form
    {
        public TutorxAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "select Alumnos.Nombre, Alumnos.Apellido, Alumnos.DNI, Alumnos.Telefono, Alumnos.Especialidad as Carrera from Alumnos inner join Tutor on Tutor.Cod_Tutor=Alumnos.Tutor where Tutor.Cod_Tutor = '" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Alumnos");
            dataGridView1.DataSource = dt;
        }

        
    }
}
