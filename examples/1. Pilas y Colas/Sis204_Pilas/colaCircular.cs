using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis204_Pilas
{
    class colaCircular
    {
        public int maxcola = 3;
        public int primero;
        public int ultimo;
        public String[] lista;

        public colaCircular()
        {
            primero = -1;
            ultimo = -1;
            lista = new String[maxcola];
        }

        private bool vacia()
        {
            if (primero == -1 && ultimo == -1)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if ((ultimo == maxcola - 1 && primero == 0) || (ultimo + 1 == primero))
                return true;
            else
                return false;
        }

        public void insertar(String x)
        {
            if(llena())
                MessageBox.Show("La cola circular esta llena, no se puede insertar mas elementos");
            else
            {
                if (ultimo == maxcola - 1)
                    ultimo = 0;
                else
                    ultimo++;
                lista[ultimo] = x;
                if (primero == -1)
                    primero = 0;
            }
        }

        public void eliminar()
        {
            if(vacia())
                MessageBox.Show("La cola circular esta vacio, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: "+lista[primero]);
                lista[primero] = "";
                if(primero == ultimo)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                {
                    if (primero == maxcola - 1)
                        primero = 0;
                    else
                        primero++;
                }
            }
        }
    }
}
