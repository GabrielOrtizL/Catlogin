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
    public partial class Catcandy : Form
    {
        public Catcandy()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            adddulce add = new adddulce();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            verdulces ver = new verdulces();
            this.Hide();
            ver.ShowDialog();
            this.Show();
        }

        private void btnactalizar_Click(object sender, EventArgs e)
        {
            actualizardulces act = new actualizardulces();
            this.Hide();
            act.ShowDialog();
            this.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminardulces elm = new eliminardulces();
            this.Hide();
            elm.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
