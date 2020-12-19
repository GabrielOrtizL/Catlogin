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
    public partial class CatLogin : Form
    {
        public CatLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var usuario = txtusuario.Text;
            var contra = txtcontraseña.Text;

            var respuesta = Funciones.login(usuario, contra);

            if (respuesta)
            {
                MessageBox.Show("Bienvenido");
                Cathome home = new Cathome();
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña no son correctos");
            }
        }
    }
}
