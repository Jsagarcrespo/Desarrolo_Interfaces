namespace nomina
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
            this.TBLPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gbModalidad = new System.Windows.Forms.GroupBox();
            this.tblModalidad = new System.Windows.Forms.TableLayoutPanel();
            this.RProduccion = new System.Windows.Forms.RadioButton();
            this.Radministracion = new System.Windows.Forms.RadioButton();
            this.Rtecnico = new System.Windows.Forms.RadioButton();
            this.Respecialista = new System.Windows.Forms.RadioButton();
            this.chkinscripcion = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numTrabajos = new System.Windows.Forms.NumericUpDown();
            this.numHijos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.TBLPrincipal.SuspendLayout();
            this.gbModalidad.SuspendLayout();
            this.tblModalidad.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHijos)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLPrincipal
            // 
            this.TBLPrincipal.ColumnCount = 1;
            this.TBLPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBLPrincipal.Controls.Add(this.gbModalidad, 0, 0);
            this.TBLPrincipal.Controls.Add(this.chkinscripcion, 0, 1);
            this.TBLPrincipal.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.TBLPrincipal.Controls.Add(this.bCalcular, 0, 3);
            this.TBLPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBLPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TBLPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.TBLPrincipal.Name = "TBLPrincipal";
            this.TBLPrincipal.Padding = new System.Windows.Forms.Padding(8);
            this.TBLPrincipal.RowCount = 4;
            this.TBLPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TBLPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBLPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBLPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TBLPrincipal.Size = new System.Drawing.Size(490, 528);
            this.TBLPrincipal.TabIndex = 0;
            // 
            // gbModalidad
            // 
            this.gbModalidad.Controls.Add(this.tblModalidad);
            this.gbModalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbModalidad.Location = new System.Drawing.Point(10, 10);
            this.gbModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.gbModalidad.Name = "gbModalidad";
            this.gbModalidad.Padding = new System.Windows.Forms.Padding(2);
            this.gbModalidad.Size = new System.Drawing.Size(470, 303);
            this.gbModalidad.TabIndex = 0;
            this.gbModalidad.TabStop = false;
            this.gbModalidad.Text = "Modalidad de trabajo";
            // 
            // tblModalidad
            // 
            this.tblModalidad.ColumnCount = 1;
            this.tblModalidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModalidad.Controls.Add(this.RProduccion, 0, 0);
            this.tblModalidad.Controls.Add(this.Radministracion, 0, 1);
            this.tblModalidad.Controls.Add(this.Rtecnico, 0, 2);
            this.tblModalidad.Controls.Add(this.Respecialista, 0, 3);
            this.tblModalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblModalidad.Location = new System.Drawing.Point(2, 15);
            this.tblModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tblModalidad.Name = "tblModalidad";
            this.tblModalidad.RowCount = 4;
            this.tblModalidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblModalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblModalidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblModalidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblModalidad.Size = new System.Drawing.Size(466, 286);
            this.tblModalidad.TabIndex = 0;
            // 
            // RProduccion
            // 
            this.RProduccion.AutoSize = true;
            this.RProduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RProduccion.Location = new System.Drawing.Point(2, 103);
            this.RProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.RProduccion.Name = "RProduccion";
            this.RProduccion.Size = new System.Drawing.Size(462, 17);
            this.RProduccion.TabIndex = 0;
            this.RProduccion.TabStop = true;
            this.RProduccion.Tag = "Produccion";
            this.RProduccion.Text = "Produccion";
            this.RProduccion.UseVisualStyleBackColor = true;
            // 
            // Radministracion
            // 
            this.Radministracion.AutoSize = true;
            this.Radministracion.Location = new System.Drawing.Point(2, 124);
            this.Radministracion.Margin = new System.Windows.Forms.Padding(2);
            this.Radministracion.Name = "Radministracion";
            this.Radministracion.Size = new System.Drawing.Size(93, 17);
            this.Radministracion.TabIndex = 1;
            this.Radministracion.TabStop = true;
            this.Radministracion.Tag = "Administracion";
            this.Radministracion.Text = "Administracion";
            this.Radministracion.UseVisualStyleBackColor = true;
            // 
            // Rtecnico
            // 
            this.Rtecnico.AutoSize = true;
            this.Rtecnico.Location = new System.Drawing.Point(2, 145);
            this.Rtecnico.Margin = new System.Windows.Forms.Padding(2);
            this.Rtecnico.Name = "Rtecnico";
            this.Rtecnico.Size = new System.Drawing.Size(64, 17);
            this.Rtecnico.TabIndex = 2;
            this.Rtecnico.TabStop = true;
            this.Rtecnico.Tag = "Tecnico";
            this.Rtecnico.Text = "Tecnico";
            this.Rtecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rtecnico.UseVisualStyleBackColor = true;
            // 
            // Respecialista
            // 
            this.Respecialista.AutoSize = true;
            this.Respecialista.Location = new System.Drawing.Point(2, 166);
            this.Respecialista.Margin = new System.Windows.Forms.Padding(2);
            this.Respecialista.Name = "Respecialista";
            this.Respecialista.Size = new System.Drawing.Size(81, 17);
            this.Respecialista.TabIndex = 3;
            this.Respecialista.TabStop = true;
            this.Respecialista.Tag = "Especialista";
            this.Respecialista.Text = "Especialista";
            this.Respecialista.UseVisualStyleBackColor = true;
            // 
            // chkinscripcion
            // 
            this.chkinscripcion.AutoSize = true;
            this.chkinscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkinscripcion.Location = new System.Drawing.Point(10, 317);
            this.chkinscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.chkinscripcion.Name = "chkinscripcion";
            this.chkinscripcion.Size = new System.Drawing.Size(470, 17);
            this.chkinscripcion.TabIndex = 1;
            this.chkinscripcion.Text = "Estoy incrit@ en un sindicato";
            this.chkinscripcion.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.numTrabajos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numHijos, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 338);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(470, 48);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // numTrabajos
            // 
            this.numTrabajos.Location = new System.Drawing.Point(94, 2);
            this.numTrabajos.Margin = new System.Windows.Forms.Padding(2);
            this.numTrabajos.Name = "numTrabajos";
            this.numTrabajos.Size = new System.Drawing.Size(280, 20);
            this.numTrabajos.TabIndex = 0;
            // 
            // numHijos
            // 
            this.numHijos.Location = new System.Drawing.Point(94, 26);
            this.numHijos.Margin = new System.Windows.Forms.Padding(2);
            this.numHijos.Name = "numHijos";
            this.numHijos.Size = new System.Drawing.Size(280, 20);
            this.numHijos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Años trabajados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de hij@s";
            // 
            // bCalcular
            // 
            this.bCalcular.AutoSize = true;
            this.bCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCalcular.Location = new System.Drawing.Point(72, 396);
            this.bCalcular.Margin = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.bCalcular.MaximumSize = new System.Drawing.Size(230, 91);
            this.bCalcular.MinimumSize = new System.Drawing.Size(110, 43);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(230, 91);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 528);
            this.Controls.Add(this.TBLPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(275, 331);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.TBLPrincipal.ResumeLayout(false);
            this.TBLPrincipal.PerformLayout();
            this.gbModalidad.ResumeLayout(false);
            this.tblModalidad.ResumeLayout(false);
            this.tblModalidad.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TBLPrincipal;
        private System.Windows.Forms.GroupBox gbModalidad;
        private System.Windows.Forms.TableLayoutPanel tblModalidad;
        private System.Windows.Forms.RadioButton RProduccion;
        private System.Windows.Forms.RadioButton Radministracion;
        private System.Windows.Forms.RadioButton Rtecnico;
        private System.Windows.Forms.RadioButton Respecialista;
        private System.Windows.Forms.CheckBox chkinscripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numTrabajos;
        private System.Windows.Forms.NumericUpDown numHijos;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

