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
    public partial class Catstore : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Catstore()
        {
            InitializeComponent();
        }

        private void btnchocolates_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "30";
        }

        private void btngomitas_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "20";
        }

        private void btnpaletas_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btngalletas_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "15"; 
        }

        private void btntoffee_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "40";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    pantallaa.Text = resultado.ToString();
                    break;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            pantallaa.Clear();
        }

        
    }
}

