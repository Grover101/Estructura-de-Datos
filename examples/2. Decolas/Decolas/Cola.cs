using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decolas
{
    class Cola
    {
        static int maxcola = 3;
        public int primero;
        public int ultimo;
        public int[] lista;

        public Cola()
        {
            primero = 0;
            ultimo = -1;
            lista = new int[maxcola];
        }

        public bool vacia()
        {
            if (ultimo < primero)
                return true;
            else
                return false;
        }

        public bool llena()
        {
            if (ultimo == maxcola - 1)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            if (llena())
                MessageBox.Show("La cola esta llena, no se puede insertar mas elementos");
            else
            {
                ultimo++;
                lista[ultimo] = x;
            }
        }

        public void insertar_delante(int x)
        {
            if (llena())
                MessageBox.Show("La cola esta llena, no se puede insertar mas elementos");
            else
            {
                ultimo++;
                if (ultimo == 0)
                    lista[ultimo] = x;
                for(int i=ultimo-1;i>-1;i--)
                {
                    lista[i + 1] = lista[i];
                    lista[i] = x;
                }
            }
        }

        // cola: 4 3 2 1
        // 45 56 67 67
        // eliminado: 23
        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + lista[primero]);
                for (int i = 0; i <= ultimo - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
            }
        }

        public void eliminar_atras()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia, no se puede eliminar mas elementos");
            else
            {
               MessageBox.Show("El elemento eliminado es: "+lista[ultimo]);
                ultimo--;
            }
        }

        public void invertir()
        {
            int aux;
            int medio;

            medio = ultimo / 2;
            for(int i =0; i<= medio; i++)
            {
                aux = lista[i];
                lista[i] = lista[ultimo - i];
                lista[ultimo - i] = aux;
            }
        }
    }

}
