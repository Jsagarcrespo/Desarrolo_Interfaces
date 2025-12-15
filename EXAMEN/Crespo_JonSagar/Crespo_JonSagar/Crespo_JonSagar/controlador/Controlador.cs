using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crespo_JonSagar.controlador;
using Crespo_JonSagar.modelo;

namespace Crespo_JonSagar.controlador
{
    internal class Controlador
    {
        public string Calculo(string nombre, int totalPart, bool alojamiento, bool transporte, Evento evento )
        {
            int sumaPart = evento.parTolalActi();

            if (string.IsNullOrEmpty(nombre)) 
            {
                throw new ArgumentException("Es obligatorio el nombre");

            }

            int precioAlojaTotal = alojamiento ? sumaPart*(int)General.Alojamiento : 0;
            int precioTransTotal = transporte ? sumaPart*(int)General.Transporte : 0;

            if (totalPart < 0 || totalPart > 20)
            {
                throw new ArgumentException("No puede haber 0 o mas de 20 participantes.");
                
            }

            if (sumaPart > totalPart)
            {
                throw new ArgumentException("No puede haber mas participantes que el total.");

            }

            // ESTAS LINEAS SE ME HAN OLVIDADO EN EL EXAMEN

            int sumaPPP = evento.sumaPrecio();

            int suma_Todo = sumaPPP + precioTransTotal + precioAlojaTotal;

            return
$@"
El total asciende a: {suma_Todo}
"; 

        }
    }
}
