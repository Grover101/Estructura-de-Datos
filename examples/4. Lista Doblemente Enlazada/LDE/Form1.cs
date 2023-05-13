using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDE
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();

        public void MostrarLista()
        {
            Nodo aux = lde.primero;
            lstLIsta.Clear();
            while (aux != null)
            {
                lstLIsta.Items.Add(aux.Info.ToString());
                aux = aux.EnlaceDerecho;
            }
        

        }
    public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lde.insertar(Int32.Parse(txtElementoLista.Text));
            txtElementoLista.Text = "";
            txtElementoLista.Focus();
            MostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lde.eliminar(Int32.Parse(txtElementoLista.Text));
            txtElementoLista.Text = "";
            txtElementoLista.Focus();
            MostrarLista();
        }

        private void btnInsertarOrdenado_Click(object sender, EventArgs e)
        {
            lde.insertar_ordenado(Int32.Parse(txtElementoLista.Text));
            txtElementoLista.Text = "";
            txtElementoLista.Focus();
            MostrarLista();
        }
    }
}
