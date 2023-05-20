using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        void MostrarRecorrido()
        {
            lstViewArbol.Clear();
            for (int i = 0; i <= arbol.topeRecorrido - 1; i++)
                lstViewArbol.Items.Add(arbol.recorrido[i].ToString());
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLexicografico_Click(object sender, EventArgs e)
        {
            arbol.crearArbolLexicografico(Int32.Parse(txtElemento.Text), null);
            txtElemento.Text = "";
            txtElemento.Focus();
        }

        private void btnPreordenRecursivo_Click(object sender, EventArgs e)
        {
            arbol.preOrdenRecursivo(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.preOrden(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void PosOrdenRecursivo_Click(object sender, EventArgs e)
        {
            arbol.postOrdenRecursivo(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void PosOrden_Click(object sender, EventArgs e)
        {
            arbol.postOrden(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void InOrdenRecursivo_Click(object sender, EventArgs e)
        {
            arbol.entreOrdenRecursivo(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }
        private void InOrden_Click(object sender, EventArgs e)
        {
            arbol.entreOrden(arbol.raiz);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
            /*MessageBox.Show(arbol.contarRamas(arbol.raiz).ToString());
            arbol.cantidadNodosHoja(arbol.raiz);
            MessageBox.Show(arbol.cant.ToString());
            arbol.cant = 0;*/
            /*Nodo aux = arbol.buscarPadre(arbol.raiz, 11);
            MessageBox.Show(aux.Info.ToString());*/
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.busqueda(arbol.raiz, Int32.Parse(txtElemento.Text)) + " nivel: " + arbol.nivel);
            arbol.nivel = 0;
            //arbol.eliminar(arbol.raiz, Int32.Parse(txtElemento.Text));
        }
    }
}
