using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decolas
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();

        public void mostrarCola()
        {
            lstViewCola.Clear();
            for(int i=0; i<=cola.ultimo; i++)
            {
                lstViewCola.Items.Add(cola.lista[i].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarDelante_Click(object sender, EventArgs e)
        {
            cola.insertar_delante(Int32.Parse(txtBoxElementoCola.Text));
            txtBoxElementoCola.Text = "";
            txtBoxElementoCola.Focus();
            mostrarCola();
        }

        private void btnEliminarAtras_Click(object sender, EventArgs e)
        {
            cola.eliminar_atras();
            mostrarCola();
        }

        private void btnInvertirCola_Click(object sender, EventArgs e)
        {
            cola.invertir();
            mostrarCola();
        }

        private void btnInsertarCola_Click(object sender, EventArgs e)
        {
            cola.insertar(Int32.Parse(txtBoxElementoCola.Text));
            txtBoxElementoCola.Text = "";
            txtBoxElementoCola.Focus();
            mostrarCola();
        }
    }
}
