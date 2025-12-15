using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrenamiento.Controlador
{
    internal class Calculos
    {

        public double operaciones(string Fecha,int NUMTotalPat,List<Modelo.Actividad> actividades, Boolean Cardio,Boolean Pesas,Boolean Estiramientos,Boolean HIT)
        {

            int numParticipantes = 0;
            double tiempoT = 0;
            foreach(Modelo.Actividad ent in actividades)
            {
                numParticipantes += ent.NumeroPart;


                if(numParticipantes > 0 && numParticipantes<=NUMTotalPat)
                {


                  Modelo.Entrenamiento entrenamiento=new Modelo.Entrenamiento(Fecha,NUMTotalPat);

                    foreach(Modelo.Actividad A in actividades)
                    {
                        entrenamiento.Actividades.Add(A);

                    }
                    tiempoT = entrenamiento.Entrnos();
                    
                }
                else
                {
                    throw new ApplicationException("Demasiados participantes");

                }

            }

            return tiempoT;



        }


    }
}
