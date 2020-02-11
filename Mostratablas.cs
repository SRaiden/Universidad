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
    public partial class Mostratablas : Form
    {
        public Mostratablas(DataTable dt)
        {
            InitializeComponent();
            grdGrilla.DataSource = dt;

        }


        private void Mostratablas_Load(object sender, EventArgs e)
        {

        }

        
    }
}
