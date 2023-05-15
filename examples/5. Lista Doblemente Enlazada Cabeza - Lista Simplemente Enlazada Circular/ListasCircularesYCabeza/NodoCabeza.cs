using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesYCabeza
{
    public class NodoCabeza
    {
        private int info;
        private NodoDoble enlace;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoDoble Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
