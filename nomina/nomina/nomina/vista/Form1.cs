using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nomina
{
    public partial class Form1 : Form
    {

        bool mostrado = false;
        const float FONT_SIZE = 8.00f;
        const float MARGIN_TB = 16.00f;
        const float MARGIN_LR = 128.00f;
        const float PADDING = 16.00f;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                float proporcionAlto = this.Size.Height / this.MinimumSize.Height;
                float proporcionAncho = this.Size.Width / this.MinimumSize.Width;
                foreach (Control control in TBLPrincipal.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, proporcionAlto * Font.Size);

                }
                TBLPrincipal.Padding = new Padding((int)(PADDING * proporcionAncho));
                bCalcular.Margin = new Padding((int)(PADDING * proporcionAncho),
                    (int)(MARGIN_TB * proporcionAlto),
                   (int)(MARGIN_LR * proporcionAncho),
                   (int)(MARGIN_TB * proporcionAlto));
            }
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tblModalidad.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    string valor = rb.Tag.ToString();
                    MessageBox.Show("La nomina de: " + valor + " es: ");
                    return;
                }
            }

            MessageBox.Show("No seleccionaste ninguna opción");
        }
    }
}
