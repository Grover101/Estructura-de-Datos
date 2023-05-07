using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistasMaterias
{
    class NodoMateria
    {
        private string sigla;
        private string nombreMateria;
        private NodoMateria enlaceMateria;
        private NodoEstudiante enlaceEstudiante;

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }
        public NodoMateria EnlaceMateria
        {
            get { return enlaceMateria; }
            set { enlaceMateria = value; }
        }
        public NodoEstudiante EnlaceEstudiante
        {
            get { return enlaceEstudiante; }
            set { enlaceEstudiante = value; }
        }
    }
}
