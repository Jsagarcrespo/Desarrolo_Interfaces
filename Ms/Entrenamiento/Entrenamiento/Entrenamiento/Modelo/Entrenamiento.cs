using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrenamiento.Modelo
{
    internal class Entrenamiento
    {

        public Entrenamiento(String fecha,int numtotalmax) {

            Fecha = fecha;
            NumTotalMax=numtotalmax;
            Actividades = new List<Actividad>();
        }

        public String Fecha { get; set; }
        public List<Actividad> Actividades { get; set; }
        public int NumTotalMax { get; set; }

        public double Entrnos()
        {
            double mins = 0;


            foreach (Actividad a in Actividades)
            {

                mins += a.Duracion;
            }

            return mins;
        }



    }
}
