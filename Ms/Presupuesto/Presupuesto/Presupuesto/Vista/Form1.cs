using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presupuesto.Controlador;
using Presupuesto.Modelo;

namespace Presupuesto
{
    public partial class Form1 : Form
    {


        List<Modelo.Respuesto> resupuestos=new List<Modelo.Respuesto>();

        const float FONTSIZE = 10.00f;
        Boolean mostrado=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void CbAceite_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAceite.Checked)
            {
                NumAceite.Visible = true;

            }
            else
            {
                NumAceite.Visible = false;

            }

        }

        private void CBFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (CBFiltro.Checked)
            {
                NumFiltro.Visible = true;

            }
            else
            {
                NumFiltro.Visible = false;

            }
        }

        private void CbPastillas_CheckedChanged(object sender, EventArgs e)
        {

            if (CbPastillas.Checked)
            {
                NumPastillasa.Visible = true;
            }
            else
            {
                NumPastillasa.Visible = false;
            }

        }

        private void CbNeumaticos_CheckedChanged(object sender, EventArgs e)
        {

            if (CbNeumaticos.Checked)
            {
                NumNeumaticos.Visible = true;
            }
            else
            {
                NumNeumaticos.Visible = false;
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double tipopr = 0;
                int descuento = 0;

                if (RbMantenimiento.Checked)
                {
                    tipopr = 120;
                }

                else if (RbAveria.Checked)
                {
                    tipopr = 220;
                }

                else if(RbRevision.Checked){
                    tipopr = 350;
                }

                else if (RbUrgente.Checked)
                {
                    tipopr = 500;
                }
                else
                {
                    throw new ApplicationException("Se debe seleccionar uno de los serivicios");
                }

                if (CbAceite.Checked)
                {

                    if ((int)NumAceite.Value < 1 || (int)NumAceite.Value >= 10)
                    {
                        throw new ApplicationException("Num aceite invalido");
                    }

                    Respuesto respuesto = new Respuesto(CbAceite.Text, 12.50, (int)NumAceite.Value);
                    resupuestos.Add(respuesto);
                }

                if (CBFiltro.Checked)
                {
                    if ((int)NumPastillasa.Value < 1 || (int)NumPastillasa.Value >= 5)
                    {
                        throw new ApplicationException("Num aceite invalido");
                    }

                    Respuesto respuesto = new Respuesto(CBFiltro.Text, 18, (int)NumPastillasa.Value);
                    resupuestos.Add(respuesto);
                }
                if (CbPastillas.Checked)
                {

                    if ((int)NumFiltro.Value < 1 || (int)NumFiltro.Value >=4)
                    {
                        throw new ApplicationException("Num aceite invalido");
                    }

                    Respuesto respuesto = new Respuesto(CbPastillas.Text, 45, (int)NumFiltro.Value);
                    resupuestos.Add(respuesto);
                }


                if (CbNeumaticos.Checked)
                {

                    if ((int)NumNeumaticos.Value < 1 || (int)NumNeumaticos.Value >=4)
                    {
                        throw new ApplicationException("Num aceite invalido");
                    }

                    Respuesto respuesto = new Respuesto(CbNeumaticos.Text, 85, (int)NumNeumaticos.Value);
                    resupuestos.Add(respuesto);
                }

                if (CbTarjetaFidelidad.Checked)
                {
                    descuento = 30;


                }
                if (NumAniosCliente.Value <= 5)
                {
                    descuento += 0;
                }
                else if (NumAniosCliente.Value >= 5)
                {
                    descuento += (int)NumAniosCliente.Value * 10;
                } else                 {
                    descuento += (int)NumAniosCliente.Value * 15;
                }
                


                    calculos calculo = new calculos();

                double result = calculo.operacion(TBFecha.Text, (int)NumHoras.Value, (int)NumMecanicos.Value,tipopr, resupuestos, descuento);

                MessageBox.Show($"el presio es {result}");


            }
            catch (Exception ex) { 
            
                    MessageBox.Show(ex.Message );
            
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado) {
                float Altura = this.Height / this.MinimumSize.Height;

                foreach (Control control in tableLayoutPanel1.Controls)
                {

                    control.Font=new Font(control.Font.FontFamily, FONTSIZE*Altura);

                }
            }
        }
    }
}
