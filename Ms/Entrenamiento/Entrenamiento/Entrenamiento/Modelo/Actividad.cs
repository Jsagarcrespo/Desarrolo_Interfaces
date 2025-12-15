using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrenamiento.Modelo
{
    internal class Actividad
    {
        public Actividad(String nombre,double duracion,int numeropart) {

            Nombre = nombre;
            Duracion= duracion;
            NumeroPart = numeropart;
        }

        public String Nombre { get; set; }
        public double Duracion { get; set; }
        public int NumeroPart { get; set; }
    }
}
