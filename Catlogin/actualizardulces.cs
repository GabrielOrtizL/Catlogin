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
    public partial class actualizardulces : Form
    {
        public actualizardulces()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.actualizardulces(Int32.Parse(txtid.Text), txtusuario.Text);
            MessageBox.Show(mensaje);
        }
    }
}
