namespace AyVcheckSender
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
            this.GBFigura = new System.Windows.Forms.TableLayoutPanel();
            this.GBMedidas = new System.Windows.Forms.GroupBox();
            this.TBMedidas = new System.Windows.Forms.TableLayoutPanel();
            this.Lradio = new System.Windows.Forms.Label();
            this.Llado = new System.Windows.Forms.Label();
            this.Lalt = new System.Windows.Forms.Label();
            this.Nlado = new System.Windows.Forms.NumericUpDown();
            this.Nalt = new System.Windows.Forms.NumericUpDown();
            this.Nradio = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GBMagnitud = new System.Windows.Forms.GroupBox();
            this.TBMagnitud = new System.Windows.Forms.TableLayoutPanel();
            this.RBArea = new System.Windows.Forms.RadioButton();
            this.RBVolumen = new System.Windows.Forms.RadioButton();
            this.groupFigura = new System.Windows.Forms.GroupBox();
            this.TBFigura = new System.Windows.Forms.TableLayoutPanel();
            this.RBRectangulo = new System.Windows.Forms.RadioButton();
            this.RBCirculo = new System.Windows.Forms.RadioButton();
            this.RBEsfera = new System.Windows.Forms.RadioButton();
            this.RBCubo = new System.Windows.Forms.RadioButton();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTCalcular = new System.Windows.Forms.Button();
            this.GBFigura.SuspendLayout();
            this.GBMedidas.SuspendLayout();
            this.TBMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nlado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nradio)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.GBMagnitud.SuspendLayout();
            this.TBMagnitud.SuspendLayout();
            this.groupFigura.SuspendLayout();
            this.TBFigura.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBFigura
            // 
            this.GBFigura.ColumnCount = 2;
            this.GBFigura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GBFigura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GBFigura.Controls.Add(this.GBMedidas, 1, 0);
            this.GBFigura.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.GBFigura.Controls.Add(this.BTLimpiar, 1, 1);
            this.GBFigura.Controls.Add(this.BTCalcular, 0, 1);
            this.GBFigura.Location = new System.Drawing.Point(2, 2);
            this.GBFigura.Name = "GBFigura";
            this.GBFigura.RowCount = 2;
            this.GBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GBFigura.Size = new System.Drawing.Size(796, 446);
            this.GBFigura.TabIndex = 1;
            // 
            // GBMedidas
            // 
            this.GBMedidas.Controls.Add(this.TBMedidas);
            this.GBMedidas.Location = new System.Drawing.Point(401, 3);
            this.GBMedidas.Name = "GBMedidas";
            this.GBMedidas.Size = new System.Drawing.Size(392, 217);
            this.GBMedidas.TabIndex = 4;
            this.GBMedidas.TabStop = false;
            this.GBMedidas.Text = "Medidas";
            // 
            // TBMedidas
            // 
            this.TBMedidas.ColumnCount = 2;
            this.TBMedidas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBMedidas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBMedidas.Controls.Add(this.Lradio, 0, 1);
            this.TBMedidas.Controls.Add(this.Llado, 0, 2);
            this.TBMedidas.Controls.Add(this.Lalt, 0, 3);
            this.TBMedidas.Controls.Add(this.Nlado, 1, 2);
            this.TBMedidas.Controls.Add(this.Nalt, 1, 3);
            this.TBMedidas.Controls.Add(this.Nradio, 1, 1);
            this.TBMedidas.Location = new System.Drawing.Point(6, 25);
            this.TBMedidas.Name = "TBMedidas";
            this.TBMedidas.RowCount = 5;
            this.TBMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.70086F));
            this.TBMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBMedidas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29914F));
            this.TBMedidas.Size = new System.Drawing.Size(376, 183);
            this.TBMedidas.TabIndex = 0;
            // 
            // Lradio
            // 
            this.Lradio.AutoSize = true;
            this.Lradio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lradio.Location = new System.Drawing.Point(3, 57);
            this.Lradio.Name = "Lradio";
            this.Lradio.Size = new System.Drawing.Size(38, 26);
            this.Lradio.TabIndex = 0;
            this.Lradio.Text = "Radio:";
            this.Lradio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Llado
            // 
            this.Llado.AutoSize = true;
            this.Llado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Llado.Location = new System.Drawing.Point(3, 83);
            this.Llado.Name = "Llado";
            this.Llado.Size = new System.Drawing.Size(38, 26);
            this.Llado.TabIndex = 1;
            this.Llado.Text = "Lado:";
            this.Llado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lalt
            // 
            this.Lalt.AutoSize = true;
            this.Lalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lalt.Location = new System.Drawing.Point(3, 109);
            this.Lalt.Name = "Lalt";
            this.Lalt.Size = new System.Drawing.Size(38, 26);
            this.Lalt.TabIndex = 2;
            this.Lalt.Text = "Altura:";
            this.Lalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nlado
            // 
            this.Nlado.Location = new System.Drawing.Point(47, 86);
            this.Nlado.Name = "Nlado";
            this.Nlado.Size = new System.Drawing.Size(326, 20);
            this.Nlado.TabIndex = 4;
            // 
            // Nalt
            // 
            this.Nalt.Location = new System.Drawing.Point(47, 112);
            this.Nalt.Name = "Nalt";
            this.Nalt.Size = new System.Drawing.Size(326, 20);
            this.Nalt.TabIndex = 5;
            // 
            // Nradio
            // 
            this.Nradio.Location = new System.Drawing.Point(47, 60);
            this.Nradio.Name = "Nradio";
            this.Nradio.Size = new System.Drawing.Size(326, 20);
            this.Nradio.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.GBMagnitud, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupFigura, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(392, 217);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GBMagnitud
            // 
            this.GBMagnitud.Controls.Add(this.TBMagnitud);
            this.GBMagnitud.Location = new System.Drawing.Point(3, 3);
            this.GBMagnitud.Name = "GBMagnitud";
            this.GBMagnitud.Size = new System.Drawing.Size(190, 211);
            this.GBMagnitud.TabIndex = 0;
            this.GBMagnitud.TabStop = false;
            this.GBMagnitud.Text = "Magnitud";
            // 
            // TBMagnitud
            // 
            this.TBMagnitud.ColumnCount = 1;
            this.TBMagnitud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBMagnitud.Controls.Add(this.RBArea, 0, 0);
            this.TBMagnitud.Controls.Add(this.RBVolumen, 0, 1);
            this.TBMagnitud.Location = new System.Drawing.Point(6, 19);
            this.TBMagnitud.Name = "TBMagnitud";
            this.TBMagnitud.RowCount = 2;
            this.TBMagnitud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBMagnitud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBMagnitud.Size = new System.Drawing.Size(178, 186);
            this.TBMagnitud.TabIndex = 0;
            // 
            // RBArea
            // 
            this.RBArea.AutoSize = true;
            this.RBArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RBArea.Location = new System.Drawing.Point(3, 73);
            this.RBArea.Name = "RBArea";
            this.RBArea.Size = new System.Drawing.Size(172, 17);
            this.RBArea.TabIndex = 0;
            this.RBArea.TabStop = true;
            this.RBArea.Text = "Area";
            this.RBArea.UseVisualStyleBackColor = true;
            this.RBArea.CheckedChanged += new System.EventHandler(this.RBArea_CheckedChanged);
            // 
            // RBVolumen
            // 
            this.RBVolumen.AutoSize = true;
            this.RBVolumen.Location = new System.Drawing.Point(3, 96);
            this.RBVolumen.Name = "RBVolumen";
            this.RBVolumen.Size = new System.Drawing.Size(66, 17);
            this.RBVolumen.TabIndex = 1;
            this.RBVolumen.TabStop = true;
            this.RBVolumen.Text = "Volumen";
            this.RBVolumen.UseVisualStyleBackColor = true;
            this.RBVolumen.CheckedChanged += new System.EventHandler(this.RBVolumen_CheckedChanged);
            // 
            // groupFigura
            // 
            this.groupFigura.Controls.Add(this.TBFigura);
            this.groupFigura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFigura.Location = new System.Drawing.Point(199, 3);
            this.groupFigura.Name = "groupFigura";
            this.groupFigura.Size = new System.Drawing.Size(190, 211);
            this.groupFigura.TabIndex = 1;
            this.groupFigura.TabStop = false;
            this.groupFigura.Text = "Figura";
            // 
            // TBFigura
            // 
            this.TBFigura.ColumnCount = 1;
            this.TBFigura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBFigura.Controls.Add(this.RBRectangulo, 0, 1);
            this.TBFigura.Controls.Add(this.RBCirculo, 0, 2);
            this.TBFigura.Controls.Add(this.RBEsfera, 0, 3);
            this.TBFigura.Controls.Add(this.RBCubo, 0, 4);
            this.TBFigura.Location = new System.Drawing.Point(6, 19);
            this.TBFigura.Name = "TBFigura";
            this.TBFigura.RowCount = 6;
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBFigura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBFigura.Size = new System.Drawing.Size(178, 186);
            this.TBFigura.TabIndex = 0;
            // 
            // RBRectangulo
            // 
            this.RBRectangulo.AutoSize = true;
            this.RBRectangulo.Location = new System.Drawing.Point(3, 50);
            this.RBRectangulo.Name = "RBRectangulo";
            this.RBRectangulo.Size = new System.Drawing.Size(80, 17);
            this.RBRectangulo.TabIndex = 0;
            this.RBRectangulo.TabStop = true;
            this.RBRectangulo.Text = "Rectangulo";
            this.RBRectangulo.UseVisualStyleBackColor = true;
            this.RBRectangulo.CheckedChanged += new System.EventHandler(this.RBRectangulo_CheckedChanged);
            // 
            // RBCirculo
            // 
            this.RBCirculo.AutoSize = true;
            this.RBCirculo.Location = new System.Drawing.Point(3, 73);
            this.RBCirculo.Name = "RBCirculo";
            this.RBCirculo.Size = new System.Drawing.Size(57, 17);
            this.RBCirculo.TabIndex = 1;
            this.RBCirculo.TabStop = true;
            this.RBCirculo.Text = "Circulo";
            this.RBCirculo.UseVisualStyleBackColor = true;
            this.RBCirculo.CheckedChanged += new System.EventHandler(this.RBCirculo_CheckedChanged);
            // 
            // RBEsfera
            // 
            this.RBEsfera.AutoSize = true;
            this.RBEsfera.Location = new System.Drawing.Point(3, 96);
            this.RBEsfera.Name = "RBEsfera";
            this.RBEsfera.Size = new System.Drawing.Size(55, 17);
            this.RBEsfera.TabIndex = 2;
            this.RBEsfera.TabStop = true;
            this.RBEsfera.Text = "Esfera";
            this.RBEsfera.UseVisualStyleBackColor = true;
            this.RBEsfera.CheckedChanged += new System.EventHandler(this.RBEsfera_CheckedChanged);
            // 
            // RBCubo
            // 
            this.RBCubo.AutoSize = true;
            this.RBCubo.Location = new System.Drawing.Point(3, 119);
            this.RBCubo.Name = "RBCubo";
            this.RBCubo.Size = new System.Drawing.Size(50, 17);
            this.RBCubo.TabIndex = 3;
            this.RBCubo.TabStop = true;
            this.RBCubo.Text = "Cubo";
            this.RBCubo.UseVisualStyleBackColor = true;
            this.RBCubo.CheckedChanged += new System.EventHandler(this.RBCubo_CheckedChanged);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTLimpiar.Location = new System.Drawing.Point(401, 226);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(392, 217);
            this.BTLimpiar.TabIndex = 2;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTCalcular
            // 
            this.BTCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTCalcular.Location = new System.Drawing.Point(3, 226);
            this.BTCalcular.Name = "BTCalcular";
            this.BTCalcular.Size = new System.Drawing.Size(392, 217);
            this.BTCalcular.TabIndex = 5;
            this.BTCalcular.Text = "Calcular";
            this.BTCalcular.UseVisualStyleBackColor = true;
            this.BTCalcular.Click += new System.EventHandler(this.BTCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBFigura.ResumeLayout(false);
            this.GBMedidas.ResumeLayout(false);
            this.TBMedidas.ResumeLayout(false);
            this.TBMedidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nlado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nradio)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GBMagnitud.ResumeLayout(false);
            this.TBMagnitud.ResumeLayout(false);
            this.TBMagnitud.PerformLayout();
            this.groupFigura.ResumeLayout(false);
            this.TBFigura.ResumeLayout(false);
            this.TBFigura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GBFigura;
        private System.Windows.Forms.GroupBox GBMedidas;
        private System.Windows.Forms.TableLayoutPanel TBMedidas;
        private System.Windows.Forms.Label Lradio;
        private System.Windows.Forms.Label Llado;
        private System.Windows.Forms.Label Lalt;
        private System.Windows.Forms.NumericUpDown Nlado;
        private System.Windows.Forms.NumericUpDown Nalt;
        private System.Windows.Forms.NumericUpDown Nradio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GBMagnitud;
        private System.Windows.Forms.TableLayoutPanel TBMagnitud;
        private System.Windows.Forms.RadioButton RBArea;
        private System.Windows.Forms.RadioButton RBVolumen;
        private System.Windows.Forms.GroupBox groupFigura;
        private System.Windows.Forms.TableLayoutPanel TBFigura;
        private System.Windows.Forms.RadioButton RBRectangulo;
        private System.Windows.Forms.RadioButton RBCirculo;
        private System.Windows.Forms.RadioButton RBEsfera;
        private System.Windows.Forms.RadioButton RBCubo;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTCalcular;
    }
}

