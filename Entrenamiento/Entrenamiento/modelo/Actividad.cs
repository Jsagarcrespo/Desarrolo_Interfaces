using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entrenamiento.modelo
{
    internal class Actividad
    {
        private string nom;
        private int duracion, numPart;
        private Entre entrenamiento;
        
        private static int sumaPart = 0; 

        public Actividad(string nom, int numPart, Entre entrenamiento)
        {
            this.nom = nom;
            this.duracion = duracion;
            this.numPart = numPart;
            this.entrenamiento = entrenamiento;

            if (this.nom == "Cardio" || this.nom == "Pesas")
            {
                this.duracion = 60; 
            }
            if (this.nom == "Estiramiento")
            {
                this.duracion = 45; 
            }
            if (this.nom == "Hiit")
            {
                this.duracion = 30; 
            }

            sumaPart += numPart; 
           
        }

        public string Nom { get => nom; set => nom = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int NumPart { get => numPart; set => numPart = value; }
        internal Entre Entrenamiento { get => entrenamiento; set => entrenamiento = value; }
        public static int SumaPart { get => sumaPart; set => sumaPart = value; }

        public override string ToString()
        {
            return string.Format("el entrenamiento dura: {0}, el nunero de participantes son {1}", entrenamiento.sumaDuracion(), sumaPart); 
        }
        
    }
}
