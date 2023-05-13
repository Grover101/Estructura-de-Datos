namespace PilasConLSE
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
            this.txtElementoPila = new System.Windows.Forms.TextBox();
            this.btnInsertarPila = new System.Windows.Forms.Button();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.lstViewPila = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstViewCola = new System.Windows.Forms.ListView();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.txtBoxElementoCola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILAS CON LISTAS SIMPLEMENTE ENLAZADAS";
            // 
            // txtElementoPila
            // 
            this.txtElementoPila.Location = new System.Drawing.Point(132, 82);
            this.txtElementoPila.Name = "txtElementoPila";
            this.txtElementoPila.Size = new System.Drawing.Size(193, 22);
            this.txtElementoPila.TabIndex = 1;
            // 
            // btnInsertarPila
            // 
            this.btnInsertarPila.Location = new System.Drawing.Point(347, 78);
            this.btnInsertarPila.Name = "btnInsertarPila";
            this.btnInsertarPila.Size = new System.Drawing.Size(167, 31);
            this.btnInsertarPila.TabIndex = 2;
            this.btnInsertarPila.Text = "Insertar elemento pila";
            this.btnInsertarPila.UseVisualStyleBackColor = true;
            this.btnInsertarPila.Click += new System.EventHandler(this.btnInsertarPila_Click);
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.Location = new System.Drawing.Point(534, 74);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(174, 35);
            this.btnEliminarPila.TabIndex = 3;
            this.btnEliminarPila.Text = "Eliminar elemento pila";
            this.btnEliminarPila.UseVisualStyleBackColor = true;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // lstViewPila
            // 
            this.lstViewPila.Location = new System.Drawing.Point(55, 135);
            this.lstViewPila.Name = "lstViewPila";
            this.lstViewPila.Size = new System.Drawing.Size(760, 133);
            this.lstViewPila.TabIndex = 4;
            this.lstViewPila.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elemento pila:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Elemento cola:";
            // 
            // lstViewCola
            // 
            this.lstViewCola.Location = new System.Drawing.Point(68, 370);
            this.lstViewCola.Name = "lstViewCola";
            this.lstViewCola.Size = new System.Drawing.Size(760, 133);
            this.lstViewCola.TabIndex = 9;
            this.lstViewCola.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.Location = new System.Drawing.Point(547, 309);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(174, 35);
            this.btnEliminarCola.TabIndex = 8;
            this.btnEliminarCola.Text = "Eliminar elemento cola";
            this.btnEliminarCola.UseVisualStyleBackColor = true;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(360, 313);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(167, 31);
            this.btnInsertarCola.TabIndex = 7;
            this.btnInsertarCola.Text = "Insertar elemento cola";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // txtBoxElementoCola
            // 
            this.txtBoxElementoCola.Location = new System.Drawing.Point(145, 317);
            this.txtBoxElementoCola.Name = "txtBoxElementoCola";
            this.txtBoxElementoCola.Size = new System.Drawing.Size(193, 22);
            this.txtBoxElementoCola.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstViewCola);
            this.Controls.Add(this.btnEliminarCola);
            this.Controls.Add(this.btnInsertarCola);
            this.Controls.Add(this.txtBoxElementoCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstViewPila);
            this.Controls.Add(this.btnEliminarPila);
            this.Controls.Add(this.btnInsertarPila);
            this.Controls.Add(this.txtElementoPila);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElementoPila;
        private System.Windows.Forms.Button btnInsertarPila;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.ListView lstViewPila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstViewCola;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnInsertarCola;
        private System.Windows.Forms.TextBox txtBoxElementoCola;
    }
}

