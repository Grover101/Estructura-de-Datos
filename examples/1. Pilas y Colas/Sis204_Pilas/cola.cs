using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis204_Pilas
{
    class cola
    {
        static int maxcola = 3;
        public int primero;
        public int ultimo;
        public int[] lista;

        public cola()
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
            if(llena())
                MessageBox.Show("La cola esta llena, no se puede insertar mas elementos");
            else
            {
                ultimo++;
                lista[ultimo] = x;
            }
        }

        // 0   1  2 3
        // 45 56 67 67
        // eliminado: 23
        public void eliminar()
        {
            if(vacia())
                MessageBox.Show("La cola esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: "+lista[primero]);
                for(int i=0; i<= ultimo-1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
            }
        }
    }
}
