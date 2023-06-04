namespace Grafos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstViewVertices = new System.Windows.Forms.ListView();
            this.btnMostrarVertices = new System.Windows.Forms.Button();
            this.btnInsertarVertice = new System.Windows.Forms.Button();
            this.txtVertice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVerticeY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstViewArcos = new System.Windows.Forms.ListView();
            this.btnMostrarArcos = new System.Windows.Forms.Button();
            this.btnInsertarArco = new System.Windows.Forms.Button();
            this.txtVerticeX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarVertice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRAFOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarVertice);
            this.groupBox1.Controls.Add(this.lstViewVertices);
            this.groupBox1.Controls.Add(this.btnMostrarVertices);
            this.groupBox1.Controls.Add(this.btnInsertarVertice);
            this.groupBox1.Controls.Add(this.txtVertice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar y mostrar vértice";
            // 
            // lstViewVertices
            // 
            this.lstViewVertices.Location = new System.Drawing.Point(23, 87);
            this.lstViewVertices.Name = "lstViewVertices";
            this.lstViewVertices.Size = new System.Drawing.Size(780, 89);
            this.lstViewVertices.TabIndex = 4;
            this.lstViewVertices.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarVertices
            // 
            this.btnMostrarVertices.Location = new System.Drawing.Point(465, 25);
            this.btnMostrarVertices.Name = "btnMostrarVertices";
            this.btnMostrarVertices.Size = new System.Drawing.Size(159, 31);
            this.btnMostrarVertices.TabIndex = 3;
            this.btnMostrarVertices.Text = "Mostrar vértices";
            this.btnMostrarVertices.UseVisualStyleBackColor = true;
            this.btnMostrarVertices.Click += new System.EventHandler(this.btnMostrarVertices_Click);
            // 
            // btnInsertarVertice
            // 
            this.btnInsertarVertice.Location = new System.Drawing.Point(281, 25);
            this.btnInsertarVertice.Name = "btnInsertarVertice";
            this.btnInsertarVertice.Size = new System.Drawing.Size(159, 31);
            this.btnInsertarVertice.TabIndex = 2;
            this.btnInsertarVertice.Text = "Insertar vértice";
            this.btnInsertarVertice.UseVisualStyleBackColor = true;
            this.btnInsertarVertice.Click += new System.EventHandler(this.btnInsertarVertice_Click);
            // 
            // txtVertice
            // 
            this.txtVertice.Location = new System.Drawing.Point(120, 29);
            this.txtVertice.Name = "txtVertice";
            this.txtVertice.Size = new System.Drawing.Size(111, 22);
            this.txtVertice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vertice:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVerticeY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstViewArcos);
            this.groupBox2.Controls.Add(this.btnMostrarArcos);
            this.groupBox2.Controls.Add(this.btnInsertarArco);
            this.groupBox2.Controls.Add(this.txtVerticeX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(26, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar y mostrar arco";
            // 
            // txtVerticeY
            // 
            this.txtVerticeY.Location = new System.Drawing.Point(302, 36);
            this.txtVerticeY.Name = "txtVerticeY";
            this.txtVerticeY.Size = new System.Drawing.Size(111, 22);
            this.txtVerticeY.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vertice y:";
            // 
            // lstViewArcos
            // 
            this.lstViewArcos.Location = new System.Drawing.Point(23, 87);
            this.lstViewArcos.Name = "lstViewArcos";
            this.lstViewArcos.Size = new System.Drawing.Size(780, 89);
            this.lstViewArcos.TabIndex = 4;
            this.lstViewArcos.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarArcos
            // 
            this.btnMostrarArcos.Location = new System.Drawing.Point(630, 34);
            this.btnMostrarArcos.Name = "btnMostrarArcos";
            this.btnMostrarArcos.Size = new System.Drawing.Size(159, 31);
            this.btnMostrarArcos.TabIndex = 3;
            this.btnMostrarArcos.Text = "Mostrar arcos";
            this.btnMostrarArcos.UseVisualStyleBackColor = true;
            this.btnMostrarArcos.Click += new System.EventHandler(this.btnMostrarArcos_Click);
            // 
            // btnInsertarArco
            // 
            this.btnInsertarArco.Location = new System.Drawing.Point(446, 32);
            this.btnInsertarArco.Name = "btnInsertarArco";
            this.btnInsertarArco.Size = new System.Drawing.Size(159, 31);
            this.btnInsertarArco.TabIndex = 2;
            this.btnInsertarArco.Text = "Insertar arco";
            this.btnInsertarArco.UseVisualStyleBackColor = true;
            this.btnInsertarArco.Click += new System.EventHandler(this.btnInsertarArco_Click);
            // 
            // txtVerticeX
            // 
            this.txtVerticeX.Location = new System.Drawing.Point(90, 34);
            this.txtVerticeX.Name = "txtVerticeX";
            this.txtVerticeX.Size = new System.Drawing.Size(111, 22);
            this.txtVerticeX.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vertice x:";
            // 
            // btnEliminarVertice
            // 
            this.btnEliminarVertice.Location = new System.Drawing.Point(644, 25);
            this.btnEliminarVertice.Name = "btnEliminarVertice";
            this.btnEliminarVertice.Size = new System.Drawing.Size(159, 31);
            this.btnEliminarVertice.TabIndex = 5;
            this.btnEliminarVertice.Text = "Eliminar vértice";
            this.btnEliminarVertice.UseVisualStyleBackColor = true;
            this.btnEliminarVertice.Click += new System.EventHandler(this.btnEliminarVertice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstViewVertices;
        private System.Windows.Forms.Button btnMostrarVertices;
        private System.Windows.Forms.Button btnInsertarVertice;
        private System.Windows.Forms.TextBox txtVertice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVerticeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstViewArcos;
        private System.Windows.Forms.Button btnMostrarArcos;
        private System.Windows.Forms.Button btnInsertarArco;
        private System.Windows.Forms.TextBox txtVerticeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarVertice;
    }
}

