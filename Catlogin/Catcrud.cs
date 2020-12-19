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
    public partial class Catcrud : Form
    {
        public Catcrud()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.insertar(txtusuario.Text, txtcontraseña.Text);
            MessageBox.Show(mensaje);
        }
    }
}
