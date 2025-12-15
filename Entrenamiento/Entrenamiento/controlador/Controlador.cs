using Entrenamiento.modelo; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Entrenamiento.controlador
{
    internal class Controlador
    {

        public string CalcEntrenamiento(DateTime fecha, int totalParticipantes, Entre entrenamiento)
        {

            //if (!DateTime.TryParse(fecha.ToString(), out fecha) 
            //{
            //    throw new ArgumentException("tienes que meterlo en forma de fechar");
            //}

            //Entre entrenaiento = new Entre(fecha, totalParticipantes);

            int sumaDeParticipantes = entrenamiento.sumaParticipantes(); 

            int sumaDeDuracion = entrenamiento.sumaDuracion();



            if (totalParticipantes < sumaDeParticipantes)
            {
                throw new Exception("Demasiados participantes");
            }

            return
$@"Fecha del entrenamiento: {fecha}
Total permitido: {totalParticipantes}
Participantes en actividades: {sumaDeParticipantes}
Duración total de actividades: {sumaDeDuracion} minutos";


        }
    }
}
