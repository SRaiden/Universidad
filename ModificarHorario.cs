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
    public partial class ModificarHorario : Form
    {
        public ModificarHorario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            SqlConnection cn = new SqlConnection(c.rutaUniversidad);


            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Horarios where Cod_Horario = " + textBox1.Text.ToString();
            comando.Connection = cn;

            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txt1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                
            }
            cn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.ModificarHorario(txt1.Text, textBox2.Text, textBox3.Text,textBox4.Text);
            MessageBox.Show("Se completo la operacion");
        }


    }
}
