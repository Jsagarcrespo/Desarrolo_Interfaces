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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lFecha = new System.Windows.Forms.Label();
            this.lNparticipantes = new System.Windows.Forms.Label();
            this.NumParticipantes = new System.Windows.Forms.NumericUpDown();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.GbActividades = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CbCardio = new System.Windows.Forms.CheckBox();
            this.Cbpesas = new System.Windows.Forms.CheckBox();
            this.CbEstiramientos = new System.Windows.Forms.CheckBox();
            this.CbHIT = new System.Windows.Forms.CheckBox();
            this.NumCardio = new System.Windows.Forms.NumericUpDown();
            this.NumEstiramientos = new System.Windows.Forms.NumericUpDown();
            this.NumPesas = new System.Windows.Forms.NumericUpDown();
            this.NumHIT = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumParticipantes)).BeginInit();
            this.GbActividades.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCardio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEstiramientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHIT)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GbActividades, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lFecha, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lNparticipantes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.NumParticipantes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBFecha, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(725, 191);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lFecha.Location = new System.Drawing.Point(250, 0);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(37, 26);
            this.lFecha.TabIndex = 0;
            this.lFecha.Text = "Fecha";
            // 
            // lNparticipantes
            // 
            this.lNparticipantes.AutoSize = true;
            this.lNparticipantes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lNparticipantes.Location = new System.Drawing.Point(194, 26);
            this.lNparticipantes.Name = "lNparticipantes";
            this.lNparticipantes.Size = new System.Drawing.Size(93, 165);
            this.lNparticipantes.TabIndex = 1;
            this.lNparticipantes.Text = "Num Participantes";
            // 
            // NumParticipantes
            // 
            this.NumParticipantes.AutoSize = true;
            this.NumParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumParticipantes.Location = new System.Drawing.Point(293, 29);
            this.NumParticipantes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumParticipantes.Name = "NumParticipantes";
            this.NumParticipantes.Size = new System.Drawing.Size(429, 20);
            this.NumParticipantes.TabIndex = 2;
            // 
            // TBFecha
            // 
            this.TBFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBFecha.Location = new System.Drawing.Point(293, 3);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.Size = new System.Drawing.Size(429, 20);
            this.TBFecha.TabIndex = 3;
            // 
            // GbActividades
            // 
            this.GbActividades.Controls.Add(this.tableLayoutPanel3);
            this.GbActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbActividades.Location = new System.Drawing.Point(3, 220);
            this.GbActividades.Name = "GbActividades";
            this.GbActividades.Size = new System.Drawing.Size(725, 199);
            this.GbActividades.TabIndex = 1;
            this.GbActividades.TabStop = false;
            this.GbActividades.Text = "Actividades";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.CbCardio, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Cbpesas, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.CbEstiramientos, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.CbHIT, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.NumCardio, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.NumEstiramientos, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.NumPesas, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.NumHIT, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(719, 180);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CbCardio
            // 
            this.CbCardio.AutoSize = true;
            this.CbCardio.Location = new System.Drawing.Point(23, 41);
            this.CbCardio.Name = "CbCardio";
            this.CbCardio.Size = new System.Drawing.Size(56, 17);
            this.CbCardio.TabIndex = 0;
            this.CbCardio.Text = "Cardio";
            this.CbCardio.UseVisualStyleBackColor = true;
            this.CbCardio.CheckedChanged += new System.EventHandler(this.CbCardio_CheckedChanged);
            // 
            // Cbpesas
            // 
            this.Cbpesas.AutoSize = true;
            this.Cbpesas.Location = new System.Drawing.Point(23, 67);
            this.Cbpesas.Name = "Cbpesas";
            this.Cbpesas.Size = new System.Drawing.Size(55, 17);
            this.Cbpesas.TabIndex = 1;
            this.Cbpesas.Text = "Pesas";
            this.Cbpesas.UseVisualStyleBackColor = true;
            this.Cbpesas.CheckedChanged += new System.EventHandler(this.Cbpesas_CheckedChanged);
            // 
            // CbEstiramientos
            // 
            this.CbEstiramientos.AutoSize = true;
            this.CbEstiramientos.Location = new System.Drawing.Point(23, 93);
            this.CbEstiramientos.Name = "CbEstiramientos";
            this.CbEstiramientos.Size = new System.Drawing.Size(88, 17);
            this.CbEstiramientos.TabIndex = 2;
            this.CbEstiramientos.Text = "Estiramientos";
            this.CbEstiramientos.UseVisualStyleBackColor = true;
            this.CbEstiramientos.CheckedChanged += new System.EventHandler(this.CbEstiramientos_CheckedChanged);
            // 
            // CbHIT
            // 
            this.CbHIT.AutoSize = true;
            this.CbHIT.Location = new System.Drawing.Point(23, 119);
            this.CbHIT.Name = "CbHIT";
            this.CbHIT.Size = new System.Drawing.Size(44, 17);
            this.CbHIT.TabIndex = 3;
            this.CbHIT.Text = "HIT";
            this.CbHIT.UseVisualStyleBackColor = true;
            this.CbHIT.CheckedChanged += new System.EventHandler(this.CbHIT_CheckedChanged);
            // 
            // NumCardio
            // 
            this.NumCardio.AutoSize = true;
            this.NumCardio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCardio.Location = new System.Drawing.Point(117, 41);
            this.NumCardio.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumCardio.Name = "NumCardio";
            this.NumCardio.Size = new System.Drawing.Size(599, 20);
            this.NumCardio.TabIndex = 4;
            this.NumCardio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCardio.Visible = false;
            // 
            // NumEstiramientos
            // 
            this.NumEstiramientos.AutoSize = true;
            this.NumEstiramientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumEstiramientos.Location = new System.Drawing.Point(117, 93);
            this.NumEstiramientos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumEstiramientos.Name = "NumEstiramientos";
            this.NumEstiramientos.Size = new System.Drawing.Size(599, 20);
            this.NumEstiramientos.TabIndex = 8;
            this.NumEstiramientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumEstiramientos.Visible = false;
            // 
            // NumPesas
            // 
            this.NumPesas.AutoSize = true;
            this.NumPesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumPesas.Location = new System.Drawing.Point(117, 67);
            this.NumPesas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumPesas.Name = "NumPesas";
            this.NumPesas.Size = new System.Drawing.Size(599, 20);
            this.NumPesas.TabIndex = 9;
            this.NumPesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumPesas.Visible = false;
            // 
            // NumHIT
            // 
            this.NumHIT.AutoSize = true;
            this.NumHIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumHIT.Location = new System.Drawing.Point(117, 119);
            this.NumHIT.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumHIT.Name = "NumHIT";
            this.NumHIT.Size = new System.Drawing.Size(599, 20);
            this.NumHIT.TabIndex = 7;
            this.NumHIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumHIT.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnLimpiar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnCalcular, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(725, 91);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLimpiar.Location = new System.Drawing.Point(3, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(356, 85);
            this.BtnLimpiar.TabIndex = 0;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalcular.Location = new System.Drawing.Point(365, 3);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(357, 85);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(282, 503);
            this.Name = "Form1";
            this.Text = "tab";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumParticipantes)).EndInit();
            this.GbActividades.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCardio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEstiramientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHIT)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown NumParticipantes;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.GroupBox GbActividades;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox CbCardio;
        private System.Windows.Forms.CheckBox Cbpesas;
        private System.Windows.Forms.CheckBox CbEstiramientos;
        private System.Windows.Forms.CheckBox CbHIT;
        private System.Windows.Forms.NumericUpDown NumCardio;
        private System.Windows.Forms.NumericUpDown NumHIT;
        private System.Windows.Forms.NumericUpDown NumEstiramientos;
        private System.Windows.Forms.NumericUpDown NumPesas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lNparticipantes;
    }
}

