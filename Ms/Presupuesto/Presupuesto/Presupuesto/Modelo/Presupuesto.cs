using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuesto.Modelo
{
    internal class Presupuesto
    {

        public Presupuesto(String fecha,int horas,int mecanicos,double tipoServicio,int precioDescuento) {

            Fecha = fecha;
            Horas= horas;
            Mecanicos= mecanicos;
            TipoServicio= tipoServicio;
          
            Respuestos = new List<Respuesto>();
            PrecioDescuento = precioDescuento;
        
        }

        public String Fecha { get; set; }
        public int Horas { get; set; }
        public int Mecanicos { get; set; }
        public double TipoServicio { get; set; }

        public List<Respuesto> Respuestos { get; set; }
        public int PrecioDescuento { get; set; }


        public double calcularTotal()
        {
            double total = 0;

            total += TipoServicio;

            total += Horas*Mecanicos*28;

            foreach (Respuesto re in Respuestos)
            {

                total += re.Precio*re.Cantidad;

            }

            
            
                total = total - PrecioDescuento;
            

            return total;
        }

    }
}
