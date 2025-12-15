using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presupuesto.modelo
{
    internal class Presuppuesto
    {

        private List<Consumibles> consumibles = new List<Consumibles>();
        
        private DateTime fecha;
        private int horas, mecanicos, aniosFidelidad;

        public Presuppuesto(/*List<Consumibles> consumibles,*/ DateTime fecha, int horas, int mecanicos, int aniosFidelidad)
        {
           //this.consumibles = consumibles;
            this.fecha = fecha;
            this.horas = horas;
            this.mecanicos = mecanicos;
            this.aniosFidelidad = aniosFidelidad;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Horas { get => horas; set => horas = value; }
        public int Mecanicos { get => mecanicos; set => mecanicos = value; }
        public int AniosFidelidad { get => aniosFidelidad; set => aniosFidelidad = value; }
        internal List<Consumibles> Consumibles { get => consumibles; set => consumibles = value; }


        public double SumarConsumibles()
        {
            double resultado = 0;

            foreach(Consumibles cons  in consumibles)
            {
                resultado += cons.Precio; 
            }

            if (this.aniosFidelidad != 0) 
            {
                resultado -= 30; 
            }

            return resultado;
        }
    }
}
