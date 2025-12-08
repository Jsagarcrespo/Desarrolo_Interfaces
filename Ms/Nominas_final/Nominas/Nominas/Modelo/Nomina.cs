using Nominas.Controlador;
using System;

namespace Nominas.Modelo
{
    internal class Nomina
    {
    

        private Operacion.Modalidad modalidad;
        private Boolean sindicado;
        private int numHijos;
        private int numAñosTrabajo;
        private int SueldoSindicato;
        private int SueldoModalidad;
        private int SueldoHijos;
        private int SueldoAniosTrabajados;

        

        public Nomina(Operacion.Modalidad modalidad, bool sindicado, int numHijos, int numAñosTrabajo)
        {
            this.modalidad = modalidad;
            this.sindicado = sindicado;
            this.numHijos = numHijos;
            this.numAñosTrabajo = numAñosTrabajo;

            this.SueldoModalidad = (int)Operacion.sueldoModalidad[modalidad];
            this.SueldoSindicato = sindicado ? Operacion.extraSindicato:0;
            this.SueldoHijos = numHijos * Operacion.extraHijos;


            if(numAñosTrabajo < 5)
            {
                this.SueldoAniosTrabajados = 0;
            }
            else if( numAñosTrabajo <= 10)
            {
                this.SueldoAniosTrabajados = numAñosTrabajo * Operacion.extraAnios5a10;
            }
            else
            {
                this.SueldoAniosTrabajados = numAñosTrabajo * Operacion.extraAniosMas10;

            }



        }

        public string CalcularNomina()
        {
            double total = SueldoModalidad + SueldoHijos + SueldoSindicato + SueldoAniosTrabajados;
            return total.ToString();
        }

        


        public bool Sindicado { get => sindicado; set => sindicado = value; }
        public int NumAñosTrabajo { get => numAñosTrabajo; set => numAñosTrabajo = value; }
        public int NumHijos { get => numHijos; set => numHijos = value; }
        public int SueldoSindicato1 { get => SueldoSindicato; set => SueldoSindicato = value; }
        public int SueldoHijos1 { get => SueldoHijos; set => SueldoHijos = value; }
        public int SueldoAniosTrabajados1 { get => SueldoAniosTrabajados; set => SueldoAniosTrabajados = value; }
        public int SueldoModalidad1 { get => SueldoModalidad; set => SueldoModalidad = value; }
        public Operacion.Modalidad Modalidad { get => modalidad; set => modalidad = value; }
    }
}
