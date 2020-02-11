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
    public partial class AgregarMateria : Form
    {
        public AgregarMateria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            c.AgregarMateria(txt1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Se completo la operacion");
        }
    }
}
