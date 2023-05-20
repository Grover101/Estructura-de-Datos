namespace ArbolesBinarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnCrearLexicografico = new System.Windows.Forms.Button();
            this.btnPreordenRecursivo = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.lstViewArbol = new System.Windows.Forms.ListView();
            this.InOrden = new System.Windows.Forms.Button();
            this.InOrdenRecursivo = new System.Windows.Forms.Button();
            this.PosOrden = new System.Windows.Forms.Button();
            this.PosOrdenRecursivo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARBOLES BINARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(88, 56);
            this.txtElemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(158, 20);
            this.txtElemento.TabIndex = 2;
            // 
            // btnCrearLexicografico
            // 
            this.btnCrearLexicografico.Location = new System.Drawing.Point(269, 49);
            this.btnCrearLexicografico.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearLexicografico.Name = "btnCrearLexicografico";
            this.btnCrearLexicografico.Size = new System.Drawing.Size(280, 28);
            this.btnCrearLexicografico.TabIndex = 3;
            this.btnCrearLexicografico.Text = "Crear arbol lexicografico";
            this.btnCrearLexicografico.UseVisualStyleBackColor = true;
            this.btnCrearLexicografico.Click += new System.EventHandler(this.btnCrearLexicografico_Click);
            // 
            // btnPreordenRecursivo
            // 
            this.btnPreordenRecursivo.Location = new System.Drawing.Point(269, 91);
            this.btnPreordenRecursivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreordenRecursivo.Name = "btnPreordenRecursivo";
            this.btnPreordenRecursivo.Size = new System.Drawing.Size(132, 28);
            this.btnPreordenRecursivo.TabIndex = 4;
            this.btnPreordenRecursivo.Text = "Pre-Orden recursivo";
            this.btnPreordenRecursivo.UseVisualStyleBackColor = true;
            this.btnPreordenRecursivo.Click += new System.EventHandler(this.btnPreordenRecursivo_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(406, 91);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(144, 28);
            this.btnPreOrden.TabIndex = 5;
            this.btnPreOrden.Text = "Pre-Orden no recursivo";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // lstViewArbol
            // 
            this.lstViewArbol.HideSelection = false;
            this.lstViewArbol.Location = new System.Drawing.Point(11, 225);
            this.lstViewArbol.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewArbol.Name = "lstViewArbol";
            this.lstViewArbol.Size = new System.Drawing.Size(548, 129);
            this.lstViewArbol.TabIndex = 6;
            this.lstViewArbol.UseCompatibleStateImageBehavior = false;
            // 
            // InOrden
            // 
            this.InOrden.Location = new System.Drawing.Point(406, 176);
            this.InOrden.Margin = new System.Windows.Forms.Padding(2);
            this.InOrden.Name = "InOrden";
            this.InOrden.Size = new System.Drawing.Size(144, 28);
            this.InOrden.TabIndex = 8;
            this.InOrden.Text = "In-Orden no recursivo";
            this.InOrden.UseVisualStyleBackColor = true;
            this.InOrden.Click += new System.EventHandler(this.InOrden_Click);
            // 
            // InOrdenRecursivo
            // 
            this.InOrdenRecursivo.Location = new System.Drawing.Point(268, 176);
            this.InOrdenRecursivo.Margin = new System.Windows.Forms.Padding(2);
            this.InOrdenRecursivo.Name = "InOrdenRecursivo";
            this.InOrdenRecursivo.Size = new System.Drawing.Size(132, 28);
            this.InOrdenRecursivo.TabIndex = 7;
            this.InOrdenRecursivo.Text = "In-Orden recursivo";
            this.InOrdenRecursivo.UseVisualStyleBackColor = true;
            this.InOrdenRecursivo.Click += new System.EventHandler(this.InOrdenRecursivo_Click);
            // 
            // PosOrden
            // 
            this.PosOrden.Location = new System.Drawing.Point(405, 133);
            this.PosOrden.Margin = new System.Windows.Forms.Padding(2);
            this.PosOrden.Name = "PosOrden";
            this.PosOrden.Size = new System.Drawing.Size(144, 28);
            this.PosOrden.TabIndex = 10;
            this.PosOrden.Text = "Pos-orden no recursivo";
            this.PosOrden.UseVisualStyleBackColor = true;
            this.PosOrden.Click += new System.EventHandler(this.PosOrden_Click);
            // 
            // PosOrdenRecursivo
            // 
            this.PosOrdenRecursivo.Location = new System.Drawing.Point(268, 133);
            this.PosOrdenRecursivo.Margin = new System.Windows.Forms.Padding(2);
            this.PosOrdenRecursivo.Name = "PosOrdenRecursivo";
            this.PosOrdenRecursivo.Size = new System.Drawing.Size(132, 28);
            this.PosOrdenRecursivo.TabIndex = 9;
            this.PosOrdenRecursivo.Text = "Pos-Orden recursivo";
            this.PosOrdenRecursivo.UseVisualStyleBackColor = true;
            this.PosOrdenRecursivo.Click += new System.EventHandler(this.PosOrdenRecursivo_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(88, 91);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(127, 28);
            this.eliminar.TabIndex = 11;
            this.eliminar.Text = "Eliminar Nodo";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 372);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.PosOrden);
            this.Controls.Add(this.PosOrdenRecursivo);
            this.Controls.Add(this.InOrden);
            this.Controls.Add(this.InOrdenRecursivo);
            this.Controls.Add(this.lstViewArbol);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnPreordenRecursivo);
            this.Controls.Add(this.btnCrearLexicografico);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnCrearLexicografico;
        private System.Windows.Forms.Button btnPreordenRecursivo;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.ListView lstViewArbol;
        private System.Windows.Forms.Button InOrden;
        private System.Windows.Forms.Button InOrdenRecursivo;
        private System.Windows.Forms.Button PosOrden;
        private System.Windows.Forms.Button PosOrdenRecursivo;
        private System.Windows.Forms.Button eliminar;
    }
}

