namespace presupuesto
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudMecanicos = new System.Windows.Forms.NumericUpDown();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbMantenimiento = new System.Windows.Forms.RadioButton();
            this.rbAveria = new System.Windows.Forms.RadioButton();
            this.rbRevision = new System.Windows.Forms.RadioButton();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chbAceite = new System.Windows.Forms.CheckBox();
            this.chbFiltro = new System.Windows.Forms.CheckBox();
            this.chbPastillas = new System.Windows.Forms.CheckBox();
            this.chbNeumatico = new System.Windows.Forms.CheckBox();
            this.nudAceite = new System.Windows.Forms.NumericUpDown();
            this.nudFiltro = new System.Windows.Forms.NumericUpDown();
            this.nudNeumatico = new System.Windows.Forms.NumericUpDown();
            this.nudPastillas = new System.Windows.Forms.NumericUpDown();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chbFidelidad = new System.Windows.Forms.CheckBox();
            this.nudFidelidad = new System.Windows.Forms.NumericUpDown();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMecanicos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAceite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeumatico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPastillas)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFidelidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.AutoSize = true;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tlpPrincipal.Controls.Add(this.bLimpiar, 0, 3);
            this.tlpPrincipal.Controls.Add(this.bCalcular, 1, 3);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(333, 316);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nudHoras, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nudMecanicos, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbFecha, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nª Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nª Mecanicos";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(166, 29);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(120, 20);
            this.nudHoras.TabIndex = 3;
            // 
            // nudMecanicos
            // 
            this.nudMecanicos.Location = new System.Drawing.Point(166, 55);
            this.nudMecanicos.Name = "nudMecanicos";
            this.nudMecanicos.Size = new System.Drawing.Size(120, 20);
            this.nudMecanicos.TabIndex = 4;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(166, 3);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(100, 20);
            this.tbFecha.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.rbMantenimiento, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbAveria, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rbRevision, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.rbUrgente, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(160, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // rbMantenimiento
            // 
            this.rbMantenimiento.AutoSize = true;
            this.rbMantenimiento.Location = new System.Drawing.Point(3, 7);
            this.rbMantenimiento.Name = "rbMantenimiento";
            this.rbMantenimiento.Size = new System.Drawing.Size(94, 17);
            this.rbMantenimiento.TabIndex = 0;
            this.rbMantenimiento.TabStop = true;
            this.rbMantenimiento.Text = "Mantenimiento";
            this.rbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // rbAveria
            // 
            this.rbAveria.AutoSize = true;
            this.rbAveria.Location = new System.Drawing.Point(3, 30);
            this.rbAveria.Name = "rbAveria";
            this.rbAveria.Size = new System.Drawing.Size(55, 17);
            this.rbAveria.TabIndex = 1;
            this.rbAveria.TabStop = true;
            this.rbAveria.Text = "Averia";
            this.rbAveria.UseVisualStyleBackColor = true;
            // 
            // rbRevision
            // 
            this.rbRevision.AutoSize = true;
            this.rbRevision.Location = new System.Drawing.Point(3, 53);
            this.rbRevision.Name = "rbRevision";
            this.rbRevision.Size = new System.Drawing.Size(66, 17);
            this.rbRevision.TabIndex = 2;
            this.rbRevision.TabStop = true;
            this.rbRevision.Text = "Revision";
            this.rbRevision.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(3, 76);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbUrgente.TabIndex = 3;
            this.rbUrgente.TabStop = true;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.chbAceite, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chbFiltro, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.chbPastillas, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.chbNeumatico, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.nudAceite, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudFiltro, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.nudNeumatico, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.nudPastillas, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(169, 87);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(161, 100);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // chbAceite
            // 
            this.chbAceite.AutoSize = true;
            this.chbAceite.Location = new System.Drawing.Point(3, 1);
            this.chbAceite.Name = "chbAceite";
            this.chbAceite.Size = new System.Drawing.Size(56, 17);
            this.chbAceite.TabIndex = 0;
            this.chbAceite.Text = "Aceite";
            this.chbAceite.UseVisualStyleBackColor = true;
            this.chbAceite.CheckedChanged += new System.EventHandler(this.chbAceite_CheckedChanged);
            // 
            // chbFiltro
            // 
            this.chbFiltro.AutoSize = true;
            this.chbFiltro.Location = new System.Drawing.Point(3, 27);
            this.chbFiltro.Name = "chbFiltro";
            this.chbFiltro.Size = new System.Drawing.Size(48, 17);
            this.chbFiltro.TabIndex = 1;
            this.chbFiltro.Text = "Filtro";
            this.chbFiltro.UseVisualStyleBackColor = true;
            this.chbFiltro.CheckedChanged += new System.EventHandler(this.chbFiltro_CheckedChanged);
            // 
            // chbPastillas
            // 
            this.chbPastillas.AutoSize = true;
            this.chbPastillas.Location = new System.Drawing.Point(3, 53);
            this.chbPastillas.Name = "chbPastillas";
            this.chbPastillas.Size = new System.Drawing.Size(64, 17);
            this.chbPastillas.TabIndex = 2;
            this.chbPastillas.Text = "Pastillas";
            this.chbPastillas.UseVisualStyleBackColor = true;
            this.chbPastillas.CheckedChanged += new System.EventHandler(this.chbPastillas_CheckedChanged);
            // 
            // chbNeumatico
            // 
            this.chbNeumatico.AutoSize = true;
            this.chbNeumatico.Location = new System.Drawing.Point(3, 79);
            this.chbNeumatico.Name = "chbNeumatico";
            this.chbNeumatico.Size = new System.Drawing.Size(74, 17);
            this.chbNeumatico.TabIndex = 3;
            this.chbNeumatico.Text = "Neumatico";
            this.chbNeumatico.UseVisualStyleBackColor = true;
            this.chbNeumatico.CheckedChanged += new System.EventHandler(this.chbNeumatico_CheckedChanged);
            // 
            // nudAceite
            // 
            this.nudAceite.Location = new System.Drawing.Point(83, 1);
            this.nudAceite.Name = "nudAceite";
            this.nudAceite.Size = new System.Drawing.Size(75, 20);
            this.nudAceite.TabIndex = 4;
            // 
            // nudFiltro
            // 
            this.nudFiltro.Location = new System.Drawing.Point(83, 27);
            this.nudFiltro.Name = "nudFiltro";
            this.nudFiltro.Size = new System.Drawing.Size(75, 20);
            this.nudFiltro.TabIndex = 5;
            // 
            // nudNeumatico
            // 
            this.nudNeumatico.Location = new System.Drawing.Point(83, 79);
            this.nudNeumatico.Name = "nudNeumatico";
            this.nudNeumatico.Size = new System.Drawing.Size(75, 20);
            this.nudNeumatico.TabIndex = 6;
            // 
            // nudPastillas
            // 
            this.nudPastillas.Location = new System.Drawing.Point(83, 53);
            this.nudPastillas.Name = "nudPastillas";
            this.nudPastillas.Size = new System.Drawing.Size(75, 20);
            this.nudPastillas.TabIndex = 7;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLimpiar.Location = new System.Drawing.Point(3, 225);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(160, 88);
            this.bLimpiar.TabIndex = 5;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCalcular
            // 
            this.bCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCalcular.Location = new System.Drawing.Point(169, 225);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(161, 88);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chbFidelidad, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.nudFidelidad, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 193);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(327, 26);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // chbFidelidad
            // 
            this.chbFidelidad.AutoSize = true;
            this.chbFidelidad.Location = new System.Drawing.Point(3, 3);
            this.chbFidelidad.Name = "chbFidelidad";
            this.chbFidelidad.Size = new System.Drawing.Size(101, 17);
            this.chbFidelidad.TabIndex = 0;
            this.chbFidelidad.Text = "Tarjeta fidelidad";
            this.chbFidelidad.UseVisualStyleBackColor = true;
            // 
            // nudFidelidad
            // 
            this.nudFidelidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudFidelidad.Location = new System.Drawing.Point(110, 3);
            this.nudFidelidad.Name = "nudFidelidad";
            this.nudFidelidad.Size = new System.Drawing.Size(214, 20);
            this.nudFidelidad.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 316);
            this.Controls.Add(this.tlpPrincipal);
            this.MinimumSize = new System.Drawing.Size(289, 288);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.form1_activated);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMecanicos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAceite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeumatico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPastillas)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFidelidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.NumericUpDown nudMecanicos;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbMantenimiento;
        private System.Windows.Forms.RadioButton rbAveria;
        private System.Windows.Forms.RadioButton rbRevision;
        private System.Windows.Forms.RadioButton rbUrgente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox chbAceite;
        private System.Windows.Forms.CheckBox chbFiltro;
        private System.Windows.Forms.CheckBox chbPastillas;
        private System.Windows.Forms.CheckBox chbNeumatico;
        private System.Windows.Forms.NumericUpDown nudAceite;
        private System.Windows.Forms.NumericUpDown nudFiltro;
        private System.Windows.Forms.NumericUpDown nudNeumatico;
        private System.Windows.Forms.NumericUpDown nudPastillas;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chbFidelidad;
        private System.Windows.Forms.NumericUpDown nudFidelidad;
    }
}

