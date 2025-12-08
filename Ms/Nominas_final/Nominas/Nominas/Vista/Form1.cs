using Nominas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class Form1 : Form
    {
        bool mostrado = false;
        const float FONT_SIZE = 8.00F;
        const float MARGIN_LR = 88.00F;
        const float MARGIN_TB = 88.00F;
        const float PADDING= 88.00F;

        Operacion operacion = new Operacion();
        public Form1()
        {
            InitializeComponent();
        }
  



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                float propAlto = this.Height / this.MinimumSize.Height;
                float propAncho = this.Width / this.MinimumSize.Width;
            

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Font = new Font (control.Font.FontFamily, FONT_SIZE * propAlto);
            }

          }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Operacion.Modalidad modalidad = Operacion.Modalidad.ADMINISTRACION;

                if (RbAdministracion.Checked)
                {
                    modalidad=Operacion.Modalidad.ADMINISTRACION;
                }else if (RbProduccion.Checked)
                {
                    modalidad = Operacion.Modalidad.PRODUCCION;
                }else if(RbTecnico.Checked)
                {
                    modalidad = Operacion.Modalidad.TECNICO;
                }


                MessageBox.Show(
                    
                    operacion.CalcularNomina(
                    modalidad,
                    ChkBtnSindicato.Checked,
                    (int)NumAnyos.Value,
                    (int)NumHijos.Value),"NOMINA"
                    
                );


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR");
               
            
            }
            
        }

        private void RbProduccion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
