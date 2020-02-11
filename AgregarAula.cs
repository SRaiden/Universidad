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
    public partial class AgregarAula : Form
    {
        public AgregarAula()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            c.AgregarAula(txt1.Text, checkBox1.Checked, textBox3.Text);
            MessageBox.Show("Se completo la operacion");
        }
    }
}
