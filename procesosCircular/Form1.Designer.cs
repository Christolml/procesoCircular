namespace procesosCircular
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
            this.btnProcesoCircular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInformación = new System.Windows.Forms.TextBox();
            this.txtCiclos = new System.Windows.Forms.TextBox();
            this.txtResultadoProcesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcesoCircular
            // 
            this.btnProcesoCircular.Location = new System.Drawing.Point(12, 406);
            this.btnProcesoCircular.Name = "btnProcesoCircular";
            this.btnProcesoCircular.Size = new System.Drawing.Size(131, 59);
            this.btnProcesoCircular.TabIndex = 0;
            this.btnProcesoCircular.Text = "Proceso \r\ncircular\r\n";
            this.btnProcesoCircular.UseVisualStyleBackColor = true;
            this.btnProcesoCircular.Click += new System.EventHandler(this.btnProcesoCircular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1007, 500);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 56);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ciclos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Procesos";
            // 
            // txtInformación
            // 
            this.txtInformación.Location = new System.Drawing.Point(289, 379);
            this.txtInformación.Multiline = true;
            this.txtInformación.Name = "txtInformación";
            this.txtInformación.Size = new System.Drawing.Size(474, 113);
            this.txtInformación.TabIndex = 10;
            // 
            // txtCiclos
            // 
            this.txtCiclos.Location = new System.Drawing.Point(564, 92);
            this.txtCiclos.Multiline = true;
            this.txtCiclos.Name = "txtCiclos";
            this.txtCiclos.Size = new System.Drawing.Size(458, 228);
            this.txtCiclos.TabIndex = 9;
            // 
            // txtResultadoProcesos
            // 
            this.txtResultadoProcesos.Location = new System.Drawing.Point(36, 92);
            this.txtResultadoProcesos.Multiline = true;
            this.txtResultadoProcesos.Name = "txtResultadoProcesos";
            this.txtResultadoProcesos.Size = new System.Drawing.Size(316, 228);
            this.txtResultadoProcesos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 604);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInformación);
            this.Controls.Add(this.txtCiclos);
            this.Controls.Add(this.txtResultadoProcesos);
            this.Controls.Add(this.btnProcesoCircular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesoCircular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInformación;
        private System.Windows.Forms.TextBox txtCiclos;
        private System.Windows.Forms.TextBox txtResultadoProcesos;
    }
}

