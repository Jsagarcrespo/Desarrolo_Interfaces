using Crespo_JonSagar.controlador;
using Crespo_JonSagar.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crespo_JonSagar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Limpiar();
        }

        public void Limpiar()
        {
            tbNombre.Text = "";
            nudPart.Value = 0; 

            chbEscape.Checked = false;
            nudEscape.Visible = false;
            nudEscape.Value = 0;

            chbPaint.Checked = false;
            nudPaint.Visible = false;
            nudPaint.Value = 0;

            chbHumor.Checked = false;
            nudHumor.Visible = false;
            nudHumor.Value = 0;

            chbCena.Checked = false;
            nudCena.Visible = false;
            nudCena.Value = 0;



        }

        

        const float FONTOSIZE = 1.00f; 
        bool mostrado = false;

        private void Form1_activated(object sender, EventArgs e)
        {
            mostrado = true;
        }



        private void Form1_Resized(object sender, EventArgs e)
        {
            if (mostrado) 
            {
                float proporcionAlto = this.Size.Height / this.MinimumSize.Height;
                foreach (Control control in tblPrincipal.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, proporcionAlto * FONTOSIZE); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = null; 
            Controlador miControl = new Controlador();

            try
            {
               Evento evento = new Evento(tbNombre.Text, (int)nudPart.Value, chbAlo.Checked, chbTran.Checked); 
                // esta linea lo tengo mal he metido: chbEscape.Text en vez de tbNombre.Text  

                if (chbEscape.Checked)

                    nombre = "Escape"; 

                {
                    int soloPartEnEscape = (int)nudEscape.Value;
                    if (soloPartEnEscape <= 0)
                    {
                        throw new Exception("Tiene que haber mas de 0 participantes");
                    }
                    else
                    {
                        //Esta linea la tengo mal metida: tbNombre.Text en vez de chbEscape.Text
                        Actividad actis = new Actividad(chbEscape.Text, 35, soloPartEnEscape);
                        evento.Actividads.Add(actis);
                    }

                        
                }
                if (chbPaint.Checked)
                {
                    nombre = "Paint";
                    int soloPartEnPaint = (int)nudPaint.Value;

                    if (soloPartEnPaint <= 0) 
                    {
                        throw new Exception("Tiene que haber mas de 0 participantes");
                    }
                    else 
                    {  
                        Actividad actis = new Actividad(chbPaint.Text, 30, soloPartEnPaint);
                        evento.Actividads.Add(actis);
                    }

                       

                }
                if (chbHumor.Checked)
                {
                    nombre = "Humor";
                    int soloPartEnPaint = (int)nudHumor.Value;

                    if (soloPartEnPaint <= 0)
                    {
                        throw new Exception("Tiene que haber mas de 0 participantes");
                    }
                    else 
                    { 
                        Actividad actis = new Actividad(chbHumor.Text, 25, soloPartEnPaint);
                        evento.Actividads.Add(actis);
                    }
                       

                }
                if (chbCena.Checked)
                {
                    nombre = "Cena";
                    int soloPartEnPaint = (int)nudCena.Value;

                    if (soloPartEnPaint <= 0)
                    {
                        throw new Exception("Tiene que haber mas de 0 participantes");
                    }
                    else
                    {
                        Actividad actis = new Actividad(chbCena.Text, 70, soloPartEnPaint);
                        evento.Actividads.Add(actis);
                    }

                }

                 


                MessageBox.Show(miControl.Calculo( // esta linea lo tengo mal no estoy llamando a Calculo
                    tbNombre.Text,  // esta linea lo tengo mal en el examen teno metiod nombre
                    (int)nudPart.Value,
                    chbAlo.Checked,
                    chbTran.Checked,
                    evento),
                "Precio del evento"

                    ); 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error al insertar los datos");
            }
        }

        private void chbEscape_CheckedChanged(object sender, EventArgs e)
        {
            nudEscape.Visible = chbEscape.Checked ? true : false;
        }

        private void chbPaint_CheckedChanged(object sender, EventArgs e)
        {
            nudPaint.Visible = chbPaint.Checked ? true : false;

        }

        private void chbHumor_CheckedChanged(object sender, EventArgs e)
        {
            nudHumor.Visible = chbHumor.Checked ? true : false;

        }

        private void chbCena_CheckedChanged(object sender, EventArgs e)
        {
            nudCena.Visible = chbCena.Checked ? true : false;

        }
    }
}
