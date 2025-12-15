using ejercicio04_factura.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04_factura
{
    public partial class Principal : Form
    {

        const int FUENTE = 8;
        private bool mostrado = false;
        private Controlador miControlador = new Controlador();

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                double proporcionAlto = (double)this.Height / this.MinimumSize.Height;

                foreach (Control control in tlpPrincipal.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, (float)(FUENTE * proporcionAlto));
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;
        }

        private void Limpiar()
        {
            nudHoras.Value = 0.00M;
            nudTrabajadores.Value = 1;
            cbAluminio.Checked = false;
            cbHierro.Checked = false;
            cbCobre.Checked = false;
            cbLaton.Checked = false;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string total = miControlador.CalcularFactura(
                    (double)nudHoras.Value,
                    (int)nudTrabajadores.Value,
                    cbAluminio.Checked, (double)nudAluminio.Value,
                    cbHierro.Checked, (double)nudHierro.Value,
                    cbCobre.Checked, (double)nudCobre.Value,
                    cbLaton.Checked, (double)nudLaton.Value
                );

                MessageBox.Show(total, "Total de factura");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al insertar los datos");
            }
        }

        private void cbAluminio_CheckedChanged(object sender, EventArgs e)
        {
            nudAluminio.Visible = cbAluminio.Checked;
            nudAluminio.Value = 0;
        }

        private void cbHierro_CheckedChanged(object sender, EventArgs e)
        {
            nudHierro.Visible = cbHierro.Checked;
            nudHierro.Value = 0;
        }

        private void cbCobre_CheckedChanged(object sender, EventArgs e)
        {
            nudCobre.Visible = cbCobre.Checked;
            nudCobre.Value = 0;
        }

        private void cbLaton_CheckedChanged(object sender, EventArgs e)
        {
            nudLaton.Visible = cbLaton.Checked;
            nudLaton.Value = 0;
        }
    }
}
