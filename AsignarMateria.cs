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
    public partial class AsignarMateria : Form
    {
        public AsignarMateria()
        {
            InitializeComponent();
        }

        private void AsignarMateria_Load(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            SqlConnection cn = new SqlConnection(c.rutaUniversidad);


            
            string ConsultaSql = "Select * from Profesores";
            SqlDataAdapter adaptador = new SqlDataAdapter(ConsultaSql, cn);
            DataSet ds = new DataSet();

            cn.Open();
            adaptador.Fill(ds, "Profesores");
            comboBox1.DataSource = ds.Tables["Profesores"];
            comboBox1.DisplayMember = "Legajo";
            comboBox1.ValueMember = "Legajo";
            cn.Close();                                                                                                                       

            string Consultasql2 = "Select * from Materia";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(Consultasql2, cn);
            DataSet dsx = new DataSet();

            cn.Open();
            adaptador2.Fill(ds, "Materia");
            comboBox2.DataSource = ds.Tables["Materia"];
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "Cod_Materia";
            cn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.AsignarProfesor(comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString());
            MessageBox.Show("Se completo la operacion");
        }
    }
}
