namespace Ejercicio2
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            gMedida = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            labelLado = new Label();
            labelAltura = new Label();
            labelRadio = new Label();
            numLado = new NumericUpDown();
            numAltura = new NumericUpDown();
            numRadio = new NumericUpDown();
            bLimpiar = new Button();
            bCalcular = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            gMagnitud = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            rArea = new RadioButton();
            rVolumen = new RadioButton();
            gFigura = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            rRectangulo = new RadioButton();
            rCirculo = new RadioButton();
            rEsfera = new RadioButton();
            rCubo = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gMedida.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRadio).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            gMagnitud.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            gFigura.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(bLimpiar, 1, 1);
            tableLayoutPanel1.Controls.Add(bCalcular, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(674, 311);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(gMedida, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(340, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(331, 182);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // gMedida
            // 
            gMedida.Controls.Add(tableLayoutPanel6);
            gMedida.Dock = DockStyle.Fill;
            gMedida.Location = new Point(3, 2);
            gMedida.Margin = new Padding(3, 2, 3, 2);
            gMedida.Name = "gMedida";
            gMedida.Padding = new Padding(3, 2, 3, 2);
            gMedida.Size = new Size(325, 178);
            gMedida.TabIndex = 0;
            gMedida.TabStop = false;
            gMedida.Text = "Medida";
            gMedida.Enter += gMedida_Enter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(labelLado, 0, 1);
            tableLayoutPanel6.Controls.Add(labelAltura, 0, 2);
            tableLayoutPanel6.Controls.Add(labelRadio, 0, 3);
            tableLayoutPanel6.Controls.Add(numLado, 1, 1);
            tableLayoutPanel6.Controls.Add(numAltura, 1, 2);
            tableLayoutPanel6.Controls.Add(numRadio, 1, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 18);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44445F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555534F));
            tableLayoutPanel6.Size = new Size(319, 158);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.Dock = DockStyle.Fill;
            labelLado.Location = new Point(3, 34);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(39, 27);
            labelLado.TabIndex = 0;
            labelLado.Text = "Lado";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Dock = DockStyle.Fill;
            labelAltura.Location = new Point(3, 61);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(39, 27);
            labelAltura.TabIndex = 1;
            labelAltura.Text = "Altura";
            // 
            // labelRadio
            // 
            labelRadio.AutoSize = true;
            labelRadio.Dock = DockStyle.Fill;
            labelRadio.Location = new Point(3, 88);
            labelRadio.Name = "labelRadio";
            labelRadio.Size = new Size(39, 27);
            labelRadio.TabIndex = 2;
            labelRadio.Text = "Radio";
            // 
            // numLado
            // 
            numLado.Dock = DockStyle.Fill;
            numLado.Location = new Point(48, 36);
            numLado.Margin = new Padding(3, 2, 3, 2);
            numLado.Name = "numLado";
            numLado.Size = new Size(268, 23);
            numLado.TabIndex = 3;
            // 
            // numAltura
            // 
            numAltura.Dock = DockStyle.Fill;
            numAltura.Location = new Point(48, 63);
            numAltura.Margin = new Padding(3, 2, 3, 2);
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(268, 23);
            numAltura.TabIndex = 4;
            // 
            // numRadio
            // 
            numRadio.Dock = DockStyle.Fill;
            numRadio.Location = new Point(48, 90);
            numRadio.Margin = new Padding(3, 2, 3, 2);
            numRadio.Name = "numRadio";
            numRadio.Size = new Size(268, 23);
            numRadio.TabIndex = 5;
            // 
            // bLimpiar
            // 
            bLimpiar.Dock = DockStyle.Fill;
            bLimpiar.Font = new Font("Segoe UI", 14F);
            bLimpiar.Location = new Point(340, 188);
            bLimpiar.Margin = new Padding(3, 2, 3, 2);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(331, 121);
            bLimpiar.TabIndex = 3;
            bLimpiar.Text = "Limpiar";
            bLimpiar.UseVisualStyleBackColor = true;
            bLimpiar.Click += bLimpiar_Click;
            // 
            // bCalcular
            // 
            bCalcular.Dock = DockStyle.Fill;
            bCalcular.Font = new Font("Segoe UI", 14F);
            bCalcular.Location = new Point(3, 188);
            bCalcular.Margin = new Padding(3, 2, 3, 2);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(331, 121);
            bCalcular.TabIndex = 2;
            bCalcular.Text = "Calcular";
            bCalcular.UseVisualStyleBackColor = true;
            bCalcular.Click += bCalcular_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(gMagnitud, 0, 0);
            tableLayoutPanel2.Controls.Add(gFigura, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(331, 182);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // gMagnitud
            // 
            gMagnitud.Controls.Add(tableLayoutPanel4);
            gMagnitud.Dock = DockStyle.Fill;
            gMagnitud.Location = new Point(3, 2);
            gMagnitud.Margin = new Padding(3, 2, 3, 2);
            gMagnitud.Name = "gMagnitud";
            gMagnitud.Padding = new Padding(3, 2, 3, 2);
            gMagnitud.Size = new Size(159, 178);
            gMagnitud.TabIndex = 0;
            gMagnitud.TabStop = false;
            gMagnitud.Text = "Magnitud";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(rArea, 0, 0);
            tableLayoutPanel4.Controls.Add(rVolumen, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 18);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(153, 158);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // rArea
            // 
            rArea.AutoSize = true;
            rArea.Checked = true;
            rArea.Dock = DockStyle.Bottom;
            rArea.Location = new Point(3, 58);
            rArea.Margin = new Padding(3, 2, 3, 2);
            rArea.Name = "rArea";
            rArea.Size = new Size(147, 19);
            rArea.TabIndex = 0;
            rArea.TabStop = true;
            rArea.Text = "Area";
            rArea.UseVisualStyleBackColor = true;
            rArea.CheckedChanged += rArea_CheckedChanged;
            // 
            // rVolumen
            // 
            rVolumen.AutoSize = true;
            rVolumen.Dock = DockStyle.Top;
            rVolumen.Location = new Point(3, 81);
            rVolumen.Margin = new Padding(3, 2, 3, 2);
            rVolumen.Name = "rVolumen";
            rVolumen.Size = new Size(147, 19);
            rVolumen.TabIndex = 1;
            rVolumen.Text = "Volumen";
            rVolumen.UseVisualStyleBackColor = true;
            rVolumen.CheckedChanged += rVolumen_CheckedChanged;
            // 
            // gFigura
            // 
            gFigura.Controls.Add(tableLayoutPanel5);
            gFigura.Dock = DockStyle.Fill;
            gFigura.Location = new Point(168, 2);
            gFigura.Margin = new Padding(3, 2, 3, 2);
            gFigura.Name = "gFigura";
            gFigura.Padding = new Padding(3, 2, 3, 2);
            gFigura.Size = new Size(160, 178);
            gFigura.TabIndex = 1;
            gFigura.TabStop = false;
            gFigura.Text = "Figura";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(rRectangulo, 0, 1);
            tableLayoutPanel5.Controls.Add(rCirculo, 0, 2);
            tableLayoutPanel5.Controls.Add(rEsfera, 0, 3);
            tableLayoutPanel5.Controls.Add(rCubo, 0, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 18);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel5.Size = new Size(154, 158);
            tableLayoutPanel5.TabIndex = 1;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // rRectangulo
            // 
            rRectangulo.AutoSize = true;
            rRectangulo.Location = new Point(3, 35);
            rRectangulo.Margin = new Padding(3, 2, 3, 2);
            rRectangulo.Name = "rRectangulo";
            rRectangulo.Size = new Size(85, 19);
            rRectangulo.TabIndex = 0;
            rRectangulo.TabStop = true;
            rRectangulo.Text = "Rectangulo";
            rRectangulo.UseVisualStyleBackColor = true;
            rRectangulo.CheckedChanged += rRectangulo_CheckedChanged;
            // 
            // rCirculo
            // 
            rCirculo.AutoSize = true;
            rCirculo.Location = new Point(3, 58);
            rCirculo.Margin = new Padding(3, 2, 3, 2);
            rCirculo.Name = "rCirculo";
            rCirculo.Size = new Size(63, 19);
            rCirculo.TabIndex = 1;
            rCirculo.TabStop = true;
            rCirculo.Text = "Circulo";
            rCirculo.UseVisualStyleBackColor = true;
            rCirculo.CheckedChanged += rCirculo_CheckedChanged;
            // 
            // rEsfera
            // 
            rEsfera.AutoSize = true;
            rEsfera.Location = new Point(3, 81);
            rEsfera.Margin = new Padding(3, 2, 3, 2);
            rEsfera.Name = "rEsfera";
            rEsfera.Size = new Size(56, 19);
            rEsfera.TabIndex = 2;
            rEsfera.TabStop = true;
            rEsfera.Text = "Esfera";
            rEsfera.UseVisualStyleBackColor = true;
            rEsfera.CheckedChanged += rEsfera_CheckedChanged;
            // 
            // rCubo
            // 
            rCubo.AutoSize = true;
            rCubo.Location = new Point(3, 104);
            rCubo.Margin = new Padding(3, 2, 3, 2);
            rCubo.Name = "rCubo";
            rCubo.Size = new Size(54, 19);
            rCubo.TabIndex = 3;
            rCubo.TabStop = true;
            rCubo.Text = "Cubo";
            rCubo.UseVisualStyleBackColor = true;
            rCubo.CheckedChanged += rCubo_CheckedChanged;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 311);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            Text = "Area y Volumen";
            Load += Principal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            gMedida.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRadio).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            gMagnitud.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            gFigura.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button bLimpiar;
        private Button bCalcular;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox gMedida;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gMagnitud;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox gFigura;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton rArea;
        private RadioButton rVolumen;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton rRectangulo;
        private RadioButton rCirculo;
        private RadioButton rEsfera;
        private RadioButton rCubo;
        private Label labelLado;
        private Label labelAltura;
        private Label labelRadio;
        private NumericUpDown numLado;
        private NumericUpDown numAltura;
        private NumericUpDown numRadio;
    }
}
