using presupuesto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presupuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Limpiar();
        }


        bool mostrado = false;

        const float FONTSIZE = 10.00f;



        /// <summary>
        /// Limpia todos los campos del formulario y restablece los valores iniciales
        /// </summary>
        /// <param name="sender">Control que lanza el evento </param>
        /// <param name="e">Argumentos del evento</param>
        public void Limpiar()
        {
            tbFecha.Text = "";
            nudHoras.Value = 0;
            nudMecanicos.Value = 0;


            rbMantenimiento.Checked = false;
            rbAveria.Checked = false;
            rbRevision.Checked = false;
            rbUrgente.Checked = false;

            chbAceite.Checked = false;
            nudAceite.Value = 0;
            nudAceite.Visible = false;
            
            chbFiltro.Checked = false;
            nudFiltro.Value = 0;
            nudFiltro.Visible = false;
            
            chbPastillas.Checked = false;
            nudPastillas.Value = 0;
            nudPastillas.Visible = false;
            
            chbNeumatico.Checked = false;
            nudNeumatico.Value = 0;
            nudNeumatico.Visible = false;

            
            nudFidelidad.Value = 0;
            chbFidelidad.Checked = false;


        }


        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Se ejectuta cuando el formulario pasa a estar activo por primera vez. 
        /// Marca el formulario como mostrado para permitir la logica de redimensionado
        /// </summary>
        /// <param name="sender">formulario que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void form1_activated(object sender, EventArgs e)
        {
            mostrado = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                float proporcionalto = this.Size.Height / this.MinimumSize.Height;

                foreach (Control control in tlpPrincipal.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, proporcionalto * FONTSIZE);
                }
            }
        }


        /// <summary>
        /// Oculta o muestra el NUD si damos al CHB
        /// </summary>
        /// <param name="sender">Checkbox de todos los comsumibles</param>
        /// <param name="e"></param>
        private void chbAceite_CheckedChanged(object sender, EventArgs e)
        {
            nudAceite.Visible = chbAceite.Checked ? true : false;
        }

        private void chbFiltro_CheckedChanged(object sender, EventArgs e)
        {
            nudFiltro.Visible = chbFiltro.Checked ? true : false;
        }

        private void chbPastillas_CheckedChanged(object sender, EventArgs e)
        {
            nudPastillas.Visible = chbPastillas.Checked ? true : false;
        }

        private void chbNeumatico_CheckedChanged(object sender, EventArgs e)
        {
            nudNeumatico.Visible = chbPastillas.Checked ? true : false;
        }



        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fehca;

                if (!DateTime.TryParse(tbFecha.Text, out fehca))
                {
                    MessageBox.Show("Introduce una fecha válida (ejemplo: 14/12/2025).");
                    return;
                }

                Presuppuesto pres = new Presuppuesto(fehca, (int)nudHoras.Value, (int)nudMecanicos.Value, (int)nudFidelidad.Value);


                if (!chbAceite.Checked &&
                    !chbFiltro.Checked &&
                    !chbPastillas.Checked &&
                    !chbNeumatico.Checked)
                {
                    MessageBox.Show("Debes seleccionar al menos un consumible", "erros al seleccionar");
                    return;
                }


                if (chbAceite.Checked)
                {
                    Consumibles consumibles = new Consumibles(chbAceite.Text, (int)nudAceite.Value);
                    pres.Consumibles.Add(consumibles);
                }
                if (chbFiltro.Checked)
                {
                    Consumibles consumibles = new Consumibles(chbFiltro.Text, (int)nudAceite.Value);
                    pres.Consumibles.Add(consumibles);

                }
                if (chbPastillas.Checked)
                {
                    Consumibles consumibles = new Consumibles(chbPastillas.Text, (int)nudPastillas.Value);
                    pres.Consumibles.Add(consumibles);

                }
                if (chbNeumatico.Checked)
                {
                    Consumibles consumibles = new Consumibles(chbAceite.Text, (int)nudAceite.Value);
                    pres.Consumibles.Add(consumibles);

                }

                double resultado = pres.SumarConsumibles();
                string resul = resultado.ToString();

                MessageBox.Show(resul, "el resultado del precio"); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"error de datos"); 
            }
           


        }

        
    }
}
