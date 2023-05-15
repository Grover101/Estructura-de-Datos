namespace ListasCircularesYCabeza
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.lstViewListaCircular = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarListaCabeza = new System.Windows.Forms.Button();
            this.txtElementoListaCabeza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstViewListaCabeza = new System.Windows.Forms.ListView();
            this.txtCabeza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA SIMPLEMENTE ENLAZADA CIRCULAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(137, 86);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(143, 22);
            this.txtElemento.TabIndex = 2;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(308, 79);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(157, 36);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(498, 79);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(166, 36);
            this.btnInsertar2.TabIndex = 4;
            this.btnInsertar2.Text = "Insertar2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(679, 79);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(166, 36);
            this.btnLimpiarLista.TabIndex = 5;
            this.btnLimpiarLista.Text = "Limpiar";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // lstViewListaCircular
            // 
            this.lstViewListaCircular.Location = new System.Drawing.Point(31, 147);
            this.lstViewListaCircular.Name = "lstViewListaCircular";
            this.lstViewListaCircular.Size = new System.Drawing.Size(814, 107);
            this.lstViewListaCircular.TabIndex = 6;
            this.lstViewListaCircular.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "LISTA DOBLEMENTE ENLAZADA  CON NODO CABEZA";
            // 
            // btnInsertarListaCabeza
            // 
            this.btnInsertarListaCabeza.Location = new System.Drawing.Point(308, 339);
            this.btnInsertarListaCabeza.Name = "btnInsertarListaCabeza";
            this.btnInsertarListaCabeza.Size = new System.Drawing.Size(157, 36);
            this.btnInsertarListaCabeza.TabIndex = 10;
            this.btnInsertarListaCabeza.Text = "Insertar";
            this.btnInsertarListaCabeza.UseVisualStyleBackColor = true;
            this.btnInsertarListaCabeza.Click += new System.EventHandler(this.btnInsertarListaCabeza_Click);
            // 
            // txtElementoListaCabeza
            // 
            this.txtElementoListaCabeza.Location = new System.Drawing.Point(137, 346);
            this.txtElementoListaCabeza.Name = "txtElementoListaCabeza";
            this.txtElementoListaCabeza.Size = new System.Drawing.Size(143, 22);
            this.txtElementoListaCabeza.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elemento:";
            // 
            // lstViewListaCabeza
            // 
            this.lstViewListaCabeza.Location = new System.Drawing.Point(31, 399);
            this.lstViewListaCabeza.Name = "lstViewListaCabeza";
            this.lstViewListaCabeza.Size = new System.Drawing.Size(814, 107);
            this.lstViewListaCabeza.TabIndex = 11;
            this.lstViewListaCabeza.UseCompatibleStateImageBehavior = false;
            // 
            // txtCabeza
            // 
            this.txtCabeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabeza.Location = new System.Drawing.Point(645, 339);
            this.txtCabeza.Name = "txtCabeza";
            this.txtCabeza.ReadOnly = true;
            this.txtCabeza.Size = new System.Drawing.Size(143, 30);
            this.txtCabeza.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cabeza:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 535);
            this.Controls.Add(this.txtCabeza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstViewListaCabeza);
            this.Controls.Add(this.btnInsertarListaCabeza);
            this.Controls.Add(this.txtElementoListaCabeza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstViewListaCircular);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnInsertar);
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
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.ListView lstViewListaCircular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarListaCabeza;
        private System.Windows.Forms.TextBox txtElementoListaCabeza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstViewListaCabeza;
        private System.Windows.Forms.TextBox txtCabeza;
        private System.Windows.Forms.Label label5;
    }
}

