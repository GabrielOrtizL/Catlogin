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
    public partial class eliminardulces : Form
    {
        public eliminardulces()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.eliminardulces(Int32.Parse(txtid.Text));
            MessageBox.Show(mensaje);
        }
    }
}
