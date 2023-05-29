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
            arbol.crearArbolLexicografico(Int32.Parse(txtElemento.Text));
            //arbol.crearArbolLexicograficoHilvanado(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
        }

        private void btnPreordenRecursivo_Click(object sender, EventArgs e)
        {
            //arbol.preOrdenRecursivo(arbol.raiz);
            arbol.preOrdenHilvanado(arbol.raizHilvanado);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.preOrden(arbol.raiz);
            MostrarRecorrido();
        }

        private void btnEntreOrdenRecursivo_Click(object sender, EventArgs e)
        {
            //arbol.entreOrdenRecursivo(arbol.raiz);
            arbol.entreOrdenRecursivoHilvanado(arbol.raizHilvanado);
            MostrarRecorrido();
            arbol.topeRecorrido = 0;
        }

        private void btnEntreOrdenNoRecursivo_Click(object sender, EventArgs e)
        {
            arbol.entreOrden(arbol.raiz);
            MostrarRecorrido();
        }

        private void btnPostOrdenRecursivo_Click(object sender, EventArgs e)
        {
            arbol.postOrdenRecursivo(arbol.raiz);
            MostrarRecorrido();
        }

        private void btnPOstOrdenNoRecursivo_Click(object sender, EventArgs e)
        {
            arbol.postOrden(arbol.raiz);
            MostrarRecorrido();
        }

        private void btnHilvanar_Click(object sender, EventArgs e)
        {
            arbol.hilvanar(arbol.raizHilvanado);
        }
    }
}
