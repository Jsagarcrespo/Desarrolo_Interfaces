using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crespo_JonSagar; 

namespace Crespo_JonSagar.modelo
{
    internal class Evento
    {
        private List<Actividad> actividads = new List<Actividad>();

        private string nombre;
        private int totalPart;
        private bool alojamiento, transporte;

        public Evento(string nombre, int totalPart, bool alojamiento, bool transporte)
        {
            this.nombre = nombre;
            this.totalPart = totalPart;
            this.alojamiento = alojamiento;
            this.transporte = transporte;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int TotalPart { get => totalPart; set => totalPart = value; }
        public bool Alojamiento { get => alojamiento; set => alojamiento = value; }
        public bool Transporte { get => transporte; set => transporte = value; }
        internal List<Actividad> Actividads { get => actividads; set => actividads = value; }

        public int parTolalActi()
        { 
            int total = 0;

            foreach (Actividad act in actividads)
            {
                total += act.Nparticipantes1; 
            }

            return total;
        }
        public int sumaPrecio()
        { 
            int total = 0;

            foreach (Actividad act in actividads)
            {
                total += act.TotalPrecio; 
            }

            return total;
        }

      

    }
}
