using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios
{
    class Nodo
    {
        private int info;
        private Nodo enlaceIzquierdo;
        private Nodo enlaceDerecho;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Nodo EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value;  }
        }
        public Nodo EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
