using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AreaYvolumenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioRectangulo.Text = "Rectangulo";
                radioRectangulo.Tag = "RECTAN";
                radioRectangulo.Visible = true;

                radioCirculo.Text = "Volumen";
                radioCirculo.Tag = "Vol";
                radioCirculo.Visible = true;

             
            }
           
        }

        private void radioVolumen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVolumen.Checked)
            {
                radioRectangulo.Text = "Esfera";
                radioRectangulo.Visible = true;

                radioCirculo.Text = "Circulo";
                radioCirculo.Visible = true;

                //radioRectangulo.Visible = false;
                //radioCirculo.Visible = false;
            }
        }

        private void Figura_Enter(object sender, EventArgs e)
        {
           
        }

        private void Medidas_Enter(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void radioRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            string figura = "";

            if (radioRectangulo.Checked) {

            
        }
    }
}
