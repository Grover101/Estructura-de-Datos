using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasConLSE
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazada lse = new ListaSimplementeEnlazada();

        public void MostrarPila()
        {
            Nodo p;
            p = lse.tope;
            lstViewPila.Clear();
            while(p!=null)
            {
                lstViewPila.Items.Add((p.Info).ToString());
                p = p.Enlace;
            }
        }

        public void MostrarCola()
        {
            Nodo p;
            p = lse.primero;
            lstViewCola.Clear();
            while(p!=null)
            {
                lstViewCola.Items.Add((p.Info).ToString());
                p = p.Enlace;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarPila_Click(object sender, EventArgs e)
        {
            lse.InsertarPila(Int32.Parse(txtElementoPila.Text));
            txtElementoPila.Text = "";
            txtElementoPila.Focus();
            MostrarPila();
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            lse.EliminarPila();
            MostrarPila();
        }

        private void btnInsertarCola_Click(object sender, EventArgs e)
        {
            lse.InsertarCola(Int32.Parse(txtBoxElementoCola.Text));
            txtBoxElementoCola.Text = "";
            txtBoxElementoCola.Focus();
            MostrarCola();
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            lse.EliminarCola();
            MostrarCola();
        }
    }
}
