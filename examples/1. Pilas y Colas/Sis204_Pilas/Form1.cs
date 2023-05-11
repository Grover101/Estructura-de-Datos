using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis204_Pilas
{
    public partial class Form1 : Form
    {
        pila _pila = new pila();
        cola _cola = new cola();
        colaCircular _colaCircular = new colaCircular();

        public void mostrarPila()
        {
            lstViewPila.Clear();
            for(int i=0;i<=_pila.tope;i++)
            {
                lstViewPila.Items.Add(_pila.lista[i].ToString());
            }
        }
        public void mostrarCola()
        {
            lstViewPila.Clear();
            for (int i = 0; i <= _cola.ultimo; i++)
            {
                lstViewPila.Items.Add(_cola.lista[i].ToString());
            }
        }

        public void mostrarColaCircular()
        {
            lstViewPila.Clear();
            for(int i=0; i<=_colaCircular.maxcola-1;i++)
            {
                lstViewPila.Items.Add(_colaCircular.lista[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            _pila.insertar(Int32.Parse(txtBoxElemento.Text));
            mostrarPila();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _pila.eliminar();
            mostrarPila();
        }

        private void btnInsertarCola_Click(object sender, EventArgs e)
        {
            _cola.insertar(Int32.Parse(txtBoxElemento.Text));
            txtBoxElemento.Text = "";
            mostrarCola();
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            _cola.eliminar();
            mostrarCola();
        }

        private void btnInsertarColaCircular_Click(object sender, EventArgs e)
        {
            _colaCircular.insertar(txtBoxElemento.Text);
            txtBoxElemento.Text = "";
            mostrarColaCircular();
        }

        private void btnEliminarColaCircular_Click(object sender, EventArgs e)
        {
            _colaCircular.eliminar();
            mostrarColaCircular();
        }
    }
}
