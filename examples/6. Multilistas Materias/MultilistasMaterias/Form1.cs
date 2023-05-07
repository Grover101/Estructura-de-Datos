using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilistasMaterias
{
    public partial class Form1 : Form
    {
        Multilista multilista = new Multilista();

        private DataTable dtMaterias;
        private DataTable dtEstudiantes;

        private DataTable dtEstudiante;
        private DataTable dtListaEstudiantes;
        private DataTable dtMateria;
        private DataTable dtListaMateriasActualizada;

        public void MostrarMaterias(DataTable dtMaterias)
        {
            NodoMateria p;
            dtMaterias.Rows.Clear();
            p = multilista.carrera.EnlaceMateria;
            while(p!=null)
            {
                DataRow row = dtMaterias.NewRow();
                row["Sigla"] = p.Sigla;
                row["Nombre materia"] = p.NombreMateria;

                dtMaterias.Rows.Add(row);
                p = p.EnlaceMateria;
            }
        }

        public void MostrarEstudiantes(DataTable dtEstudiantes)
        {
            NodoMateria p;
            NodoEstudiante q;

            dtEstudiantes.Rows.Clear();
            p = multilista.carrera.EnlaceMateria;
            while(p != null)
            {
                DataRow rowMateria = dtEstudiantes.NewRow();
                rowMateria["Sigla"] = p.Sigla;
                dtEstudiantes.Rows.Add(rowMateria);
                q = p.EnlaceEstudiante;
                while (q != null)
                {
                    DataRow rowEstudiante = dtEstudiantes.NewRow();
                    rowEstudiante["Cu"] = q.Cu;
                    rowEstudiante["Ci"] = q.Ci;
                    rowEstudiante["Nombre"] = q.NombreCompleto;
                    rowEstudiante["Direccion"] = q.Direccion;
                    rowEstudiante["Celular"] = q.Celular;
                    dtEstudiantes.Rows.Add(rowEstudiante);
                    q = q.EnlaceEstudiante;
                }
                p = p.EnlaceMateria;
            }

        }
        public Form1()
        {
            InitializeComponent();

            dtMaterias = new DataTable();
            dtMaterias.Columns.Add("Sigla");
            dtMaterias.Columns.Add("Nombre materia");
            dgvMaterias.DataSource = dtMaterias;

            //
            dtEstudiantes = new DataTable();
            dtEstudiantes.Columns.Add("Sigla");
            dtEstudiantes.Columns.Add("Cu");
            dtEstudiantes.Columns.Add("Ci");
            dtEstudiantes.Columns.Add("Nombre");
            dtEstudiantes.Columns.Add("Direccion");
            dtEstudiantes.Columns.Add("Celular");

            dgvEstudiantes.DataSource = dtEstudiantes;
            //
            dtEstudiante = new DataTable();
            dtEstudiante.Columns.Add("Sigla");
            dtEstudiante.Columns.Add("Cu");
            dtEstudiante.Columns.Add("Ci");
            dtEstudiante.Columns.Add("Nombre");
            dtEstudiante.Columns.Add("Direccion");
            dtEstudiante.Columns.Add("Celular");

            dgvDatosEstudiante.DataSource = dtEstudiante;

            //
            dtListaEstudiantes = new DataTable();
            dtListaEstudiantes.Columns.Add("Sigla");
            dtListaEstudiantes.Columns.Add("Cu");
            dtListaEstudiantes.Columns.Add("Ci");
            dtListaEstudiantes.Columns.Add("Nombre");
            dtListaEstudiantes.Columns.Add("Direccion");
            dtListaEstudiantes.Columns.Add("Celular");

            dgvListaEstudiantesActualizada.DataSource = dtListaEstudiantes;

            //

            dtMateria = new DataTable();
            dtMateria.Columns.Add("Sigla");
            dtMateria.Columns.Add("Nombre materia");
            dgvDatosMateria.DataSource = dtMateria;
            //
            dtListaMateriasActualizada = new DataTable();
            dtListaMateriasActualizada.Columns.Add("Sigla");
            dtListaMateriasActualizada.Columns.Add("Nombre materia");
            dgvListaMateriasActualizada.DataSource = dtListaMateriasActualizada;
        }

        private void btnCrearCarrrera_Click(object sender, EventArgs e)
        {
            multilista.crearCarrera(txtNombreCarrera.Text);
        }

        private void btnInsertarMateria_Click(object sender, EventArgs e)
        {
            multilista.insertarMateria(txtSiglaMateria.Text,txtNombreMateria.Text);
            txtSiglaMateria.Text = "";
            txtNombreMateria.Text = "";
            txtSiglaMateria.Focus();
            txtCantidadMaterias.Text = multilista.carrera.CantidadMaterias.ToString();
        }

        private void btnMostrarListadoMaterias_Click(object sender, EventArgs e)
        {
            MostrarMaterias(dtMaterias);
        }

        private void btnInsertarEstudiante_Click(object sender, EventArgs e)
        {
            NodoMateria materia;
            materia = multilista.buscarMateria(txtSigla.Text);
            if (materia != null)
            {
                multilista.insertarEstudiante(materia, txtCu.Text, txtCi.Text, txtNombreEstudiante.Text, txtDireccion.Text, txtCelular.Text);
                txtCu.Text = "";
                txtCi.Text = "";
                txtNombreEstudiante.Text = "";
                txtDireccion.Text = "";
                txtCelular.Text = "";
                txtCu.Focus();
            }
            else
                MessageBox.Show("La materia no esta registrada");
        }

        private void btnMostrarListadoEstudiantes_Click(object sender, EventArgs e)
        {
            MostrarEstudiantes(dtEstudiantes);
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            NodoEstudiante estudiante;
            estudiante = multilista.buscarEstudiante(txtSiglaBusqueda.Text, txtCuBusqueda.Text);
            if (estudiante != null)
            {
                dtEstudiante.Rows.Clear();
                DataRow rowEstudiante = dtEstudiante.NewRow();
                rowEstudiante["Cu"] = estudiante.Cu;
                rowEstudiante["Ci"] = estudiante.Ci;
                rowEstudiante["Nombre"] = estudiante.NombreCompleto;
                rowEstudiante["Direccion"] = estudiante.Direccion;
                rowEstudiante["Celular"] = estudiante.Celular;
                dtEstudiante.Rows.Add(rowEstudiante);
            }
            else
            {
                MessageBox.Show("El estudiante no se encuentra registrado");
                dtEstudiante.Rows.Clear();
            }
                
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            multilista.eliminarEstudiante(txtSiglaEliminar.Text, txtCuEliminar.Text);
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            MostrarEstudiantes(dtListaEstudiantes);
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            NodoMateria materia;
            materia = multilista.buscarMateria(txtSiglaBuscarMateria.Text);
            if(materia != null)
            {
                dtMateria.Rows.Clear();
                DataRow rowMateria = dtMateria.NewRow();
                rowMateria["Sigla"] = materia.Sigla;
                rowMateria["Nombre materia"] = materia.NombreMateria;
                dtMateria.Rows.Add(rowMateria);
            }
            else
            {
                MessageBox.Show("La materia no se encuentra registrada");
                dtMateria.Rows.Clear();
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            multilista.eliminarMateria(txtSiglaMateriaEliminar.Text);
            txtCantidadMateriasActualizada.Text = multilista.carrera.CantidadMaterias.ToString();
        }

        private void btnListarMateriasActualizadas_Click(object sender, EventArgs e)
        {
            MostrarMaterias(dtListaMateriasActualizada);
        }
    }
}
