using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio01_calculadora.modelo;

namespace ejercicio01_calculadora.controlador
{
    internal class ControladorOperacion
    {
        public double Calcular(double num1,double num2, string tipo)
        {
            if (num2==0 && tipo=="/")
            {
                throw new Exception("No se puede dividir entre 0");
            }
            Operacion miOperacion = new Operacion(num1, num2, tipo);
            return miOperacion.Calcular();
        }
    }
}
