using AyV.controlador;
using AyV.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyV
{
    public partial class Form1 : Form
    {

        // SACAR LAS MEDIDAS VER EN CLASE COMO LO HACE LA PROFE

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

        private void GBFigura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBMedidas_Paint(object sender, PaintEventArgs e)
        {

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

        private void TBMagnitud_Paint(object sender, PaintEventArgs e)
        {

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

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BTCalcular_Click(object sender, EventArgs e)
        {
            ControladorOperaciones operaciones = new ControladorOperaciones();

            double resultado = 0;
            string magnitud = RBArea.Checked ? "area" : "volumen";
            string figura = "";

            if (RBRectangulo.Checked) figura = "rectangulo";
            if (RBCirculo.Checked) figura = "circulo";
            if (RBEsfera.Checked) figura = "esfera";
            if (RBCubo.Checked) figura = "cubo";
            

            if (string.IsNullOrEmpty(figura)) 
            {
                MessageBox.Show("Selecciona una figura");
                return;
            }

            switch (figura)
            {
                case "rectangulo":
                    resultado = operaciones.calcRectangulo(
                        (double)Nlado.Value,
                        (double)Nalt.Value);
                    break;

                case "circulo":
                    resultado = operaciones.calCirculo((double)Nradio.Value);
                    break;

                case "esfera":
                    resultado = operaciones.calcEsfera((double)Nradio.Value);
                    break;

                case "cubo":
                    resultado = operaciones.calCubo((double)Nradio.Value);
                    break; 

            }

            MessageBox.Show($"El {magnitud} de {figura} es {resultado}");
            limpiar(); 

        } 
    }

}
