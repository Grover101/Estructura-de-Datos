using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasConLSE
{
    class ListaSimplementeEnlazada
    {
        public Nodo tope = null;

        //OBJETOS PARA LA IMPLEMENTACION DE COLAS
        public Nodo primero = null;
        public Nodo ultimo = null;

        public void InsertarPila(int x)
        {
            Nodo p;
            if(tope == null)
            {
                tope = new Nodo();
                tope.Info = x;
                tope.Enlace = null;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = tope;
                tope = p;
            }
        }

        public void EliminarPila()
        {
            Nodo p;
            if (tope == null)
                MessageBox.Show("No se puede eliminar mas elementos, porque la pila esta vacia");
            else
            {
                MessageBox.Show("Elemento eliminado: "+tope.Info);
                p = tope;
                tope = tope.Enlace;
                p.Enlace = null;
            }
        }

        //funciones de insertar y eliminar para una cola con lse
        public void InsertarCola(int x)
        {
            Nodo p;
            if(ultimo == null)
            {
                ultimo = new Nodo();
                ultimo.Info = x;
                ultimo.Enlace = null;
                primero = ultimo;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                ultimo.Enlace = p;
                p.Enlace = null;
                ultimo = p;
            }
        }

        public void EliminarCola()
        {
            Nodo p;
            if (primero == null)
                MessageBox.Show("No se puede eliminar elementos de la cola, Cola vacia");
            else
            {
                MessageBox.Show("elemento eliminado: "+primero.Info);
                p = primero;
                primero = primero.Enlace;
                if (primero == null)
                    ultimo = primero;
                p.Enlace = null;
                p = null;
            }
        }
    }
}
