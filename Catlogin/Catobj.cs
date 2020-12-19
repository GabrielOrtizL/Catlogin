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
    public partial class Catobj : Form
    {
        public Catobj()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Catcrud crud = new Catcrud();
            this.Hide();
            crud.ShowDialog();
            this.Show();
        }

        private void Catobj_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dulceDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dulceDataSet.usuarios);
            
        }

        private void btnactalizar_Click(object sender, EventArgs e)
        {
            Catactual act = new Catactual();
            this.Hide();
            act.ShowDialog();
            this.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Catcut cut = new Catcut();
            this.Hide();
            cut.ShowDialog();
            this.Show();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            Mostrar mos = new Mostrar();
            this.Hide();
            mos.ShowDialog();
            this.Show();
        }
    }
}
