using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Form1 : Form
    {
        Grafo grafo = new Grafo();

        public void MostrarVertices()
        {
            Vertice p;
            lstViewVertices.Clear();
            p = grafo.grafo;
            while(p!= null)
            {
                lstViewVertices.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }
        public void MostrarArcos()
        {
            Vertice p;
            Arco q;
            lstViewArcos.Clear();
            p = grafo.grafo;
            while(p != null)
            {
                q = p.EnlaceArco;
                while(q != null)
                {
                    lstViewArcos.Items.Add(p.Info.ToString()+"-"+q.EnlaceVertice.Info.ToString());
                    q = q.EnlaceArco;
                }
                p = p.EnlaceDerecho;   
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarVertice_Click(object sender, EventArgs e)
        {
            grafo.insertarVertice(Int32.Parse(txtVertice.Text));
            txtVertice.Text = "";
            txtVertice.Focus();
            MostrarVertices();
        }

        private void btnMostrarVertices_Click(object sender, EventArgs e)
        {
            MostrarVertices();
        }

        private void btnInsertarArco_Click(object sender, EventArgs e)
        {
            grafo.insertarArco(Int32.Parse(txtVerticeX.Text), Int32.Parse(txtVerticeY.Text));
            txtVerticeX.Text = "";
            txtVerticeY.Text = "";
            txtVerticeX.Focus();
            MostrarArcos();
        }

        private void btnMostrarArcos_Click(object sender, EventArgs e)
        {
            MostrarArcos();
        }

        private void btnEliminarVertice_Click(object sender, EventArgs e)
        {
            Vertice p;
            p = grafo.buscarVertice(Int32.Parse(txtVertice.Text));
            grafo.eliminarArcosSaliendo(p);
            grafo.eliminarArcosEntrando(p);
            grafo.eliminarVertice(p);
            MessageBox.Show("Vertice eliminado");
            MostrarArcos();
            MostrarVertices();
            txtVertice.Text = "";
        }
    }
}
