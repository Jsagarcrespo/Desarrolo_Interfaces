using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04_factura.modelo
{
    internal class Factura
    {
        public double numHoras { get; set; }
        public int numTrabajadores { get; set; }
        public List<Material> materiales { get; set; }

        public Factura(double numHoras, int numTrabajadores)
        {
            this.numHoras = numHoras;
            this.numTrabajadores = numTrabajadores;
            materiales = new List<Material>();
        }
        public void SumarMaterial(Material material)
        {
            materiales.Add(material);
        }
        public double CalcularFactura()
        {
            double total = 0;
            total += numHoras * numTrabajadores * General.precioHora;
            foreach (var material in materiales)
            {
                total += material.Precio * material.Cantidad;
            }
            return total;
        }
    }
}
