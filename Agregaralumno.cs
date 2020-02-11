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
    public partial class Agregaralumno : Form
    {
        public Agregaralumno()
        {
            InitializeComponent();

           
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
     
            c.AgregarAlumno(txt1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox20.Text, textBox19.Text, textBox18.Text, textBox17.Text, textBox11.Text);
            MessageBox.Show("Se completo la operacion");
        }

        

    }
}
