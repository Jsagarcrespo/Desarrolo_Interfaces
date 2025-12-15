using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Entrenamiento.modelo
{
    internal class Entre
    {
        private List<Actividad> actividades = new List<Actividad>();

        private DateTime fehca;
        private int totalParticipantes;

        public Entre(DateTime fehca, int totalParticipantes)
        {
            this.fehca = fehca;
            this.totalParticipantes = totalParticipantes;

            //if (Actividad.SumaPart > totalParticipantes)
            //{
            //    throw new ArgumentException("La suma de participantes supera el total permitido.");
            //}
        }

        public DateTime Fehca { get => fehca; set => fehca = value; }
        public int TotalParticipantes { get => totalParticipantes; set => totalParticipantes = value; }
        internal List<Actividad> Actividades { get => actividades; set => actividades = value; }


        public int sumaDuracion()
        {
            int sumaDuracion = 0;

            foreach (Actividad a in actividades)
            {
                sumaDuracion += a.Duracion;
            }
            return sumaDuracion;
        }

        public int sumaParticipantes()
        {
            int sumaParticipantes = 0;

            foreach (Actividad a in actividades)
            {
                sumaParticipantes += a.NumPart;
            }

            return sumaParticipantes;
        }

    }
}


