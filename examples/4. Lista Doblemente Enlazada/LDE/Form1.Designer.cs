namespace LDE
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
            this.txtElementoLista = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstLIsta = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarOrdenado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAS DOBLEMENTE ENLAZADAS";
            // 
            // txtElementoLista
            // 
            this.txtElementoLista.Location = new System.Drawing.Point(153, 92);
            this.txtElementoLista.Name = "txtElementoLista";
            this.txtElementoLista.Size = new System.Drawing.Size(175, 22);
            this.txtElementoLista.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(384, 80);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(189, 46);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(613, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(189, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstLIsta
            // 
            this.lstLIsta.Location = new System.Drawing.Point(49, 147);
            this.lstLIsta.Name = "lstLIsta";
            this.lstLIsta.Size = new System.Drawing.Size(955, 138);
            this.lstLIsta.TabIndex = 4;
            this.lstLIsta.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elemento lista:";
            // 
            // btnInsertarOrdenado
            // 
            this.btnInsertarOrdenado.Location = new System.Drawing.Point(829, 79);
            this.btnInsertarOrdenado.Name = "btnInsertarOrdenado";
            this.btnInsertarOrdenado.Size = new System.Drawing.Size(175, 49);
            this.btnInsertarOrdenado.TabIndex = 6;
            this.btnInsertarOrdenado.Text = "Insertar ordenado";
            this.btnInsertarOrdenado.UseVisualStyleBackColor = true;
            this.btnInsertarOrdenado.Click += new System.EventHandler(this.btnInsertarOrdenado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 331);
            this.Controls.Add(this.btnInsertarOrdenado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLIsta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtElementoLista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElementoLista;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView lstLIsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarOrdenado;
    }
}

