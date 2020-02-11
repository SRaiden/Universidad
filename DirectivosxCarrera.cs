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
    public partial class DirectivosxCarrera : Form
    {
        public DirectivosxCarrera()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Clase0001 c = new Clase0001();
            string consulta = "select Directivos.Nombre, Directivos.Apellido,Directivos.Telefono,Directivos.Cargo, Carrera.Nombre as NombreCarrera from Directivos inner join Carrera on Directivos.Cod_Carrera=Carrera.Cod_Carrera where Carrera.Nombre='" + textBox1.Text + "'";
            dt = c.mostrartabla(consulta, "Directivos");
            dataGridView1.DataSource = dt;
        }
    }
}
