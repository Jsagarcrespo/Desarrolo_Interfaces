using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crespo_JonSagar.modelo
{
    internal class Actividad
    {
        private string nombre;
        private int precio, Nparticipantes;
        private Evento evento;
        private int totalPrecio = 0; 

        public Actividad(string nombre, int precio, int nparticipantes)
        {
            this.nombre = nombre;
            this.precio = precio;
            Nparticipantes = nparticipantes;
            this.Evento = evento;

            switch (nombre)
            {
                case "Sala de escape":
                    totalPrecio = precio * nparticipantes; 
                    break; 
                case "Pain ball":
                    totalPrecio = precio * nparticipantes; 
                    break; 
                case "Humor amarillo":
                    totalPrecio = precio * nparticipantes; 
                    break; 
                case "Cena + espectaculo":
                    totalPrecio = precio * nparticipantes; 
                    break; 
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Nparticipantes1 { get => Nparticipantes; set => Nparticipantes = value; }
        public int TotalPrecio { get => totalPrecio; set => totalPrecio = value; }
        internal Evento Evento { get => evento; set => evento = value; }
    }
}
