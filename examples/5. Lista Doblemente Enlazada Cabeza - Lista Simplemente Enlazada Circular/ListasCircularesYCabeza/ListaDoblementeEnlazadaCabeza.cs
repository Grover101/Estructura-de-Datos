using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesYCabeza
{
    

    class ListaDoblementeEnlazadaCabeza
    {
        public NodoCabeza cabeza;
        public NodoDoble primero;
        public NodoDoble ultimo;

        private bool vacia()
        {
            if (cabeza == null)
                return true;
            else
                return false;
        }

        private void crearCabeza()
        {
            cabeza = new NodoCabeza();
            cabeza.Enlace = null;
            cabeza.Info = 0;
        }

        public void insertar(char x)
        {
            NodoDoble p;
            if(vacia())
            {
                crearCabeza();
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceIzquierdo = null;
                primero.EnlaceDerecho = null;
                ultimo = primero;
                cabeza.Info++;
                cabeza.Enlace = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Info = x;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;
                ultimo.EnlaceDerecho = p;
                ultimo = p;
                cabeza.Info++;
            }
        }
    }
}
