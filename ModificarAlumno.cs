﻿using System;
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
    public partial class ModificarAlumno : Form
    {
        public ModificarAlumno(string a)
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            SqlConnection cn = new SqlConnection(c.rutaUniversidad);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Alumnos where DNI = " + textBox1.Text.ToString();
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
                textBox20.Text = dr[10].ToString();
                textBox19.Text = dr[11].ToString();
                textBox18.Text = dr[12].ToString();
                textBox17.Text = dr[13].ToString();
                textBox11.Text = dr[14].ToString();
            }
            cn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.ModificarAlumno(txt1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox20.Text, textBox19.Text, textBox18.Text, textBox17.Text, textBox11.Text);
            MessageBox.Show("Se completo la operacion");
        }

        

    }
}
