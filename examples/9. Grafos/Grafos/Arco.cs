using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Arco
    {
        private Arco enlaceArco;
        private Vertice enlaceVertice;

        public Arco EnlaceArco
        {
            get { return enlaceArco; }
            set { enlaceArco = value; }
        }
        public Vertice EnlaceVertice
        {
            get { return enlaceVertice; }
            set { enlaceVertice = value; }
        }
    }
}
