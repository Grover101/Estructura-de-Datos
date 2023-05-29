using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios
{
    class NodoHilvanado
    {
        private int info;
        private NodoHilvanado enlaceIzquierdo;
        private NodoHilvanado enlaceDerecho;
        //para realizar el hilvan del arbol, definimos los indicadores
        private bool indicadorIzquierdo;
        private bool indicadorDerecho;
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public NodoHilvanado EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }
        public NodoHilvanado EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
        public bool IndicadorIzquierdo
        {
            get { return indicadorIzquierdo; }
            set { indicadorIzquierdo = value; }
        }
        public bool IndicadorDerecho
        {
            get { return indicadorDerecho; }
            set { indicadorDerecho = value; }
        }
    }
}
