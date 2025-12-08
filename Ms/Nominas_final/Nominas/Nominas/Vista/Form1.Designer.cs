namespace Nominas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Modalidad = new System.Windows.Forms.TableLayoutPanel();
            this.RbProduccion = new System.Windows.Forms.RadioButton();
            this.RbAdministracion = new System.Windows.Forms.RadioButton();
            this.RbTecnico = new System.Windows.Forms.RadioButton();
            this.RbEspecialista = new System.Windows.Forms.RadioButton();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumAnyos = new System.Windows.Forms.NumericUpDown();
            this.NumHijos = new System.Windows.Forms.NumericUpDown();
            this.ChkBtnSindicato = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Modalidad.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnyos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHijos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCalcular, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ChkBtnSindicato, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Modalidad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidad de trabajo";
            // 
            // Modalidad
            // 
            this.Modalidad.AutoSize = true;
            this.Modalidad.ColumnCount = 1;
            this.Modalidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modalidad.Controls.Add(this.RbProduccion, 0, 1);
            this.Modalidad.Controls.Add(this.RbAdministracion, 0, 2);
            this.Modalidad.Controls.Add(this.RbTecnico, 0, 3);
            this.Modalidad.Controls.Add(this.RbEspecialista, 0, 4);
            this.Modalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modalidad.Location = new System.Drawing.Point(3, 16);
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.RowCount = 6;
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Modalidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modalidad.Size = new System.Drawing.Size(347, 215);
            this.Modalidad.TabIndex = 2;
            // 
            // RbProduccion
            // 
            this.RbProduccion.AutoSize = true;
            this.RbProduccion.Location = new System.Drawing.Point(3, 64);
            this.RbProduccion.Name = "RbProduccion";
            this.RbProduccion.Size = new System.Drawing.Size(79, 17);
            this.RbProduccion.TabIndex = 0;
            this.RbProduccion.TabStop = true;
            this.RbProduccion.Text = "Produccion";
            this.RbProduccion.UseVisualStyleBackColor = true;
            this.RbProduccion.CheckedChanged += new System.EventHandler(this.RbProduccion_CheckedChanged);
            // 
            // RbAdministracion
            // 
            this.RbAdministracion.AutoSize = true;
            this.RbAdministracion.Location = new System.Drawing.Point(3, 87);
            this.RbAdministracion.Name = "RbAdministracion";
            this.RbAdministracion.Size = new System.Drawing.Size(93, 17);
            this.RbAdministracion.TabIndex = 1;
            this.RbAdministracion.TabStop = true;
            this.RbAdministracion.Text = "Administracion";
            this.RbAdministracion.UseVisualStyleBackColor = true;
            // 
            // RbTecnico
            // 
            this.RbTecnico.AutoSize = true;
            this.RbTecnico.Location = new System.Drawing.Point(3, 110);
            this.RbTecnico.Name = "RbTecnico";
            this.RbTecnico.Size = new System.Drawing.Size(64, 17);
            this.RbTecnico.TabIndex = 2;
            this.RbTecnico.TabStop = true;
            this.RbTecnico.Text = "Tacnico";
            this.RbTecnico.UseVisualStyleBackColor = true;
            // 
            // RbEspecialista
            // 
            this.RbEspecialista.AutoSize = true;
            this.RbEspecialista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbEspecialista.Location = new System.Drawing.Point(3, 133);
            this.RbEspecialista.Name = "RbEspecialista";
            this.RbEspecialista.Size = new System.Drawing.Size(341, 17);
            this.RbEspecialista.TabIndex = 3;
            this.RbEspecialista.TabStop = true;
            this.RbEspecialista.Text = "Especializsta";
            this.RbEspecialista.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalcular.Location = new System.Drawing.Point(128, 337);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(128, 16, 128, 16);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(103, 28);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.NumAnyos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.NumHijos, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 266);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(353, 52);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Años trabajados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Hij@s";
            // 
            // NumAnyos
            // 
            this.NumAnyos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumAnyos.Location = new System.Drawing.Point(99, 3);
            this.NumAnyos.Name = "NumAnyos";
            this.NumAnyos.Size = new System.Drawing.Size(251, 20);
            this.NumAnyos.TabIndex = 2;
            // 
            // NumHijos
            // 
            this.NumHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumHijos.Location = new System.Drawing.Point(99, 29);
            this.NumHijos.Name = "NumHijos";
            this.NumHijos.Size = new System.Drawing.Size(251, 20);
            this.NumHijos.TabIndex = 3;
            // 
            // ChkBtnSindicato
            // 
            this.ChkBtnSindicato.AutoSize = true;
            this.ChkBtnSindicato.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkBtnSindicato.Location = new System.Drawing.Point(3, 243);
            this.ChkBtnSindicato.Name = "ChkBtnSindicato";
            this.ChkBtnSindicato.Size = new System.Drawing.Size(129, 17);
            this.ChkBtnSindicato.TabIndex = 4;
            this.ChkBtnSindicato.Text = "Estoy en un Sindicato";
            this.ChkBtnSindicato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(375, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Resize += new System.EventHandler(this.Form1_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Modalidad.ResumeLayout(false);
            this.Modalidad.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnyos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel Modalidad;
        private System.Windows.Forms.RadioButton RbProduccion;
        private System.Windows.Forms.RadioButton RbAdministracion;
        private System.Windows.Forms.RadioButton RbTecnico;
        private System.Windows.Forms.RadioButton RbEspecialista;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumAnyos;
        private System.Windows.Forms.NumericUpDown NumHijos;
        private System.Windows.Forms.CheckBox ChkBtnSindicato;
    }
}

