using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesYCabeza
{
    public class NodoDoble
    {
        private char info;
        private NodoDoble enlaceIzquierdo;
        private NodoDoble enlaceDerecho;
        public char Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }
        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
