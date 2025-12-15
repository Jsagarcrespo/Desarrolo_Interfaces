namespace ejercicio04_factura
{
    partial class Principal
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
            this.bLimpiar = new System.Windows.Forms.Button();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.nudTrabajadores = new System.Windows.Forms.NumericUpDown();
            this.lHoras = new System.Windows.Forms.Label();
            this.lTrabajadores = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tlpMateriales = new System.Windows.Forms.TableLayoutPanel();
            this.cbHierro = new System.Windows.Forms.CheckBox();
            this.cbCobre = new System.Windows.Forms.CheckBox();
            this.cbLaton = new System.Windows.Forms.CheckBox();
            this.nudAluminio = new System.Windows.Forms.NumericUpDown();
            this.nudLaton = new System.Windows.Forms.NumericUpDown();
            this.nudCobre = new System.Windows.Forms.NumericUpDown();
            this.nudHierro = new System.Windows.Forms.NumericUpDown();
            this.cbAluminio = new System.Windows.Forms.CheckBox();
            this.tlpPrincipal.SuspendLayout();
            this.tlpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.tlpMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAluminio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHierro)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.tlpMateriales, 0, 0);
            this.tlpPrincipal.Controls.Add(this.bLimpiar, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpDatos, 0, 0);
            this.tlpPrincipal.Controls.Add(this.bCalcular, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(542, 318);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLimpiar.Location = new System.Drawing.Point(274, 157);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(265, 158);
            this.bLimpiar.TabIndex = 3;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // tlpDatos
            // 
            this.tlpDatos.AutoSize = true;
            this.tlpDatos.ColumnCount = 2;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Controls.Add(this.nudTrabajadores, 1, 2);
            this.tlpDatos.Controls.Add(this.lHoras, 0, 1);
            this.tlpDatos.Controls.Add(this.lTrabajadores, 0, 2);
            this.tlpDatos.Controls.Add(this.nudHoras, 1, 1);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(16, 3);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 4;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatos.Size = new System.Drawing.Size(252, 148);
            this.tlpDatos.TabIndex = 0;
            // 
            // nudTrabajadores
            // 
            this.nudTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTrabajadores.Location = new System.Drawing.Point(154, 77);
            this.nudTrabajadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrabajadores.Name = "nudTrabajadores";
            this.nudTrabajadores.Size = new System.Drawing.Size(95, 26);
            this.nudTrabajadores.TabIndex = 3;
            this.nudTrabajadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Location = new System.Drawing.Point(3, 42);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(96, 20);
            this.lHoras.TabIndex = 0;
            this.lHoras.Text = "Nº de horas:";
            // 
            // lTrabajadores
            // 
            this.lTrabajadores.AutoSize = true;
            this.lTrabajadores.Location = new System.Drawing.Point(3, 74);
            this.lTrabajadores.Name = "lTrabajadores";
            this.lTrabajadores.Size = new System.Drawing.Size(145, 20);
            this.lTrabajadores.TabIndex = 1;
            this.lTrabajadores.Text = "Nº de trabajadores:";
            // 
            // nudHoras
            // 
            this.nudHoras.DecimalPlaces = 2;
            this.nudHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHoras.Location = new System.Drawing.Point(154, 45);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(95, 26);
            this.nudHoras.TabIndex = 2;
            // 
            // bCalcular
            // 
            this.bCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCalcular.Location = new System.Drawing.Point(3, 157);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(265, 158);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tlpMateriales
            // 
            this.tlpMateriales.AutoSize = true;
            this.tlpMateriales.ColumnCount = 3;
            this.tlpMateriales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMateriales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMateriales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMateriales.Controls.Add(this.cbHierro, 1, 3);
            this.tlpMateriales.Controls.Add(this.cbCobre, 1, 4);
            this.tlpMateriales.Controls.Add(this.cbLaton, 1, 5);
            this.tlpMateriales.Controls.Add(this.nudAluminio, 2, 2);
            this.tlpMateriales.Controls.Add(this.nudLaton, 2, 5);
            this.tlpMateriales.Controls.Add(this.nudCobre, 2, 4);
            this.tlpMateriales.Controls.Add(this.nudHierro, 2, 3);
            this.tlpMateriales.Controls.Add(this.cbAluminio, 1, 2);
            this.tlpMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMateriales.Location = new System.Drawing.Point(274, 3);
            this.tlpMateriales.Name = "tlpMateriales";
            this.tlpMateriales.RowCount = 7;
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateriales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateriales.Size = new System.Drawing.Size(265, 148);
            this.tlpMateriales.TabIndex = 4;
            // 
            // cbHierro
            // 
            this.cbHierro.AutoSize = true;
            this.cbHierro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHierro.Location = new System.Drawing.Point(23, 55);
            this.cbHierro.Name = "cbHierro";
            this.cbHierro.Size = new System.Drawing.Size(95, 26);
            this.cbHierro.TabIndex = 9;
            this.cbHierro.Text = "Hierro";
            this.cbHierro.UseVisualStyleBackColor = true;
            // 
            // cbCobre
            // 
            this.cbCobre.AutoSize = true;
            this.cbCobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCobre.Location = new System.Drawing.Point(23, 87);
            this.cbCobre.Name = "cbCobre";
            this.cbCobre.Size = new System.Drawing.Size(95, 26);
            this.cbCobre.TabIndex = 8;
            this.cbCobre.Text = "Cobre";
            this.cbCobre.UseVisualStyleBackColor = true;
            // 
            // cbLaton
            // 
            this.cbLaton.AutoSize = true;
            this.cbLaton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLaton.Location = new System.Drawing.Point(23, 119);
            this.cbLaton.Name = "cbLaton";
            this.cbLaton.Size = new System.Drawing.Size(95, 26);
            this.cbLaton.TabIndex = 7;
            this.cbLaton.Text = "Latón";
            this.cbLaton.UseVisualStyleBackColor = true;
            // 
            // nudAluminio
            // 
            this.nudAluminio.DecimalPlaces = 2;
            this.nudAluminio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAluminio.Location = new System.Drawing.Point(124, 23);
            this.nudAluminio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAluminio.Name = "nudAluminio";
            this.nudAluminio.Size = new System.Drawing.Size(138, 26);
            this.nudAluminio.TabIndex = 5;
            this.nudAluminio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAluminio.Visible = false;
            // 
            // nudLaton
            // 
            this.nudLaton.DecimalPlaces = 2;
            this.nudLaton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLaton.Location = new System.Drawing.Point(124, 119);
            this.nudLaton.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLaton.Name = "nudLaton";
            this.nudLaton.Size = new System.Drawing.Size(138, 26);
            this.nudLaton.TabIndex = 4;
            this.nudLaton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLaton.Visible = false;
            // 
            // nudCobre
            // 
            this.nudCobre.DecimalPlaces = 2;
            this.nudCobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCobre.Location = new System.Drawing.Point(124, 87);
            this.nudCobre.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCobre.Name = "nudCobre";
            this.nudCobre.Size = new System.Drawing.Size(138, 26);
            this.nudCobre.TabIndex = 3;
            this.nudCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCobre.Visible = false;
            // 
            // nudHierro
            // 
            this.nudHierro.DecimalPlaces = 2;
            this.nudHierro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHierro.Location = new System.Drawing.Point(124, 55);
            this.nudHierro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHierro.Name = "nudHierro";
            this.nudHierro.Size = new System.Drawing.Size(138, 26);
            this.nudHierro.TabIndex = 2;
            this.nudHierro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHierro.Visible = false;
            // 
            // cbAluminio
            // 
            this.cbAluminio.AutoSize = true;
            this.cbAluminio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAluminio.Location = new System.Drawing.Point(23, 23);
            this.cbAluminio.Name = "cbAluminio";
            this.cbAluminio.Size = new System.Drawing.Size(95, 26);
            this.cbAluminio.TabIndex = 6;
            this.cbAluminio.Text = "Aluminio";
            this.cbAluminio.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 318);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "Principal";
            this.Text = "Calculador Factura";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.tlpMateriales.ResumeLayout(false);
            this.tlpMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAluminio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHierro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.NumericUpDown nudTrabajadores;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lTrabajadores;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TableLayoutPanel tlpMateriales;
        private System.Windows.Forms.CheckBox cbHierro;
        private System.Windows.Forms.CheckBox cbCobre;
        private System.Windows.Forms.CheckBox cbLaton;
        private System.Windows.Forms.NumericUpDown nudAluminio;
        private System.Windows.Forms.NumericUpDown nudLaton;
        private System.Windows.Forms.NumericUpDown nudCobre;
        private System.Windows.Forms.NumericUpDown nudHierro;
        private System.Windows.Forms.CheckBox cbAluminio;
    }
}

