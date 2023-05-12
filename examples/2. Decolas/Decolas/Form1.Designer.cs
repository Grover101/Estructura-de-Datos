namespace Decolas
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
            this.txtBoxElementoCola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarDelante = new System.Windows.Forms.Button();
            this.btnEliminarAtras = new System.Windows.Forms.Button();
            this.btnInvertirCola = new System.Windows.Forms.Button();
            this.lstViewCola = new System.Windows.Forms.ListView();
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DECOLAS E INVERTIR COLA";
            // 
            // txtBoxElementoCola
            // 
            this.txtBoxElementoCola.Location = new System.Drawing.Point(153, 111);
            this.txtBoxElementoCola.Name = "txtBoxElementoCola";
            this.txtBoxElementoCola.Size = new System.Drawing.Size(186, 22);
            this.txtBoxElementoCola.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elemento:";
            // 
            // btnInsertarDelante
            // 
            this.btnInsertarDelante.Location = new System.Drawing.Point(382, 101);
            this.btnInsertarDelante.Name = "btnInsertarDelante";
            this.btnInsertarDelante.Size = new System.Drawing.Size(173, 34);
            this.btnInsertarDelante.TabIndex = 3;
            this.btnInsertarDelante.Text = "Insertar delante";
            this.btnInsertarDelante.UseVisualStyleBackColor = true;
            this.btnInsertarDelante.Click += new System.EventHandler(this.btnInsertarDelante_Click);
            // 
            // btnEliminarAtras
            // 
            this.btnEliminarAtras.Location = new System.Drawing.Point(575, 100);
            this.btnEliminarAtras.Name = "btnEliminarAtras";
            this.btnEliminarAtras.Size = new System.Drawing.Size(187, 36);
            this.btnEliminarAtras.TabIndex = 4;
            this.btnEliminarAtras.Text = "Eliminar Atras";
            this.btnEliminarAtras.UseVisualStyleBackColor = true;
            this.btnEliminarAtras.Click += new System.EventHandler(this.btnEliminarAtras_Click);
            // 
            // btnInvertirCola
            // 
            this.btnInvertirCola.Location = new System.Drawing.Point(784, 99);
            this.btnInvertirCola.Name = "btnInvertirCola";
            this.btnInvertirCola.Size = new System.Drawing.Size(197, 37);
            this.btnInvertirCola.TabIndex = 5;
            this.btnInvertirCola.Text = "Invertir Cola";
            this.btnInvertirCola.UseVisualStyleBackColor = true;
            this.btnInvertirCola.Click += new System.EventHandler(this.btnInvertirCola_Click);
            // 
            // lstViewCola
            // 
            this.lstViewCola.Location = new System.Drawing.Point(100, 234);
            this.lstViewCola.Name = "lstViewCola";
            this.lstViewCola.Size = new System.Drawing.Size(880, 226);
            this.lstViewCola.TabIndex = 6;
            this.lstViewCola.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(386, 157);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(168, 39);
            this.btnInsertarCola.TabIndex = 7;
            this.btnInsertarCola.Text = "Insertar";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.btnInsertarCola);
            this.Controls.Add(this.lstViewCola);
            this.Controls.Add(this.btnInvertirCola);
            this.Controls.Add(this.btnEliminarAtras);
            this.Controls.Add(this.btnInsertarDelante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxElementoCola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxElementoCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarDelante;
        private System.Windows.Forms.Button btnEliminarAtras;
        private System.Windows.Forms.Button btnInvertirCola;
        private System.Windows.Forms.ListView lstViewCola;
        private System.Windows.Forms.Button btnInsertarCola;
    }
}

