using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04_factura.modelo
{
    internal class Material
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set; }

        public Material(string nombre, double precio, double cantidad)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}
