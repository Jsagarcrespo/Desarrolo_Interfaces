namespace AreasYVolumenes
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpMagnitud = new System.Windows.Forms.TableLayoutPanel();
            this.Area = new System.Windows.Forms.RadioButton();
            this.Volumen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpFigura = new System.Windows.Forms.TableLayoutPanel();
            this.esfera = new System.Windows.Forms.RadioButton();
            this.cubo = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.circulo = new System.Windows.Forms.RadioButton();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.medidas = new System.Windows.Forms.GroupBox();
            this.tlpMedidas = new System.Windows.Forms.TableLayoutPanel();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.nudRadio = new System.Windows.Forms.NumericUpDown();
            this.nudLado = new System.Windows.Forms.NumericUpDown();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlpMagnitud.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlpFigura.SuspendLayout();
            this.medidas.SuspendLayout();
            this.tlpMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCalcular, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.limpiar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.medidas, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpMagnitud);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magnitud";
            // 
            // tlpMagnitud
            // 
            this.tlpMagnitud.ColumnCount = 1;
            this.tlpMagnitud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMagnitud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMagnitud.Controls.Add(this.Area, 0, 0);
            this.tlpMagnitud.Controls.Add(this.Volumen, 0, 1);
            this.tlpMagnitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMagnitud.Location = new System.Drawing.Point(3, 16);
            this.tlpMagnitud.Name = "tlpMagnitud";
            this.tlpMagnitud.RowCount = 2;
            this.tlpMagnitud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMagnitud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMagnitud.Size = new System.Drawing.Size(172, 200);
            this.tlpMagnitud.TabIndex = 2;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Area.Location = new System.Drawing.Point(3, 80);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(166, 17);
            this.Area.TabIndex = 0;
            this.Area.TabStop = true;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.CheckedChanged += new System.EventHandler(this.Area_CheckedChanged);
            // 
            // Volumen
            // 
            this.Volumen.AutoSize = true;
            this.Volumen.Location = new System.Drawing.Point(3, 103);
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(66, 17);
            this.Volumen.TabIndex = 1;
            this.Volumen.TabStop = true;
            this.Volumen.Text = "Volumen";
            this.Volumen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlpFigura);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(187, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 219);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figura";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tlpFigura
            // 
            this.tlpFigura.ColumnCount = 1;
            this.tlpFigura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFigura.Controls.Add(this.esfera, 0, 3);
            this.tlpFigura.Controls.Add(this.cubo, 0, 4);
            this.tlpFigura.Controls.Add(this.rectangulo, 0, 1);
            this.tlpFigura.Controls.Add(this.circulo, 0, 2);
            this.tlpFigura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFigura.Location = new System.Drawing.Point(3, 16);
            this.tlpFigura.Name = "tlpFigura";
            this.tlpFigura.RowCount = 7;
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFigura.Size = new System.Drawing.Size(204, 200);
            this.tlpFigura.TabIndex = 0;
            // 
            // esfera
            // 
            this.esfera.AutoSize = true;
            this.esfera.Location = new System.Drawing.Point(3, 103);
            this.esfera.Name = "esfera";
            this.esfera.Size = new System.Drawing.Size(55, 17);
            this.esfera.TabIndex = 0;
            this.esfera.TabStop = true;
            this.esfera.Text = "Esfera";
            this.esfera.UseVisualStyleBackColor = true;
            this.esfera.CheckedChanged += new System.EventHandler(this.esfera_CheckedChanged);
            // 
            // cubo
            // 
            this.cubo.AutoSize = true;
            this.cubo.Location = new System.Drawing.Point(3, 126);
            this.cubo.Name = "cubo";
            this.cubo.Size = new System.Drawing.Size(49, 17);
            this.cubo.TabIndex = 1;
            this.cubo.TabStop = true;
            this.cubo.Text = "cubo";
            this.cubo.UseVisualStyleBackColor = true;
            this.cubo.CheckedChanged += new System.EventHandler(this.cubo_CheckedChanged);
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(3, 57);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(80, 17);
            this.rectangulo.TabIndex = 2;
            this.rectangulo.TabStop = true;
            this.rectangulo.Text = "Rectangulo";
            this.rectangulo.UseVisualStyleBackColor = true;
            this.rectangulo.CheckedChanged += new System.EventHandler(this.rectangulo_CheckedChanged);
            // 
            // circulo
            // 
            this.circulo.AutoSize = true;
            this.circulo.Location = new System.Drawing.Point(3, 80);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(56, 17);
            this.circulo.TabIndex = 3;
            this.circulo.TabStop = true;
            this.circulo.Text = "circulo";
            this.circulo.UseVisualStyleBackColor = true;
            this.circulo.CheckedChanged += new System.EventHandler(this.circulo_CheckedChanged);
            // 
            // BtnCalcular
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BtnCalcular, 2);
            this.BtnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalcular.Location = new System.Drawing.Point(3, 228);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(394, 219);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // limpiar
            // 
            this.limpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limpiar.Location = new System.Drawing.Point(403, 228);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(394, 219);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // medidas
            // 
            this.medidas.Controls.Add(this.tlpMedidas);
            this.medidas.Location = new System.Drawing.Point(403, 3);
            this.medidas.Name = "medidas";
            this.medidas.Size = new System.Drawing.Size(385, 218);
            this.medidas.TabIndex = 6;
            this.medidas.TabStop = false;
            this.medidas.Text = "medidas";
            // 
            // tlpMedidas
            // 
            this.tlpMedidas.ColumnCount = 2;
            this.tlpMedidas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMedidas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMedidas.Controls.Add(this.lblRadio, 0, 1);
            this.tlpMedidas.Controls.Add(this.lblLado, 0, 2);
            this.tlpMedidas.Controls.Add(this.lblAltura, 0, 3);
            this.tlpMedidas.Controls.Add(this.nudRadio, 1, 1);
            this.tlpMedidas.Controls.Add(this.nudLado, 1, 2);
            this.tlpMedidas.Controls.Add(this.nudAltura, 1, 3);
            this.tlpMedidas.Controls.Add(this.button1, 1, 4);
            this.tlpMedidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMedidas.Location = new System.Drawing.Point(3, 16);
            this.tlpMedidas.Name = "tlpMedidas";
            this.tlpMedidas.RowCount = 5;
            this.tlpMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tlpMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tlpMedidas.Size = new System.Drawing.Size(379, 199);
            this.tlpMedidas.TabIndex = 0;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRadio.Location = new System.Drawing.Point(3, 47);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 26);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio: ";
            this.lblRadio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLado.Location = new System.Drawing.Point(3, 73);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(41, 26);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado: ";
            this.lblLado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAltura.Location = new System.Drawing.Point(3, 99);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 26);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRadio
            // 
            this.nudRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRadio.Location = new System.Drawing.Point(50, 50);
            this.nudRadio.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            0});
            this.nudRadio.Name = "nudRadio";
            this.nudRadio.Size = new System.Drawing.Size(326, 20);
            this.nudRadio.TabIndex = 4;
            // 
            // nudLado
            // 
            this.nudLado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLado.Location = new System.Drawing.Point(50, 76);
            this.nudLado.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            0});
            this.nudLado.Name = "nudLado";
            this.nudLado.Size = new System.Drawing.Size(326, 20);
            this.nudLado.TabIndex = 5;
            // 
            // nudAltura
            // 
            this.nudAltura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAltura.Location = new System.Drawing.Point(50, 102);
            this.nudAltura.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(326, 20);
            this.nudAltura.TabIndex = 6;
            this.nudAltura.ValueChanged += new System.EventHandler(this.nudAltura_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tlpMagnitud.ResumeLayout(false);
            this.tlpMagnitud.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tlpFigura.ResumeLayout(false);
            this.tlpFigura.PerformLayout();
            this.medidas.ResumeLayout(false);
            this.tlpMedidas.ResumeLayout(false);
            this.tlpMedidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Area;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Volumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TableLayoutPanel tlpFigura;
        private System.Windows.Forms.RadioButton esfera;
        private System.Windows.Forms.RadioButton cubo;
        private System.Windows.Forms.TableLayoutPanel tlpMagnitud;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox medidas;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.RadioButton circulo;
        private System.Windows.Forms.TableLayoutPanel tlpMedidas;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown nudRadio;
        private System.Windows.Forms.NumericUpDown nudLado;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.Button button1;
    }
}

