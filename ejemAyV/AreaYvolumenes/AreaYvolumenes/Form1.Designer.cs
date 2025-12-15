namespace AreaYvolumenes
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
            this.Magnitud = new System.Windows.Forms.GroupBox();
            this.radioVolumen = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Figura = new System.Windows.Forms.GroupBox();
            this.radioCirculo = new System.Windows.Forms.RadioButton();
            this.radioRectangulo = new System.Windows.Forms.RadioButton();
            this.Medidas = new System.Windows.Forms.GroupBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Magnitud.SuspendLayout();
            this.Figura.SuspendLayout();
            this.Medidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Magnitud
            // 
            this.Magnitud.Controls.Add(this.radioVolumen);
            this.Magnitud.Controls.Add(this.radioButton1);
            this.Magnitud.Location = new System.Drawing.Point(12, 12);
            this.Magnitud.Name = "Magnitud";
            this.Magnitud.Size = new System.Drawing.Size(177, 258);
            this.Magnitud.TabIndex = 0;
            this.Magnitud.TabStop = false;
            this.Magnitud.Text = "Magnitud";
            this.Magnitud.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioVolumen
            // 
            this.radioVolumen.AutoSize = true;
            this.radioVolumen.Location = new System.Drawing.Point(7, 97);
            this.radioVolumen.Name = "radioVolumen";
            this.radioVolumen.Size = new System.Drawing.Size(127, 29);
            this.radioVolumen.TabIndex = 1;
            this.radioVolumen.TabStop = true;
            this.radioVolumen.Text = "Volumen";
            this.radioVolumen.UseVisualStyleBackColor = true;
            this.radioVolumen.CheckedChanged += new System.EventHandler(this.radioVolumen_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Area";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Figura
            // 
            this.Figura.Controls.Add(this.radioCirculo);
            this.Figura.Controls.Add(this.radioRectangulo);
            this.Figura.Location = new System.Drawing.Point(195, 12);
            this.Figura.Name = "Figura";
            this.Figura.Size = new System.Drawing.Size(182, 258);
            this.Figura.TabIndex = 1;
            this.Figura.TabStop = false;
            this.Figura.Text = "Figura";
            this.Figura.Enter += new System.EventHandler(this.Figura_Enter);
            // 
            // radioCirculo
            // 
            this.radioCirculo.AutoSize = true;
            this.radioCirculo.Location = new System.Drawing.Point(7, 97);
            this.radioCirculo.Name = "radioCirculo";
            this.radioCirculo.Size = new System.Drawing.Size(110, 29);
            this.radioCirculo.TabIndex = 1;
            this.radioCirculo.TabStop = true;
            this.radioCirculo.Text = "Circulo";
            this.radioCirculo.UseVisualStyleBackColor = true;
            // 
            // radioRectangulo
            // 
            this.radioRectangulo.AutoSize = true;
            this.radioRectangulo.Location = new System.Drawing.Point(7, 49);
            this.radioRectangulo.Name = "radioRectangulo";
            this.radioRectangulo.Size = new System.Drawing.Size(152, 29);
            this.radioRectangulo.TabIndex = 0;
            this.radioRectangulo.TabStop = true;
            this.radioRectangulo.Text = "Rectangulo";
            this.radioRectangulo.UseVisualStyleBackColor = true;
            this.radioRectangulo.CheckedChanged += new System.EventHandler(this.radioRectangulo_CheckedChanged);
            // 
            // Medidas
            // 
            this.Medidas.Controls.Add(this.label1);
            this.Medidas.Location = new System.Drawing.Point(383, 12);
            this.Medidas.Name = "Medidas";
            this.Medidas.Size = new System.Drawing.Size(419, 258);
            this.Medidas.TabIndex = 2;
            this.Medidas.TabStop = false;
            this.Medidas.Text = "Medidas";
            this.Medidas.Enter += new System.EventHandler(this.Medidas_Enter);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(1, 276);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(376, 171);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(383, 276);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(419, 171);
            this.Limpiar.TabIndex = 4;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Medidas);
            this.Controls.Add(this.Figura);
            this.Controls.Add(this.Magnitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Magnitud.ResumeLayout(false);
            this.Magnitud.PerformLayout();
            this.Figura.ResumeLayout(false);
            this.Figura.PerformLayout();
            this.Medidas.ResumeLayout(false);
            this.Medidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Magnitud;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioVolumen;
        private System.Windows.Forms.GroupBox Figura;
        private System.Windows.Forms.RadioButton radioCirculo;
        private System.Windows.Forms.RadioButton radioRectangulo;
        private System.Windows.Forms.GroupBox Medidas;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label1;
    }
}

