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
    public partial class EliminarTutor : Form
    {
        public EliminarTutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            SqlConnection cn = new SqlConnection(c.rutaUniversidad);


            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Tutor where Cod_Tutor = " + textBox1.Text.ToString();
            comando.Connection = cn;

            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txt1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
                textBox7.Text = dr[6].ToString();
                textBox8.Text = dr[7].ToString();
                textBox9.Text = dr[8].ToString();
                textBox10.Text = dr[9].ToString();

            }
            cn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.EliminarTutor(textBox1.Text);
            MessageBox.Show("Se completo la operacion");
        }

   
    }
}
