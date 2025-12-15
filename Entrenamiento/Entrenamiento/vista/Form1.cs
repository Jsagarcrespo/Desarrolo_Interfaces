using Entrenamiento.controlador;
using Entrenamiento.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        //List<Actividad> actividads = new List<Actividad>();
        Controlador controlador = new Controlador();
        

        public void limpiar()
        {

            tbFecha.Text = "";
            nudPart.Value = 1; 

            chkCardio.Checked = false;
            nudCardio.Visible = false;
            nudCardio.Value = 0;

            chkPesas.Checked = false;
            nudPesas.Visible = false;
            nudPesas.Value = 0;

            chkEstiramiento.Checked = false;
            nudEstiramiento.Visible = false;
            nudEstiramiento.Value = 0;

            chkHiit.Checked = false;
            nudHiit.Visible = false;
            nudHiit.Value = 0;


        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            //double fecha; 
            //if(!double.TryParse(tbFecha.Text, out fecha))
            //{
            //    MessageBox.Show($"numeros");
            //    return;
            //}

            //double resultado = fecha * 2; 

            //MessageBox.Show($"la fecha introducida es: {resultado}"); 
            
        }

        private void chkCardio_CheckedChanged(object sender, EventArgs e)
        {
            nudCardio.Visible = chkCardio.Checked ? true : false;
        }

        private void chkPesas_CheckedChanged(object sender, EventArgs e)
        {
            nudPesas.Visible = chkPesas.Checked ? true : false;
        }

        private void chkEstiramiento_CheckedChanged(object sender, EventArgs e)
        {
            nudEstiramiento.Visible = chkEstiramiento.Checked ? true : false;
        }

        private void chkHiit_CheckedChanged(object sender, EventArgs e)
        {
            nudHiit.Visible = chkHiit.Checked ? true : false;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha;
                if (!DateTime.TryParse(tbFecha.Text, out fecha))
                {
                    MessageBox.Show("Introduce una fecha válida (ejemplo: 14/12/2025).");
                    return;
                }

                Entre entre = new Entre(fecha, (int)nudPart.Value);


                string nom;
                if (chkCardio.Checked)
                {
                    nom = "Cardio";
                    Actividad actividades = new Actividad(nom, (int)nudCardio.Value, entre);
                    entre.Actividades.Add(actividades);
                }
                if (chkPesas.Checked)
                { 
                    nom = "Pesas";
                    Actividad actividades = new Actividad(nom, (int)nudPesas.Value, entre);
                    entre.Actividades.Add(actividades);

                }
                if (chkEstiramiento.Checked)
                { 
                    nom = "Estiramiento"; 
                    Actividad actividades = new Actividad(nom, (int)nudEstiramiento.Value, entre);
                    entre.Actividades.Add(actividades);

                }
                if (chkHiit.Checked)
                {
                    nom = "Hiit";
                    Actividad actividades = new Actividad(nom, (int)nudHiit.Value, entre);
                    entre.Actividades.Add(actividades);
                }


                ////////////////////////////

                string resultado = "";
               // int sumaDuracion = 0;
                foreach (Actividad act in entre.Actividades)
                {
                    resultado += act.ToString() + Environment.NewLine;
                   // sumaDuracion += act.Duracion;
                }



                MessageBox.Show(
                    controlador.CalcEntrenamiento(fecha, (int)nudPart.Value, entre),
                    "lo que se me ha olvidado"
                    );

                limpiar(); 

            }
            catch (Exception ex) 
            {
                // Importante el ex.Message porque si no no me saltaba el mensaje de que habia "DEMASIADOS PARTICIPANTES"

                MessageBox.Show(ex.Message, "error al insertar los datos");
            }
            




        }
    }
}
