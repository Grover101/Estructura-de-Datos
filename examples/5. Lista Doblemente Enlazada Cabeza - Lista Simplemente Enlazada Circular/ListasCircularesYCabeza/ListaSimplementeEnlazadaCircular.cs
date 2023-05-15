using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCircularesYCabeza
{
    class ListaSimplementeEnlazadaCircular
    {
        public Nodo lista;
        Nodo ultimo;

        public bool vacia()
        {
            if (lista == null)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            Nodo p;
            if(vacia())
            {
                lista = new Nodo();
                lista.Info = x;
                lista.Enlace = lista;
                ultimo = lista;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = ultimo.Enlace;
                ultimo.Enlace = p;
                ultimo = p;
            }
        }

        public void insertar2(int x)
        {
            Nodo p, q;
            if (vacia())
            {
                lista = new Nodo();
                lista.Info = x;
                lista.Enlace = lista;
            }
            else
            {
                q = lista;
                while (q.Enlace != lista)
                    q = q.Enlace;
                p = new Nodo();
                p.Info = x;
                p.Enlace = q.Enlace;
                q.Enlace = p;
            }

        }
        public void eliminar(int x)
        {
            if (vacia())
                MessageBox.Show("Lista vacia, no hay nada que eliminar");
            else
            {
                Nodo aux1 = new Nodo();
                aux1 = lista;
                Nodo aux2 = new Nodo();
                bool encontrado = false;
                do
                {
                    if (aux1.Info == x)
                    {
                        if (aux1 == lista)
                        {
                            if (aux1.Enlace == lista)
                                lista = lista;
                            else
                            {
                                lista = lista.Enlace;
                                ultimo.Enlace = lista;
                            }
                        }
                        else if (aux1 == ultimo)
                        {
                            aux2.Enlace = lista;
                            ultimo = aux2;
                        }
                        else
                        {
                            aux2.Enlace = aux1.Enlace;
                        }
                        MessageBox.Show("Elemento elimiado " + x);
                        encontrado = true;
                    }
                    aux2 = aux1;
                    aux1 = aux1.Enlace;
                } while (aux1 != lista && encontrado != true);
                if (!encontrado)
                    MessageBox.Show("El elemento no existe");
            }
        }

    }
}
