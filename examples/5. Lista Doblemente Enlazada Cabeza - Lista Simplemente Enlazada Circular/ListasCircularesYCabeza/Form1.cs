using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCircularesYCabeza
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazadaCircular lsec = new ListaSimplementeEnlazadaCircular();
        //LISTAS DOBLEMENTE ENLAZADAS CON NODO CABEZA
        ListaDoblementeEnlazadaCabeza ldecabeza = new ListaDoblementeEnlazadaCabeza();
        public void MostrarLista()
        {
            Nodo p = new Nodo();

            lstViewListaCircular.Clear();
            p = lsec.lista;
            do
            {
                lstViewListaCircular.Items.Add(p.Info.ToString());
                p = p.Enlace;
            } while (p != lsec.lista);
        }
        public void MostrarListaCabeza()
        {
            NodoDoble p;
            lstViewListaCabeza.Clear();
            p = ldecabeza.cabeza.Enlace;
            while(p!=null)
            {
                lstViewListaCabeza.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lsec.insertar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            MostrarLista();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            lsec.eliminar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            MostrarLista();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lsec = new ListaSimplementeEnlazadaCircular();
            lstViewListaCircular.Clear();
            txtElemento.Focus();
        }

        private void btnInsertarListaCabeza_Click(object sender, EventArgs e)
        {
            ldecabeza.insertar(Convert.ToChar(txtElementoListaCabeza.Text.Substring(0,1)));
            txtCabeza.Text = ldecabeza.cabeza.Info.ToString();
            txtElementoListaCabeza.Text = "";
            txtElementoListaCabeza.Focus();
            MostrarListaCabeza();
        }
    }
}
