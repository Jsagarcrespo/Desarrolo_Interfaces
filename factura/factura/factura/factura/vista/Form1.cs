using factura.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        Controlador micontrolador = new Controlador();

        public void limpiar()
        {
            numHoras.Value = 0;
            numTrabajadores.Value = 1;

            chkAlumnio.Checked = false;
            numAlu.Visible = false;
            numAlu.Value = 0;

            chkCobre.Checked = false;
            numCobre.Visible = false;
            numCobre.Value = 0;

            chkHierro.Checked = false;
            numHierro.Visible = false;
            numHierro.Value = 0;

            chkLaton.Checked = false;
            numLaton.Visible = false;
            numLaton.Value = 0;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void chkAlumnio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlumnio.Checked)
            {
                numAlu.Visible = true;
            }
            else
            {
                numAlu.Visible = false;
            }
        }

        private void chkHierro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHierro.Checked)
            {
                numHierro.Visible = true;
            }
            else
            {
                numHierro.Visible=false;
            }
            
        }

        private void chkCobre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCobre.Checked)
            {
                numCobre.Visible = true;
            }
            else
            {
                numCobre.Visible = false;
            }

        }

        private void chkLaton_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaton.Checked)
            {
                numLaton.Visible = true;
            }
            else
            {
                numLaton.Visible = false;
            }
        }

        private void bCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(

                                micontrolador.CalcFactura(
                                    (int)numHoras.Value,
                                    (int)numTrabajadores.Value,
                                    (int)numAlu.Value,
                                    (int)numHierro.Value,
                                    (int)numCobre.Value,
                                    (int)numLaton.Value),
                                "Total de la factura"
                                );

                            limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error al insertar los datos");
            }

        }
    }
}
