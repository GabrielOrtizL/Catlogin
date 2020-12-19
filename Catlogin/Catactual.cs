using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catlogin
{
    public partial class Catactual : Form
    {
        public Catactual()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.actualizar(Int32.Parse(txtid.Text), txtusuario.Text, txtcontraseña.Text);
            MessageBox.Show(mensaje);
        }
    }
}
