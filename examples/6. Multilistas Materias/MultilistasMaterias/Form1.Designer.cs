namespace MultilistasMaterias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnMostrarListadoMaterias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadMaterias = new System.Windows.Forms.TextBox();
            this.btnInsertarMateria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiglaMateria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCarrrera = new System.Windows.Forms.Button();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListadoEstudiantes = new System.Windows.Forms.Button();
            this.btnInsertarEstudiante = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMostrarEstudiantes = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvListaEstudiantesActualizada = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSiglaEliminar = new System.Windows.Forms.TextBox();
            this.txtCuEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDatosEstudiante = new System.Windows.Forms.DataGridView();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtCuBusqueda = new System.Windows.Forms.TextBox();
            this.txtSiglaBusqueda = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnListarMateriasActualizadas = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvListaMateriasActualizada = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSiglaMateriaEliminar = new System.Windows.Forms.TextBox();
            this.txtCantidadMateriasActualizada = new System.Windows.Forms.TextBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvDatosMateria = new System.Windows.Forms.DataGridView();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.txtSiglaBuscarMateria = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstudiantesActualizada)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiante)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriasActualizada)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(655, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear carrera e insertar materia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMaterias);
            this.groupBox2.Controls.Add(this.btnMostrarListadoMaterias);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCantidadMaterias);
            this.groupBox2.Controls.Add(this.btnInsertarMateria);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreMateria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSiglaMateria);
            this.groupBox2.Location = new System.Drawing.Point(21, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(616, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar materia:";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(15, 145);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.RowTemplate.Height = 24;
            this.dgvMaterias.Size = new System.Drawing.Size(580, 167);
            this.dgvMaterias.TabIndex = 10;
            // 
            // btnMostrarListadoMaterias
            // 
            this.btnMostrarListadoMaterias.Location = new System.Drawing.Point(470, 81);
            this.btnMostrarListadoMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarListadoMaterias.Name = "btnMostrarListadoMaterias";
            this.btnMostrarListadoMaterias.Size = new System.Drawing.Size(133, 28);
            this.btnMostrarListadoMaterias.TabIndex = 9;
            this.btnMostrarListadoMaterias.Text = "Mostrar materias";
            this.btnMostrarListadoMaterias.UseVisualStyleBackColor = true;
            this.btnMostrarListadoMaterias.Click += new System.EventHandler(this.btnMostrarListadoMaterias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de materias:";
            // 
            // txtCantidadMaterias
            // 
            this.txtCantidadMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMaterias.Location = new System.Drawing.Point(127, 81);
            this.txtCantidadMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadMaterias.Name = "txtCantidadMaterias";
            this.txtCantidadMaterias.ReadOnly = true;
            this.txtCantidadMaterias.Size = new System.Drawing.Size(106, 26);
            this.txtCantidadMaterias.TabIndex = 7;
            // 
            // btnInsertarMateria
            // 
            this.btnInsertarMateria.Location = new System.Drawing.Point(470, 41);
            this.btnInsertarMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarMateria.Name = "btnInsertarMateria";
            this.btnInsertarMateria.Size = new System.Drawing.Size(133, 28);
            this.btnInsertarMateria.TabIndex = 3;
            this.btnInsertarMateria.Text = "Insertar materia";
            this.btnInsertarMateria.UseVisualStyleBackColor = true;
            this.btnInsertarMateria.Click += new System.EventHandler(this.btnInsertarMateria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(258, 48);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMateria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sigla:";
            // 
            // txtSiglaMateria
            // 
            this.txtSiglaMateria.Location = new System.Drawing.Point(67, 48);
            this.txtSiglaMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiglaMateria.Name = "txtSiglaMateria";
            this.txtSiglaMateria.Size = new System.Drawing.Size(106, 20);
            this.txtSiglaMateria.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrearCarrrera);
            this.groupBox1.Controls.Add(this.txtNombreCarrera);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(620, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos carrrera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre carrera:";
            // 
            // btnCrearCarrrera
            // 
            this.btnCrearCarrrera.Location = new System.Drawing.Point(341, 41);
            this.btnCrearCarrrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearCarrrera.Name = "btnCrearCarrrera";
            this.btnCrearCarrrera.Size = new System.Drawing.Size(133, 28);
            this.btnCrearCarrrera.TabIndex = 1;
            this.btnCrearCarrrera.Text = "Crear carrera";
            this.btnCrearCarrrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrrera.Click += new System.EventHandler(this.btnCrearCarrrera_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(114, 46);
            this.txtNombreCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCarrera.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSigla);
            this.tabPage2.Controls.Add(this.dgvEstudiantes);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(655, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar estudiantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(109, 27);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(113, 20);
            this.txtSigla.TabIndex = 4;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(16, 299);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(616, 210);
            this.dgvEstudiantes.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrarListadoEstudiantes);
            this.groupBox3.Controls.Add(this.btnInsertarEstudiante);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCelular);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNombreEstudiante);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCu);
            this.groupBox3.Location = new System.Drawing.Point(16, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(598, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos estudiante:";
            // 
            // btnMostrarListadoEstudiantes
            // 
            this.btnMostrarListadoEstudiantes.Location = new System.Drawing.Point(436, 170);
            this.btnMostrarListadoEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarListadoEstudiantes.Name = "btnMostrarListadoEstudiantes";
            this.btnMostrarListadoEstudiantes.Size = new System.Drawing.Size(142, 34);
            this.btnMostrarListadoEstudiantes.TabIndex = 11;
            this.btnMostrarListadoEstudiantes.Text = "Mostrar listado estudiantes";
            this.btnMostrarListadoEstudiantes.UseVisualStyleBackColor = true;
            this.btnMostrarListadoEstudiantes.Click += new System.EventHandler(this.btnMostrarListadoEstudiantes_Click);
            // 
            // btnInsertarEstudiante
            // 
            this.btnInsertarEstudiante.Location = new System.Drawing.Point(296, 170);
            this.btnInsertarEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarEstudiante.Name = "btnInsertarEstudiante";
            this.btnInsertarEstudiante.Size = new System.Drawing.Size(116, 34);
            this.btnInsertarEstudiante.TabIndex = 10;
            this.btnInsertarEstudiante.Text = "Insertar estudiante";
            this.btnInsertarEstudiante.UseVisualStyleBackColor = true;
            this.btnInsertarEstudiante.Click += new System.EventHandler(this.btnInsertarEstudiante_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(436, 130);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(116, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(134, 126);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(217, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nombre completo:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(134, 91);
            this.txtNombreEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(420, 20);
            this.txtNombreEstudiante.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ci:";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(437, 52);
            this.txtCi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(116, 20);
            this.txtCi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cu:";
            // 
            // txtCu
            // 
            this.txtCu.Location = new System.Drawing.Point(134, 48);
            this.txtCu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCu.Name = "txtCu";
            this.txtCu.Size = new System.Drawing.Size(116, 20);
            this.txtCu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sigla materia:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(655, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar y eliminar estudiantes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMostrarEstudiantes);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dgvListaEstudiantesActualizada);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtSiglaEliminar);
            this.groupBox5.Controls.Add(this.txtCuEliminar);
            this.groupBox5.Controls.Add(this.btnEliminarEstudiante);
            this.groupBox5.Location = new System.Drawing.Point(21, 239);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(618, 277);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar estudiante:";
            // 
            // btnMostrarEstudiantes
            // 
            this.btnMostrarEstudiantes.Location = new System.Drawing.Point(478, 34);
            this.btnMostrarEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            this.btnMostrarEstudiantes.Size = new System.Drawing.Size(120, 30);
            this.btnMostrarEstudiantes.TabIndex = 12;
            this.btnMostrarEstudiantes.Text = "Mostrar estudiantes";
            this.btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            this.btnMostrarEstudiantes.Click += new System.EventHandler(this.btnMostrarEstudiantes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Cu:";
            // 
            // dgvListaEstudiantesActualizada
            // 
            this.dgvListaEstudiantesActualizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEstudiantesActualizada.Location = new System.Drawing.Point(14, 86);
            this.dgvListaEstudiantesActualizada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaEstudiantesActualizada.Name = "dgvListaEstudiantesActualizada";
            this.dgvListaEstudiantesActualizada.RowTemplate.Height = 24;
            this.dgvListaEstudiantesActualizada.Size = new System.Drawing.Size(585, 170);
            this.dgvListaEstudiantesActualizada.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Sigla:";
            // 
            // txtSiglaEliminar
            // 
            this.txtSiglaEliminar.Location = new System.Drawing.Point(66, 40);
            this.txtSiglaEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiglaEliminar.Name = "txtSiglaEliminar";
            this.txtSiglaEliminar.Size = new System.Drawing.Size(84, 20);
            this.txtSiglaEliminar.TabIndex = 6;
            // 
            // txtCuEliminar
            // 
            this.txtCuEliminar.Location = new System.Drawing.Point(196, 40);
            this.txtCuEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuEliminar.Name = "txtCuEliminar";
            this.txtCuEliminar.Size = new System.Drawing.Size(129, 20);
            this.txtCuEliminar.TabIndex = 7;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(340, 34);
            this.btnEliminarEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarEstudiante.TabIndex = 8;
            this.btnEliminarEstudiante.Text = "Eliminar estudiante";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dgvDatosEstudiante);
            this.groupBox4.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox4.Controls.Add(this.txtCuBusqueda);
            this.groupBox4.Controls.Add(this.txtSiglaBusqueda);
            this.groupBox4.Location = new System.Drawing.Point(22, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(618, 195);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar estudiante:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Cu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sigla:";
            // 
            // dgvDatosEstudiante
            // 
            this.dgvDatosEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEstudiante.Location = new System.Drawing.Point(20, 86);
            this.dgvDatosEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatosEstudiante.Name = "dgvDatosEstudiante";
            this.dgvDatosEstudiante.RowTemplate.Height = 24;
            this.dgvDatosEstudiante.Size = new System.Drawing.Size(585, 97);
            this.dgvDatosEstudiante.TabIndex = 3;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(412, 34);
            this.btnBuscarEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarEstudiante.TabIndex = 2;
            this.btnBuscarEstudiante.Text = "Buscar estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtCuBusqueda
            // 
            this.txtCuBusqueda.Location = new System.Drawing.Point(254, 40);
            this.txtCuBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuBusqueda.Name = "txtCuBusqueda";
            this.txtCuBusqueda.Size = new System.Drawing.Size(129, 20);
            this.txtCuBusqueda.TabIndex = 1;
            // 
            // txtSiglaBusqueda
            // 
            this.txtSiglaBusqueda.Location = new System.Drawing.Point(72, 40);
            this.txtSiglaBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiglaBusqueda.Name = "txtSiglaBusqueda";
            this.txtSiglaBusqueda.Size = new System.Drawing.Size(129, 20);
            this.txtSiglaBusqueda.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(655, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar y eliminar materia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnListarMateriasActualizadas);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.dgvListaMateriasActualizada);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtSiglaMateriaEliminar);
            this.groupBox6.Controls.Add(this.txtCantidadMateriasActualizada);
            this.groupBox6.Controls.Add(this.btnEliminarMateria);
            this.groupBox6.Location = new System.Drawing.Point(20, 236);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(618, 277);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Eliminar materia:";
            // 
            // btnListarMateriasActualizadas
            // 
            this.btnListarMateriasActualizadas.Location = new System.Drawing.Point(494, 34);
            this.btnListarMateriasActualizadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarMateriasActualizadas.Name = "btnListarMateriasActualizadas";
            this.btnListarMateriasActualizadas.Size = new System.Drawing.Size(120, 30);
            this.btnListarMateriasActualizadas.TabIndex = 12;
            this.btnListarMateriasActualizadas.Text = "Mostrar materias";
            this.btnListarMateriasActualizadas.UseVisualStyleBackColor = true;
            this.btnListarMateriasActualizadas.Click += new System.EventHandler(this.btnListarMateriasActualizadas_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(148, 42);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cantidad de materias:";
            // 
            // dgvListaMateriasActualizada
            // 
            this.dgvListaMateriasActualizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMateriasActualizada.Location = new System.Drawing.Point(14, 86);
            this.dgvListaMateriasActualizada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaMateriasActualizada.Name = "dgvListaMateriasActualizada";
            this.dgvListaMateriasActualizada.RowTemplate.Height = 24;
            this.dgvListaMateriasActualizada.Size = new System.Drawing.Size(585, 170);
            this.dgvListaMateriasActualizada.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 42);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Sigla:";
            // 
            // txtSiglaMateriaEliminar
            // 
            this.txtSiglaMateriaEliminar.Location = new System.Drawing.Point(48, 40);
            this.txtSiglaMateriaEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiglaMateriaEliminar.Name = "txtSiglaMateriaEliminar";
            this.txtSiglaMateriaEliminar.Size = new System.Drawing.Size(84, 20);
            this.txtSiglaMateriaEliminar.TabIndex = 6;
            // 
            // txtCantidadMateriasActualizada
            // 
            this.txtCantidadMateriasActualizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMateriasActualizada.Location = new System.Drawing.Point(271, 34);
            this.txtCantidadMateriasActualizada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadMateriasActualizada.Name = "txtCantidadMateriasActualizada";
            this.txtCantidadMateriasActualizada.ReadOnly = true;
            this.txtCantidadMateriasActualizada.Size = new System.Drawing.Size(58, 32);
            this.txtCantidadMateriasActualizada.TabIndex = 7;
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(361, 34);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarMateria.TabIndex = 8;
            this.btnEliminarMateria.Text = "Eliminar materia";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.dgvDatosMateria);
            this.groupBox7.Controls.Add(this.btnBuscarMateria);
            this.groupBox7.Controls.Add(this.txtSiglaBuscarMateria);
            this.groupBox7.Location = new System.Drawing.Point(20, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(618, 195);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar materia:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 42);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Sigla:";
            // 
            // dgvDatosMateria
            // 
            this.dgvDatosMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMateria.Location = new System.Drawing.Point(20, 86);
            this.dgvDatosMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatosMateria.Name = "dgvDatosMateria";
            this.dgvDatosMateria.RowTemplate.Height = 24;
            this.dgvDatosMateria.Size = new System.Drawing.Size(585, 97);
            this.dgvDatosMateria.TabIndex = 3;
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(224, 34);
            this.btnBuscarMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarMateria.TabIndex = 2;
            this.btnBuscarMateria.Text = "Buscar materia";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // txtSiglaBuscarMateria
            // 
            this.txtSiglaBuscarMateria.Location = new System.Drawing.Point(72, 40);
            this.txtSiglaBuscarMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiglaBuscarMateria.Name = "txtSiglaBuscarMateria";
            this.txtSiglaBuscarMateria.Size = new System.Drawing.Size(129, 20);
            this.txtSiglaBuscarMateria.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 570);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "-";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstudiantesActualizada)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiante)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriasActualizada)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCarrrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarListadoMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadMaterias;
        private System.Windows.Forms.Button btnInsertarMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiglaMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnMostrarListadoEstudiantes;
        private System.Windows.Forms.Button btnInsertarEstudiante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDatosEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtCuBusqueda;
        private System.Windows.Forms.TextBox txtSiglaBusqueda;
        private System.Windows.Forms.Button btnMostrarEstudiantes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvListaEstudiantesActualizada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSiglaEliminar;
        private System.Windows.Forms.TextBox txtCuEliminar;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnListarMateriasActualizadas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvListaMateriasActualizada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSiglaMateriaEliminar;
        private System.Windows.Forms.TextBox txtCantidadMateriasActualizada;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvDatosMateria;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.TextBox txtSiglaBuscarMateria;
    }
}

