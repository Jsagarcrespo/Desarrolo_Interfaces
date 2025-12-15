using AyVcheckSender.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyVcheckSender
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        public void limpiar()
        {
            RBArea.Checked = true;

            RBRectangulo.Checked = false;
            RBRectangulo.Visible = true;

            RBCirculo.Checked = false;
            RBCirculo.Visible = true;

            RBEsfera.Checked = false;
            RBEsfera.Visible = false;

            RBCubo.Checked = false;
            RBCubo.Visible = false;

            TBMedidas.Visible = false;

        }

      

        

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void RBArea_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = false;
            RBRectangulo.Visible = RBArea.Checked;
            RBCirculo.Visible = RBArea.Checked;
        }

        private void RBVolumen_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = false;
            RBEsfera.Visible = RBVolumen.Checked;
            RBCubo.Visible = RBVolumen.Checked;
        }

        private void RBRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = true;
            Lradio.Visible = false;
            Nradio.Visible = false;

            Llado.Visible = RBRectangulo.Checked;
            Lalt.Visible = RBRectangulo.Checked;

            Nalt.Visible = RBRectangulo.Checked;
            Nlado.Visible = RBRectangulo.Checked;
        }

        private void RBCirculo_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = true;
            Lradio.Visible = RBCirculo.Checked;
            Nradio.Visible = RBCirculo.Checked;

            Llado.Visible = false;
            Lalt.Visible = false;

            Nalt.Visible = false;
            Nlado.Visible = false;
        }

        private void RBEsfera_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = true;
            Lradio.Visible = RBEsfera.Checked;
            Nradio.Visible = RBEsfera.Checked;

            Llado.Visible = false;
            Lalt.Visible = false;

            Nalt.Visible = false;
            Nlado.Visible = false;
        }

        private void RBCubo_CheckedChanged(object sender, EventArgs e)
        {
            TBMedidas.Visible = true;
            Lradio.Visible = false;
            Nradio.Visible = false;

            Llado.Visible = RBCubo.Checked;
            Lalt.Visible = false;

            Nalt.Visible = false;
            Nlado.Visible = RBCubo.Checked;
        }

        private void BTCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string figura = null;

                if (RBRectangulo.Checked) figura = RBRectangulo.Text;
                else if (RBCirculo.Checked) figura = RBCirculo.Text;
                else if (RBEsfera.Checked) figura = RBEsfera.Text;
                else if (RBCubo.Checked) figura = RBCubo.Text;

                if (figura == null)
                {
                    MessageBox.Show("Selecciona una figura");
                    return;
                }

                Operacion operacion = new Operacion(
                    figura,
                    (double)Nradio.Value,
                    (double)Nlado.Value,
                    (double)Nalt.Value);

                double resul = operacion.Calcular();

                MessageBox.Show($"Resultado: {resul}", "LAS MATEMATICAS HIJO");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "error");
            }
             
            

        }
    }
}
