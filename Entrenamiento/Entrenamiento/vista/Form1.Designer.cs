namespace Entrenamiento
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPart = new System.Windows.Forms.NumericUpDown();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.gbActividad = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkCardio = new System.Windows.Forms.CheckBox();
            this.chkPesas = new System.Windows.Forms.CheckBox();
            this.chkEstiramiento = new System.Windows.Forms.CheckBox();
            this.chkHiit = new System.Windows.Forms.CheckBox();
            this.nudCardio = new System.Windows.Forms.NumericUpDown();
            this.nudPesas = new System.Windows.Forms.NumericUpDown();
            this.nudEstiramiento = new System.Windows.Forms.NumericUpDown();
            this.nudHiit = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPart)).BeginInit();
            this.gbActividad.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstiramiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bLimpiar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bCalcular, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbActividad, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLimpiar.Location = new System.Drawing.Point(3, 190);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(191, 64);
            this.bLimpiar.TabIndex = 0;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCalcular
            // 
            this.bCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCalcular.Location = new System.Drawing.Point(200, 190);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(191, 64);
            this.bCalcular.TabIndex = 1;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudPart, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbFecha, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Participantes: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPart
            // 
            this.nudPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPart.Location = new System.Drawing.Point(98, 29);
            this.nudPart.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPart.Name = "nudPart";
            this.nudPart.Size = new System.Drawing.Size(90, 20);
            this.nudPart.TabIndex = 2;
            this.nudPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbFecha
            // 
            this.tbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFecha.Location = new System.Drawing.Point(98, 3);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(90, 20);
            this.tbFecha.TabIndex = 3;
            // 
            // gbActividad
            // 
            this.gbActividad.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.gbActividad, 2);
            this.gbActividad.Controls.Add(this.tableLayoutPanel3);
            this.gbActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActividad.Location = new System.Drawing.Point(3, 61);
            this.gbActividad.Name = "gbActividad";
            this.gbActividad.Size = new System.Drawing.Size(388, 123);
            this.gbActividad.TabIndex = 3;
            this.gbActividad.TabStop = false;
            this.gbActividad.Text = "Actividades";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.chkCardio, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkPesas, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkEstiramiento, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkHiit, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.nudCardio, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudPesas, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.nudEstiramiento, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.nudHiit, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 104);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // chkCardio
            // 
            this.chkCardio.AutoSize = true;
            this.chkCardio.Location = new System.Drawing.Point(28, 3);
            this.chkCardio.Name = "chkCardio";
            this.chkCardio.Size = new System.Drawing.Size(56, 17);
            this.chkCardio.TabIndex = 0;
            this.chkCardio.Text = "Cardio";
            this.chkCardio.UseVisualStyleBackColor = true;
            this.chkCardio.CheckedChanged += new System.EventHandler(this.chkCardio_CheckedChanged);
            // 
            // chkPesas
            // 
            this.chkPesas.AutoSize = true;
            this.chkPesas.Location = new System.Drawing.Point(28, 29);
            this.chkPesas.Name = "chkPesas";
            this.chkPesas.Size = new System.Drawing.Size(55, 17);
            this.chkPesas.TabIndex = 1;
            this.chkPesas.Text = "Pesas";
            this.chkPesas.UseVisualStyleBackColor = true;
            this.chkPesas.CheckedChanged += new System.EventHandler(this.chkPesas_CheckedChanged);
            // 
            // chkEstiramiento
            // 
            this.chkEstiramiento.AutoSize = true;
            this.chkEstiramiento.Location = new System.Drawing.Point(28, 55);
            this.chkEstiramiento.Name = "chkEstiramiento";
            this.chkEstiramiento.Size = new System.Drawing.Size(88, 17);
            this.chkEstiramiento.TabIndex = 2;
            this.chkEstiramiento.Text = "Estiramientos";
            this.chkEstiramiento.UseVisualStyleBackColor = true;
            this.chkEstiramiento.CheckedChanged += new System.EventHandler(this.chkEstiramiento_CheckedChanged);
            // 
            // chkHiit
            // 
            this.chkHiit.AutoSize = true;
            this.chkHiit.Location = new System.Drawing.Point(28, 81);
            this.chkHiit.Name = "chkHiit";
            this.chkHiit.Size = new System.Drawing.Size(47, 17);
            this.chkHiit.TabIndex = 3;
            this.chkHiit.Text = "HIIT";
            this.chkHiit.UseVisualStyleBackColor = true;
            this.chkHiit.CheckedChanged += new System.EventHandler(this.chkHiit_CheckedChanged);
            // 
            // nudCardio
            // 
            this.nudCardio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCardio.Location = new System.Drawing.Point(122, 3);
            this.nudCardio.Name = "nudCardio";
            this.nudCardio.Size = new System.Drawing.Size(257, 20);
            this.nudCardio.TabIndex = 4;
            // 
            // nudPesas
            // 
            this.nudPesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPesas.Location = new System.Drawing.Point(122, 29);
            this.nudPesas.Name = "nudPesas";
            this.nudPesas.Size = new System.Drawing.Size(257, 20);
            this.nudPesas.TabIndex = 5;
            // 
            // nudEstiramiento
            // 
            this.nudEstiramiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEstiramiento.Location = new System.Drawing.Point(122, 55);
            this.nudEstiramiento.Name = "nudEstiramiento";
            this.nudEstiramiento.Size = new System.Drawing.Size(257, 20);
            this.nudEstiramiento.TabIndex = 6;
            // 
            // nudHiit
            // 
            this.nudHiit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHiit.Location = new System.Drawing.Point(122, 81);
            this.nudHiit.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.nudHiit.Name = "nudHiit";
            this.nudHiit.Size = new System.Drawing.Size(257, 20);
            this.nudHiit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPart)).EndInit();
            this.gbActividad.ResumeLayout(false);
            this.gbActividad.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstiramiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPart;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.GroupBox gbActividad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chkCardio;
        private System.Windows.Forms.CheckBox chkPesas;
        private System.Windows.Forms.CheckBox chkEstiramiento;
        private System.Windows.Forms.CheckBox chkHiit;
        private System.Windows.Forms.NumericUpDown nudCardio;
        private System.Windows.Forms.NumericUpDown nudPesas;
        private System.Windows.Forms.NumericUpDown nudHiit;
        private System.Windows.Forms.NumericUpDown nudEstiramiento;
    }
}

