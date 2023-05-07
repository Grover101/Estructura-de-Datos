using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistasMaterias
{
    class NodoCarrera
    {
        private string nombreCarrera;
        private int cantidadMaterias;
        private NodoMateria enlaceMateria;

        public string NombreCarrera
        {
            get { return nombreCarrera; }
            set { nombreCarrera = value; }
        }
        public int CantidadMaterias
        {
            get { return cantidadMaterias; }
            set { cantidadMaterias = value; }
        }

        public NodoMateria EnlaceMateria
        {
            get { return enlaceMateria; }
            set { enlaceMateria = value; }
        }
    }
}
