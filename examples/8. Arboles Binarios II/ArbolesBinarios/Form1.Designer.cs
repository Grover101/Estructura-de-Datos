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
            this.btnPOstOrdenNoRecursivo = new System.Windows.Forms.Button();
            this.btnPostOrdenRecursivo = new System.Windows.Forms.Button();
            this.btnEntreOrdenNoRecursivo = new System.Windows.Forms.Button();
            this.btnEntreOrdenRecursivo = new System.Windows.Forms.Button();
            this.btnHilvanar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARBOLES BINARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(118, 69);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(210, 22);
            this.txtElemento.TabIndex = 2;
            // 
            // btnCrearLexicografico
            // 
            this.btnCrearLexicografico.Location = new System.Drawing.Point(359, 60);
            this.btnCrearLexicografico.Name = "btnCrearLexicografico";
            this.btnCrearLexicografico.Size = new System.Drawing.Size(374, 34);
            this.btnCrearLexicografico.TabIndex = 3;
            this.btnCrearLexicografico.Text = "Crear arbol lexicografico";
            this.btnCrearLexicografico.UseVisualStyleBackColor = true;
            this.btnCrearLexicografico.Click += new System.EventHandler(this.btnCrearLexicografico_Click);
            // 
            // btnPreordenRecursivo
            // 
            this.btnPreordenRecursivo.Location = new System.Drawing.Point(359, 112);
            this.btnPreordenRecursivo.Name = "btnPreordenRecursivo";
            this.btnPreordenRecursivo.Size = new System.Drawing.Size(176, 34);
            this.btnPreordenRecursivo.TabIndex = 4;
            this.btnPreordenRecursivo.Text = "Preorden recursivo";
            this.btnPreordenRecursivo.UseVisualStyleBackColor = true;
            this.btnPreordenRecursivo.Click += new System.EventHandler(this.btnPreordenRecursivo_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(541, 112);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(192, 34);
            this.btnPreOrden.TabIndex = 5;
            this.btnPreOrden.Text = "Pre orden no recursivo";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // lstViewArbol
            // 
            this.lstViewArbol.Location = new System.Drawing.Point(30, 287);
            this.lstViewArbol.Name = "lstViewArbol";
            this.lstViewArbol.Size = new System.Drawing.Size(730, 264);
            this.lstViewArbol.TabIndex = 6;
            this.lstViewArbol.UseCompatibleStateImageBehavior = false;
            // 
            // btnPOstOrdenNoRecursivo
            // 
            this.btnPOstOrdenNoRecursivo.Location = new System.Drawing.Point(541, 211);
            this.btnPOstOrdenNoRecursivo.Name = "btnPOstOrdenNoRecursivo";
            this.btnPOstOrdenNoRecursivo.Size = new System.Drawing.Size(192, 34);
            this.btnPOstOrdenNoRecursivo.TabIndex = 8;
            this.btnPOstOrdenNoRecursivo.Text = "Postorden no recursivo";
            this.btnPOstOrdenNoRecursivo.UseVisualStyleBackColor = true;
            this.btnPOstOrdenNoRecursivo.Click += new System.EventHandler(this.btnPOstOrdenNoRecursivo_Click);
            // 
            // btnPostOrdenRecursivo
            // 
            this.btnPostOrdenRecursivo.Location = new System.Drawing.Point(359, 211);
            this.btnPostOrdenRecursivo.Name = "btnPostOrdenRecursivo";
            this.btnPostOrdenRecursivo.Size = new System.Drawing.Size(176, 34);
            this.btnPostOrdenRecursivo.TabIndex = 7;
            this.btnPostOrdenRecursivo.Text = "Postorden recursivo";
            this.btnPostOrdenRecursivo.UseVisualStyleBackColor = true;
            this.btnPostOrdenRecursivo.Click += new System.EventHandler(this.btnPostOrdenRecursivo_Click);
            // 
            // btnEntreOrdenNoRecursivo
            // 
            this.btnEntreOrdenNoRecursivo.Location = new System.Drawing.Point(541, 162);
            this.btnEntreOrdenNoRecursivo.Name = "btnEntreOrdenNoRecursivo";
            this.btnEntreOrdenNoRecursivo.Size = new System.Drawing.Size(192, 34);
            this.btnEntreOrdenNoRecursivo.TabIndex = 10;
            this.btnEntreOrdenNoRecursivo.Text = "Entreorden no recursivo";
            this.btnEntreOrdenNoRecursivo.UseVisualStyleBackColor = true;
            this.btnEntreOrdenNoRecursivo.Click += new System.EventHandler(this.btnEntreOrdenNoRecursivo_Click);
            // 
            // btnEntreOrdenRecursivo
            // 
            this.btnEntreOrdenRecursivo.Location = new System.Drawing.Point(359, 162);
            this.btnEntreOrdenRecursivo.Name = "btnEntreOrdenRecursivo";
            this.btnEntreOrdenRecursivo.Size = new System.Drawing.Size(176, 34);
            this.btnEntreOrdenRecursivo.TabIndex = 9;
            this.btnEntreOrdenRecursivo.Text = "Entreorden recursivo";
            this.btnEntreOrdenRecursivo.UseVisualStyleBackColor = true;
            this.btnEntreOrdenRecursivo.Click += new System.EventHandler(this.btnEntreOrdenRecursivo_Click);
            // 
            // btnHilvanar
            // 
            this.btnHilvanar.Location = new System.Drawing.Point(766, 62);
            this.btnHilvanar.Name = "btnHilvanar";
            this.btnHilvanar.Size = new System.Drawing.Size(168, 31);
            this.btnHilvanar.TabIndex = 11;
            this.btnHilvanar.Text = "Hilvanar";
            this.btnHilvanar.UseVisualStyleBackColor = true;
            this.btnHilvanar.Click += new System.EventHandler(this.btnHilvanar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 567);
            this.Controls.Add(this.btnHilvanar);
            this.Controls.Add(this.btnEntreOrdenNoRecursivo);
            this.Controls.Add(this.btnEntreOrdenRecursivo);
            this.Controls.Add(this.btnPOstOrdenNoRecursivo);
            this.Controls.Add(this.btnPostOrdenRecursivo);
            this.Controls.Add(this.lstViewArbol);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnPreordenRecursivo);
            this.Controls.Add(this.btnCrearLexicografico);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnPOstOrdenNoRecursivo;
        private System.Windows.Forms.Button btnPostOrdenRecursivo;
        private System.Windows.Forms.Button btnEntreOrdenNoRecursivo;
        private System.Windows.Forms.Button btnEntreOrdenRecursivo;
        private System.Windows.Forms.Button btnHilvanar;
    }
}

