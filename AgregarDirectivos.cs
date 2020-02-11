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
    public partial class AgregarDirectivos : Form
    {
        public AgregarDirectivos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.AgregarDirectivo(txt1.Text, textBox2.Text, textBox3.Text,textBox20.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text,textBox10.Text,textBox9.Text,textBox18.Text);
            MessageBox.Show("Se completo la operacion");
        }
    }
}
