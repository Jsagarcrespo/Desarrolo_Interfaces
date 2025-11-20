namespace ejercicio01_calculadora
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.flpOperando2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lOperando2 = new System.Windows.Forms.Label();
            this.nudOperando2 = new System.Windows.Forms.NumericUpDown();
            this.bDividir = new System.Windows.Forms.Button();
            this.bMultiplicar = new System.Windows.Forms.Button();
            this.bRestar = new System.Windows.Forms.Button();
            this.bSumar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bElevar = new System.Windows.Forms.Button();
            this.flpResultado = new System.Windows.Forms.FlowLayoutPanel();
            this.lResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.flpOperando1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lOperando1 = new System.Windows.Forms.Label();
            this.nudOperando1 = new System.Windows.Forms.NumericUpDown();
            this.tlpPrincipal.SuspendLayout();
            this.flpOperando2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperando2)).BeginInit();
            this.flpResultado.SuspendLayout();
            this.flpOperando1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperando1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlpPrincipal.Controls.Add(this.flpOperando2, 0, 2);
            this.tlpPrincipal.Controls.Add(this.bDividir, 2, 2);
            this.tlpPrincipal.Controls.Add(this.bMultiplicar, 1, 2);
            this.tlpPrincipal.Controls.Add(this.bRestar, 2, 1);
            this.tlpPrincipal.Controls.Add(this.bSumar, 1, 1);
            this.tlpPrincipal.Controls.Add(this.bBorrar, 2, 0);
            this.tlpPrincipal.Controls.Add(this.bElevar, 1, 0);
            this.tlpPrincipal.Controls.Add(this.flpResultado, 0, 0);
            this.tlpPrincipal.Controls.Add(this.flpOperando1, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPrincipal.Size = new System.Drawing.Size(528, 267);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // flpOperando2
            // 
            this.flpOperando2.Controls.Add(this.lOperando2);
            this.flpOperando2.Controls.Add(this.nudOperando2);
            this.flpOperando2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOperando2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOperando2.Location = new System.Drawing.Point(3, 181);
            this.flpOperando2.Name = "flpOperando2";
            this.flpOperando2.Padding = new System.Windows.Forms.Padding(3);
            this.flpOperando2.Size = new System.Drawing.Size(220, 83);
            this.flpOperando2.TabIndex = 10;
            // 
            // lOperando2
            // 
            this.lOperando2.AutoSize = true;
            this.lOperando2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperando2.Location = new System.Drawing.Point(6, 3);
            this.lOperando2.Name = "lOperando2";
            this.lOperando2.Size = new System.Drawing.Size(180, 25);
            this.lOperando2.TabIndex = 0;
            this.lOperando2.Text = "Segundo operando";
            // 
            // nudOperando2
            // 
            this.nudOperando2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOperando2.Location = new System.Drawing.Point(6, 31);
            this.nudOperando2.Name = "nudOperando2";
            this.nudOperando2.Size = new System.Drawing.Size(202, 39);
            this.nudOperando2.TabIndex = 1;
            // 
            // bDividir
            // 
            this.bDividir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDividir.Location = new System.Drawing.Point(384, 186);
            this.bDividir.Margin = new System.Windows.Forms.Padding(8);
            this.bDividir.Name = "bDividir";
            this.bDividir.Size = new System.Drawing.Size(136, 73);
            this.bDividir.TabIndex = 8;
            this.bDividir.Text = "/";
            this.bDividir.UseVisualStyleBackColor = true;
            // 
            // bMultiplicar
            // 
            this.bMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMultiplicar.Location = new System.Drawing.Point(234, 186);
            this.bMultiplicar.Margin = new System.Windows.Forms.Padding(8);
            this.bMultiplicar.Name = "bMultiplicar";
            this.bMultiplicar.Size = new System.Drawing.Size(134, 73);
            this.bMultiplicar.TabIndex = 7;
            this.bMultiplicar.Text = "x";
            this.bMultiplicar.UseVisualStyleBackColor = true;
            // 
            // bRestar
            // 
            this.bRestar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestar.Location = new System.Drawing.Point(384, 97);
            this.bRestar.Margin = new System.Windows.Forms.Padding(8);
            this.bRestar.Name = "bRestar";
            this.bRestar.Size = new System.Drawing.Size(136, 73);
            this.bRestar.TabIndex = 5;
            this.bRestar.Text = "-";
            this.bRestar.UseVisualStyleBackColor = true;
            // 
            // bSumar
            // 
            this.bSumar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSumar.Location = new System.Drawing.Point(234, 97);
            this.bSumar.Margin = new System.Windows.Forms.Padding(8);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(134, 73);
            this.bSumar.TabIndex = 4;
            this.bSumar.Text = "+";
            this.bSumar.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            this.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(384, 8);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(8);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(136, 73);
            this.bBorrar.TabIndex = 2;
            this.bBorrar.Text = "C";
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // bElevar
            // 
            this.bElevar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bElevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bElevar.Location = new System.Drawing.Point(234, 8);
            this.bElevar.Margin = new System.Windows.Forms.Padding(8);
            this.bElevar.Name = "bElevar";
            this.bElevar.Size = new System.Drawing.Size(134, 73);
            this.bElevar.TabIndex = 0;
            this.bElevar.Text = "^";
            this.bElevar.UseVisualStyleBackColor = true;
            // 
            // flpResultado
            // 
            this.flpResultado.Controls.Add(this.lResultado);
            this.flpResultado.Controls.Add(this.tbResultado);
            this.flpResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResultado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpResultado.Location = new System.Drawing.Point(3, 3);
            this.flpResultado.Name = "flpResultado";
            this.flpResultado.Padding = new System.Windows.Forms.Padding(3);
            this.flpResultado.Size = new System.Drawing.Size(220, 83);
            this.flpResultado.TabIndex = 1;
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultado.Location = new System.Drawing.Point(6, 3);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(99, 25);
            this.lResultado.TabIndex = 0;
            this.lResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(6, 31);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(202, 39);
            this.tbResultado.TabIndex = 1;
            // 
            // flpOperando1
            // 
            this.flpOperando1.Controls.Add(this.lOperando1);
            this.flpOperando1.Controls.Add(this.nudOperando1);
            this.flpOperando1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOperando1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOperando1.Location = new System.Drawing.Point(3, 92);
            this.flpOperando1.Name = "flpOperando1";
            this.flpOperando1.Padding = new System.Windows.Forms.Padding(3);
            this.flpOperando1.Size = new System.Drawing.Size(220, 83);
            this.flpOperando1.TabIndex = 9;
            // 
            // lOperando1
            // 
            this.lOperando1.AutoSize = true;
            this.lOperando1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperando1.Location = new System.Drawing.Point(6, 3);
            this.lOperando1.Name = "lOperando1";
            this.lOperando1.Size = new System.Drawing.Size(156, 25);
            this.lOperando1.TabIndex = 0;
            this.lOperando1.Text = "Primer operando";
            // 
            // nudOperando1
            // 
            this.nudOperando1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOperando1.Location = new System.Drawing.Point(6, 31);
            this.nudOperando1.Name = "nudOperando1";
            this.nudOperando1.Size = new System.Drawing.Size(202, 39);
            this.nudOperando1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 267);
            this.Controls.Add(this.tlpPrincipal);
            this.MinimumSize = new System.Drawing.Size(550, 323);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.flpOperando2.ResumeLayout(false);
            this.flpOperando2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperando2)).EndInit();
            this.flpResultado.ResumeLayout(false);
            this.flpResultado.PerformLayout();
            this.flpOperando1.ResumeLayout(false);
            this.flpOperando1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperando1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpOperando2;
        private System.Windows.Forms.Label lOperando2;
        private System.Windows.Forms.NumericUpDown nudOperando2;
        private System.Windows.Forms.Button bDividir;
        private System.Windows.Forms.Button bMultiplicar;
        private System.Windows.Forms.Button bRestar;
        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bElevar;
        private System.Windows.Forms.FlowLayoutPanel flpResultado;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.FlowLayoutPanel flpOperando1;
        private System.Windows.Forms.Label lOperando1;
        private System.Windows.Forms.NumericUpDown nudOperando1;
    }
}

