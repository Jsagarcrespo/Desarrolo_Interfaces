using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreasYVolumenes.controlador;

namespace AreasYVolumenes

{


    public partial class Form1 : Form


    {
       
        bool mostrado = false;
        const float FONTSIZE = 12f;

        private void Principal_Activated(object sender, EventArgs e)
        {
            mostrado = true;
            Limpiar();
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                float proporcionAncho = (float)this.Width / (float)this.MinimumSize.Width;
                cambiarFuentes(proporcionAncho);

            }
        }

        private void cambiarFuentes(float proporcionAncho)
        {
            float nuevoTamanyo = FONTSIZE * proporcionAncho;

            if (nuevoTamanyo > 24f)
            {
                nuevoTamanyo = 24f;
            }

            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, nuevoTamanyo);
            }
        }

        private void Limpiar()
        {
            
            foreach (Control control in this.Controls)
            {
                if( control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    radio.Checked = true;
                }
            }

            Area.Checked = true;
            rectangulo.Checked = true;

            invisibleNUD();
            limpiarNUD();

        }

        private void invisibleNUD()
        {
            foreach(Control control in tlpMedidas.Controls)
            {
                control.Visible = false;
            }
        }
        private void limpiarNUD()
        {
            nudAltura.Value = 0;
            nudLado.Value = 0;
            nudRadio.Value = 0;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Area_CheckedChanged(object sender, EventArgs e)
        {
            rectangulo.Visible = Area.Checked;
            circulo.Visible = Area.Checked;
            esfera.Visible = Volumen.Checked;
            cubo.Visible = Volumen.Checked;
            invisibleNUD();


        }

        private void rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            nudLado.Visible=rectangulo.Checked;
            nudAltura.Visible=rectangulo.Checked;
            lblAltura.Visible=rectangulo.Checked;
            lblLado.Visible=rectangulo.Checked;
        }

        private void circulo_CheckedChanged(object sender, EventArgs e)
        {
            nudRadio.Visible=circulo.Checked;
            lblRadio.Visible=circulo.Checked;


        }

        private void cubo_CheckedChanged(object sender, EventArgs e)
        {
            nudLado.Visible = cubo.Checked;
            lblLado.Visible = cubo.Checked;
            nudAltura.Visible = rectangulo.Checked;
            lblAltura.Visible = rectangulo.Checked;

        }

        private void esfera_CheckedChanged(object sender, EventArgs e)
        {
            nudRadio.Visible = esfera.Checked;
            lblRadio.Visible = esfera.Checked;
            nudAltura.Visible = rectangulo.Checked;
            lblAltura.Visible = rectangulo.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorOperacion controlador = new ControladorOperacion();
                double resultado = 0;
               // string magnitud = "";
               // string figura = "";



                if (Area.Checked)
                {
                    //magnitud = "área";
                    if (circulo.Checked)
                    {
                        //figura = "círculo";
                        resultado = controlador.CalcularCirculo((double)nudRadio.Value);
                    }
                    else if (rectangulo.Checked)
                    {
                        //figura = "rectángulo";
                        resultado = controlador.CalcularRectangulo(
                            (double)nudLado.Value,
                            (double)nudAltura.Value
                        );
                    }
                } else if (Volumen.Checked) {
                   // magnitud = "volumen";
                    if (cubo.Checked)
                    {
                       // figura = "cubo";
                        resultado = controlador.CalcularCubo((double)nudLado.Value);
                    }
                    else if (esfera.Checked)
                    {
                       // figura = "esfera";
                        resultado = controlador.CalcularEsfera((double)nudRadio.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una figura.");
                    return;
                }

                MessageBox.Show( $"El {resultado:N2}");
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       


        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
