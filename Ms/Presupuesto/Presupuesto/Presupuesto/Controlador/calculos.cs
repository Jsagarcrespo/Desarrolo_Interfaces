using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presupuesto.Modelo;

namespace Presupuesto.Controlador
{
    internal class calculos
    {

        public double operacion(String fecha,int numhoras, int nmecanicos,
            double tipopre,List<Respuesto> respuestos,int descuento)
        {

            Modelo.Presupuesto presupuesto = new Modelo.Presupuesto(fecha,numhoras,nmecanicos,tipopre,descuento);

            if(string.IsNullOrWhiteSpace(fecha))
            {
                throw new ApplicationException("No puede estar vacia la fecha");
            }

            if (numhoras <= 0)
            {
                throw new ApplicationException("No puede haber numero de horas negativas");

            }

            if(nmecanicos < 1 ||nmecanicos >6)
            {
                throw new ApplicationException("No puede haber numero de mecanicos negativas");
            }
            if (tipopre <= 0) {

                throw new ApplicationException("Hay que seleccionar una preparacion");
            }

            foreach(Respuesto respuesto in respuestos)
            {
                presupuesto.Respuestos.Add(respuesto);
            }
         
            double result=presupuesto.calcularTotal();


            return result;


        }
        
    }
}
