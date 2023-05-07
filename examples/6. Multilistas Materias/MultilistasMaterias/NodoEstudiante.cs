using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistasMaterias
{
    class NodoEstudiante
    {
        private string cu;
        private string ci;
        private string nombreCompleto;
        private string direccion;
        private string celular;
        private NodoEstudiante enlaceEstudiante;

        public string Cu
        {
            get { return cu; }
            set { cu = value; }
        }

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public NodoEstudiante EnlaceEstudiante
        {
            get { return enlaceEstudiante; }
            set { enlaceEstudiante = value; }
        }
    }
}
