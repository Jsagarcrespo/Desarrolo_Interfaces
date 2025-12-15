namespace factura
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
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblNumHT = new System.Windows.Forms.TableLayoutPanel();
            this.lHoras = new System.Windows.Forms.Label();
            this.lTrabajadores = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.numTrabajadores = new System.Windows.Forms.NumericUpDown();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.tblMaterial = new System.Windows.Forms.TableLayoutPanel();
            this.chkAlumnio = new System.Windows.Forms.CheckBox();
            this.chkCobre = new System.Windows.Forms.CheckBox();
            this.chkLaton = new System.Windows.Forms.CheckBox();
            this.chkHierro = new System.Windows.Forms.CheckBox();
            this.numAlu = new System.Windows.Forms.NumericUpDown();
            this.numHierro = new System.Windows.Forms.NumericUpDown();
            this.numCobre = new System.Windows.Forms.NumericUpDown();
            this.numLaton = new System.Windows.Forms.NumericUpDown();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.tblPrincipal.SuspendLayout();
            this.tblNumHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajadores)).BeginInit();
            this.gbMaterial.SuspendLayout();
            this.tblMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHierro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaton)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 2;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.Controls.Add(this.tblNumHT, 0, 0);
            this.tblPrincipal.Controls.Add(this.gbMaterial, 1, 0);
            this.tblPrincipal.Controls.Add(this.bCalcular, 0, 1);
            this.tblPrincipal.Controls.Add(this.bLimpiar, 1, 1);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Size = new System.Drawing.Size(446, 210);
            this.tblPrincipal.TabIndex = 0;
            // 
            // tblNumHT
            // 
            this.tblNumHT.AutoSize = true;
            this.tblNumHT.ColumnCount = 2;
            this.tblNumHT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblNumHT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNumHT.Controls.Add(this.lHoras, 0, 1);
            this.tblNumHT.Controls.Add(this.lTrabajadores, 0, 2);
            this.tblNumHT.Controls.Add(this.numHoras, 1, 1);
            this.tblNumHT.Controls.Add(this.numTrabajadores, 1, 2);
            this.tblNumHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNumHT.Location = new System.Drawing.Point(7, 7);
            this.tblNumHT.Margin = new System.Windows.Forms.Padding(2);
            this.tblNumHT.Name = "tblNumHT";
            this.tblNumHT.Padding = new System.Windows.Forms.Padding(5);
            this.tblNumHT.RowCount = 4;
            this.tblNumHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.25641F));
            this.tblNumHT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNumHT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNumHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.74359F));
            this.tblNumHT.Size = new System.Drawing.Size(214, 143);
            this.tblNumHT.TabIndex = 0;
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Dock = System.Windows.Forms.DockStyle.Left;
            this.lHoras.Location = new System.Drawing.Point(7, 47);
            this.lHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(56, 24);
            this.lHoras.TabIndex = 0;
            this.lHoras.Text = "Nº Horas: ";
            this.lHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTrabajadores
            // 
            this.lTrabajadores.AutoSize = true;
            this.lTrabajadores.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTrabajadores.Location = new System.Drawing.Point(7, 71);
            this.lTrabajadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTrabajadores.Name = "lTrabajadores";
            this.lTrabajadores.Size = new System.Drawing.Size(86, 24);
            this.lTrabajadores.TabIndex = 1;
            this.lTrabajadores.Text = "Nº trabajadores: ";
            this.lTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numHoras
            // 
            this.numHoras.DecimalPlaces = 2;
            this.numHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHoras.Location = new System.Drawing.Point(97, 49);
            this.numHoras.Margin = new System.Windows.Forms.Padding(2);
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(110, 20);
            this.numHoras.TabIndex = 2;
            // 
            // numTrabajadores
            // 
            this.numTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTrabajadores.Location = new System.Drawing.Point(97, 73);
            this.numTrabajadores.Margin = new System.Windows.Forms.Padding(2);
            this.numTrabajadores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTrabajadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrabajadores.Name = "numTrabajadores";
            this.numTrabajadores.Size = new System.Drawing.Size(110, 20);
            this.numTrabajadores.TabIndex = 3;
            this.numTrabajadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbMaterial
            // 
            this.gbMaterial.AutoSize = true;
            this.gbMaterial.Controls.Add(this.tblMaterial);
            this.gbMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaterial.Location = new System.Drawing.Point(225, 7);
            this.gbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.gbMaterial.Size = new System.Drawing.Size(214, 143);
            this.gbMaterial.TabIndex = 1;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Materiales";
            // 
            // tblMaterial
            // 
            this.tblMaterial.AutoSize = true;
            this.tblMaterial.ColumnCount = 2;
            this.tblMaterial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaterial.Controls.Add(this.chkAlumnio, 0, 1);
            this.tblMaterial.Controls.Add(this.chkCobre, 0, 3);
            this.tblMaterial.Controls.Add(this.chkLaton, 0, 4);
            this.tblMaterial.Controls.Add(this.chkHierro, 0, 2);
            this.tblMaterial.Controls.Add(this.numAlu, 1, 1);
            this.tblMaterial.Controls.Add(this.numHierro, 1, 2);
            this.tblMaterial.Controls.Add(this.numCobre, 1, 3);
            this.tblMaterial.Controls.Add(this.numLaton, 1, 4);
            this.tblMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMaterial.Location = new System.Drawing.Point(2, 15);
            this.tblMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tblMaterial.Name = "tblMaterial";
            this.tblMaterial.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.tblMaterial.RowCount = 6;
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMaterial.Size = new System.Drawing.Size(210, 126);
            this.tblMaterial.TabIndex = 0;
            // 
            // chkAlumnio
            // 
            this.chkAlumnio.AutoSize = true;
            this.chkAlumnio.Location = new System.Drawing.Point(27, 2);
            this.chkAlumnio.Margin = new System.Windows.Forms.Padding(2);
            this.chkAlumnio.Name = "chkAlumnio";
            this.chkAlumnio.Padding = new System.Windows.Forms.Padding(4);
            this.chkAlumnio.Size = new System.Drawing.Size(73, 25);
            this.chkAlumnio.TabIndex = 0;
            this.chkAlumnio.Text = "Aluminio";
            this.chkAlumnio.UseVisualStyleBackColor = true;
            this.chkAlumnio.CheckedChanged += new System.EventHandler(this.chkAlumnio_CheckedChanged);
            // 
            // chkCobre
            // 
            this.chkCobre.AutoSize = true;
            this.chkCobre.Location = new System.Drawing.Point(27, 60);
            this.chkCobre.Margin = new System.Windows.Forms.Padding(2);
            this.chkCobre.Name = "chkCobre";
            this.chkCobre.Padding = new System.Windows.Forms.Padding(4);
            this.chkCobre.Size = new System.Drawing.Size(62, 25);
            this.chkCobre.TabIndex = 2;
            this.chkCobre.Text = "Cobre";
            this.chkCobre.UseVisualStyleBackColor = true;
            this.chkCobre.CheckedChanged += new System.EventHandler(this.chkCobre_CheckedChanged);
            // 
            // chkLaton
            // 
            this.chkLaton.AutoSize = true;
            this.chkLaton.Location = new System.Drawing.Point(27, 89);
            this.chkLaton.Margin = new System.Windows.Forms.Padding(2);
            this.chkLaton.Name = "chkLaton";
            this.chkLaton.Padding = new System.Windows.Forms.Padding(4);
            this.chkLaton.Size = new System.Drawing.Size(61, 25);
            this.chkLaton.TabIndex = 3;
            this.chkLaton.Text = "Laton";
            this.chkLaton.UseVisualStyleBackColor = true;
            this.chkLaton.CheckedChanged += new System.EventHandler(this.chkLaton_CheckedChanged);
            // 
            // chkHierro
            // 
            this.chkHierro.AutoSize = true;
            this.chkHierro.Location = new System.Drawing.Point(27, 31);
            this.chkHierro.Margin = new System.Windows.Forms.Padding(2);
            this.chkHierro.Name = "chkHierro";
            this.chkHierro.Padding = new System.Windows.Forms.Padding(4);
            this.chkHierro.Size = new System.Drawing.Size(62, 25);
            this.chkHierro.TabIndex = 4;
            this.chkHierro.Text = "Hierro";
            this.chkHierro.UseVisualStyleBackColor = true;
            this.chkHierro.CheckedChanged += new System.EventHandler(this.chkHierro_CheckedChanged);
            // 
            // numAlu
            // 
            this.numAlu.DecimalPlaces = 2;
            this.numAlu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numAlu.Location = new System.Drawing.Point(104, 2);
            this.numAlu.Margin = new System.Windows.Forms.Padding(2);
            this.numAlu.Name = "numAlu";
            this.numAlu.Size = new System.Drawing.Size(104, 20);
            this.numAlu.TabIndex = 5;
            // 
            // numHierro
            // 
            this.numHierro.DecimalPlaces = 2;
            this.numHierro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHierro.Location = new System.Drawing.Point(104, 31);
            this.numHierro.Margin = new System.Windows.Forms.Padding(2);
            this.numHierro.Name = "numHierro";
            this.numHierro.Size = new System.Drawing.Size(104, 20);
            this.numHierro.TabIndex = 6;
            // 
            // numCobre
            // 
            this.numCobre.DecimalPlaces = 2;
            this.numCobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCobre.Location = new System.Drawing.Point(104, 60);
            this.numCobre.Margin = new System.Windows.Forms.Padding(2);
            this.numCobre.Name = "numCobre";
            this.numCobre.Size = new System.Drawing.Size(104, 20);
            this.numCobre.TabIndex = 7;
            // 
            // numLaton
            // 
            this.numLaton.DecimalPlaces = 2;
            this.numLaton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLaton.Location = new System.Drawing.Point(104, 89);
            this.numLaton.Margin = new System.Windows.Forms.Padding(2);
            this.numLaton.Name = "numLaton";
            this.numLaton.Size = new System.Drawing.Size(104, 20);
            this.numLaton.TabIndex = 8;
            // 
            // bCalcular
            // 
            this.bCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCalcular.Location = new System.Drawing.Point(7, 154);
            this.bCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(214, 49);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click_1);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLimpiar.Location = new System.Drawing.Point(225, 154);
            this.bLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(214, 49);
            this.bLimpiar.TabIndex = 3;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 210);
            this.Controls.Add(this.tblPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrincipal.PerformLayout();
            this.tblNumHT.ResumeLayout(false);
            this.tblNumHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajadores)).EndInit();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            this.tblMaterial.ResumeLayout(false);
            this.tblMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHierro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblNumHT;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.Label lTrabajadores;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.NumericUpDown numTrabajadores;
        private System.Windows.Forms.TableLayoutPanel tblMaterial;
        private System.Windows.Forms.CheckBox chkAlumnio;
        private System.Windows.Forms.CheckBox chkCobre;
        private System.Windows.Forms.CheckBox chkLaton;
        private System.Windows.Forms.CheckBox chkHierro;
        private System.Windows.Forms.NumericUpDown numAlu;
        private System.Windows.Forms.NumericUpDown numHierro;
        private System.Windows.Forms.NumericUpDown numCobre;
        private System.Windows.Forms.NumericUpDown numLaton;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bLimpiar;
    }
}

