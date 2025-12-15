using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuesto.Modelo
{
    internal class Respuesto
    {
       

        public Respuesto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }


        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }




    }
}
