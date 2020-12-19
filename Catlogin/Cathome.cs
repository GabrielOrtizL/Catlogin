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
    public partial class Cathome : Form
    {
        public Cathome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catstore store = new Catstore();
            this.Hide();
            store.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catobj obj = new Catobj();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catcandy candy = new Catcandy();
            this.Hide();
            candy.ShowDialog();
            this.Show();
        }
    }
}
