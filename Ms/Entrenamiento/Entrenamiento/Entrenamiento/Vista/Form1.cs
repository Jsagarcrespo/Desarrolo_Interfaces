using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrenamiento.Controlador;
using Entrenamiento.Modelo;

namespace Entrenamiento
{
    public partial class Form1 : Form
    {
        List <Modelo.Actividad> actividades=new List<Modelo.Actividad>();
       const float FONTSIZE = 10.00f;

        Boolean cardio = false;
        Boolean Pesas = false;
        Boolean Estiramientos = false;
        Boolean Hit = false;

        Boolean mostrado=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;

        }

        private void CbCardio_CheckedChanged(object sender, EventArgs e)
        {

            if (CbCardio.Checked)
            {
                NumCardio.Visible = true;
                cardio = true;
            }
            else
            {
                NumCardio.Visible = false;
                cardio = false;
            }

        }

        private void Cbpesas_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbpesas.Checked)
            {
                NumPesas.Visible = true;
                Pesas = true;
            }
            else
            {
                NumPesas.Visible = false;
                Pesas = false;
            }

        }

        private void CbEstiramientos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEstiramientos.Checked)
            {

                NumEstiramientos.Visible = true;
                Estiramientos = true;
            }
            else
            {
                NumEstiramientos.Visible = false;
                Estiramientos = false;


            }
          } 
        

        private void CbHIT_CheckedChanged(object sender, EventArgs e)
        {
            if (CbHIT.Checked)
            {
                NumHIT.Visible = true;
                Hit = true;
            }
            else
            {
                NumHIT.Visible = false;
                Hit = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado)
            {
                float Altura = (float)this.Height / (float)this.MinimumSize.Height;

               

               
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, FONTSIZE * Altura);
                }
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbCardio.Checked)
                {

                    int numeroP = (int)NumCardio.Value;

                    Actividad actividad = new Actividad(CbCardio.Text, 60, numeroP);
                    actividades.Add(actividad);


                }

                if (CbEstiramientos.Checked)
                {


                    int numeroE = (int)NumEstiramientos.Value;

                    Actividad actividad = new Actividad(CbEstiramientos.Text, 45, numeroE);
                    actividades.Add(actividad);

                }

                if (CbHIT.Checked)
                {
                    int numeroH = (int)NumHIT.Value;

                    Actividad actividad = new Actividad(CbHIT.Text, 30, numeroH);
                    actividades.Add(actividad);
                }

                if (Cbpesas.Checked)
                {
                    int numeroP = (int)NumPesas.Value;

                    Actividad actividad = new Actividad(Cbpesas.Text, 45, numeroP);
                    actividades.Add(actividad);


                }

                Calculos calculos = new Calculos();

                double result = calculos.operaciones(TBFecha.Text, (int)NumParticipantes.Value, actividades, cardio, Pesas, Estiramientos, Hit);

                MessageBox.Show($"el entrneamiento dura {result} minutos");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message," error al insertar los datos");
            }
        }

            public void Limpiar()
             {
                TBFecha.Text = string.Empty;
                NumParticipantes.Value = 0;
            NumPesas.Value = 0;
            NumHIT.Value = 0;
            NumCardio.Value = 0;
            NumEstiramientos.Value = 0;

            CbCardio.Checked=false;
            CbEstiramientos.Checked = false;
            CbHIT.Checked=false;
            Cbpesas.Checked=false;

            cardio = false;
            Pesas = false;
            Estiramientos = false;
            Hit = false;

            actividades.Clear();



             }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
    }

