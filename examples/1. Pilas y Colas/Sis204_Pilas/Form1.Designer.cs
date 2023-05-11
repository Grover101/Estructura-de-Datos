namespace Sis204_Pilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstViewPila = new System.Windows.Forms.ListView();
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnInsertarColaCircular = new System.Windows.Forms.Button();
            this.btnEliminarColaCircular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILAS y COLAS";
            // 
            // txtBoxElemento
            // 
            this.txtBoxElemento.Location = new System.Drawing.Point(143, 86);
            this.txtBoxElemento.Name = "txtBoxElemento";
            this.txtBoxElemento.Size = new System.Drawing.Size(100, 22);
            this.txtBoxElemento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elemento:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(300, 81);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(134, 32);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(489, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstViewPila
            // 
            this.lstViewPila.Location = new System.Drawing.Point(131, 258);
            this.lstViewPila.Name = "lstViewPila";
            this.lstViewPila.Size = new System.Drawing.Size(526, 220);
            this.lstViewPila.TabIndex = 5;
            this.lstViewPila.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(299, 128);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(174, 35);
            this.btnInsertarCola.TabIndex = 6;
            this.btnInsertarCola.Text = "Insertar elemento cola";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.Location = new System.Drawing.Point(489, 128);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(156, 34);
            this.btnEliminarCola.TabIndex = 7;
            this.btnEliminarCola.Text = "Eliminar elemento cola";
            this.btnEliminarCola.UseVisualStyleBackColor = true;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnInsertarColaCircular
            // 
            this.btnInsertarColaCircular.Location = new System.Drawing.Point(303, 185);
            this.btnInsertarColaCircular.Name = "btnInsertarColaCircular";
            this.btnInsertarColaCircular.Size = new System.Drawing.Size(213, 38);
            this.btnInsertarColaCircular.TabIndex = 8;
            this.btnInsertarColaCircular.Text = "Insertar elemento cola circular";
            this.btnInsertarColaCircular.UseVisualStyleBackColor = true;
            this.btnInsertarColaCircular.Click += new System.EventHandler(this.btnInsertarColaCircular_Click);
            // 
            // btnEliminarColaCircular
            // 
            this.btnEliminarColaCircular.Location = new System.Drawing.Point(530, 185);
            this.btnEliminarColaCircular.Name = "btnEliminarColaCircular";
            this.btnEliminarColaCircular.Size = new System.Drawing.Size(208, 37);
            this.btnEliminarColaCircular.TabIndex = 9;
            this.btnEliminarColaCircular.Text = "Eliminar elemento cola circular";
            this.btnEliminarColaCircular.UseVisualStyleBackColor = true;
            this.btnEliminarColaCircular.Click += new System.EventHandler(this.btnEliminarColaCircular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 561);
            this.Controls.Add(this.btnEliminarColaCircular);
            this.Controls.Add(this.btnInsertarColaCircular);
            this.Controls.Add(this.btnEliminarCola);
            this.Controls.Add(this.btnInsertarCola);
            this.Controls.Add(this.lstViewPila);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView lstViewPila;
        private System.Windows.Forms.Button btnInsertarCola;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnInsertarColaCircular;
        private System.Windows.Forms.Button btnEliminarColaCircular;
    }
}

