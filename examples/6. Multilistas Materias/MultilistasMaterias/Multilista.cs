using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilistasMaterias
{
    class Multilista
    {
        public NodoCarrera carrera;
        public NodoMateria materia;
        public NodoEstudiante estudiante;

        public bool carreraVacia()
        {
            if (carrera == null)
                return true;
            else
                return false;
        }

        public void crearCarrera(string nombreCarrera)
        {
            if (carreraVacia())
            {
                carrera = new NodoCarrera();
                carrera.NombreCarrera = nombreCarrera;
                carrera.CantidadMaterias = 0;
                carrera.EnlaceMateria = null;
                MessageBox.Show("Carrera creada");
            }
            else
                MessageBox.Show("La carrera ya fue creada anteriormente");
        }

        public bool materiaVacia()
        {
            if (materia == null)
                return true;
            else
                return false;
        }

        public void insertarMateria(string sigla, string nombreMateria)
        {
            NodoMateria p;
            if(!carreraVacia())
            {
                if(materiaVacia())
                {
                    materia = new NodoMateria();
                    materia.Sigla = sigla;
                    materia.NombreMateria = nombreMateria;
                    materia.EnlaceEstudiante = null;
                    materia.EnlaceMateria = null;
                    carrera.EnlaceMateria = materia;
                    carrera.CantidadMaterias++;
                }
                else
                {
                    p = new NodoMateria();
                    p.Sigla = sigla;
                    p.NombreMateria = nombreMateria;
                    p.EnlaceEstudiante = null;
                    p.EnlaceMateria = null;
                    materia.EnlaceMateria = p;
                    materia = p;
                    carrera.CantidadMaterias++;
                }
                MessageBox.Show("Materia insertada");
            }
            else
            {
                MessageBox.Show("Antes de registrar una materia, debe crear la carrera");
            }
        }

        public bool estudianteVacia(NodoMateria materia)
        {
            if (materia.EnlaceEstudiante == null)
                return true;
            else
                return false;
        }
        public NodoMateria buscarMateria(string sigla)
        {
            NodoMateria p;
            p = carrera.EnlaceMateria;
            while(p!= null && sigla != p.Sigla)
            {
                p = p.EnlaceMateria;
            }
            return p;
        }
        public void insertarEstudiante(NodoMateria materia, string cu, string ci, string nombreCompleto, string direccion, string celular)
        {
            NodoEstudiante p;
            if(estudianteVacia(materia))
            {
                estudiante = new NodoEstudiante();
                estudiante.Cu = cu;
                estudiante.Ci = ci;
                estudiante.NombreCompleto = nombreCompleto;
                estudiante.Direccion = direccion;
                estudiante.Celular = celular;
                estudiante.EnlaceEstudiante = null;
                materia.EnlaceEstudiante = estudiante;
            }
            else
            {
                p = new NodoEstudiante();
                p.Cu = cu;
                p.Ci = ci;
                p.NombreCompleto = nombreCompleto;
                p.Direccion = direccion;
                p.Celular = celular;

                p.EnlaceEstudiante = null;
                estudiante.EnlaceEstudiante = p;
                estudiante = p;
            }
            MessageBox.Show("Estudiante insertado");

        }

        public NodoEstudiante buscarEstudiante(string sigla, string cu)
        {
            NodoEstudiante p;
            NodoMateria materia;
            materia = buscarMateria(sigla);
            p = materia.EnlaceEstudiante;
            while(p != null && cu != p.Cu)
            {
                p = p.EnlaceEstudiante;
            }
            return p;
        }

        public void eliminarEstudiante(string sigla, string cu)
        {
            NodoEstudiante p, q;
            NodoMateria materia;
            materia = buscarMateria(sigla);
            if (materia != null)
            {
                p = materia.EnlaceEstudiante;
                q = p;
                while(p!= null && p.Cu != cu)
                {
                    q = p;
                    p = p.EnlaceEstudiante;
                }
                if (p == null)
                    MessageBox.Show("El estudiante no se encuentra registrado en la materia");
                else
                {
                    q.EnlaceEstudiante = p.EnlaceEstudiante;
                    if (p == materia.EnlaceEstudiante)
                        materia.EnlaceEstudiante = p.EnlaceEstudiante;
                    p.EnlaceEstudiante = null;
                    p = null;
                    MessageBox.Show("Estudiante eliminado");
                }
            }
            else
                MessageBox.Show("La materia no se encuentra registrada");
        }

        public void eliminarMateria(string sigla)
        {
            NodoMateria p, q;
            p = carrera.EnlaceMateria;
            q = p;
            while(p != null && sigla != p.Sigla)
            {
                q = p;
                p = p.EnlaceMateria;
            }
            if (p == null)
                MessageBox.Show("La materia no se encuentra registrada");
            else
            {
                q.EnlaceMateria = p.EnlaceMateria;
                if (p == carrera.EnlaceMateria)
                    carrera.EnlaceMateria = p.EnlaceMateria;
                p.EnlaceMateria = null;
                p.EnlaceEstudiante = null;
                p = null;
                carrera.CantidadMaterias--;
                MessageBox.Show("Materia eliminada");
            }
        }
    }
}
