using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01_calculadora.modelo
{
    internal class Operacion
    {
        public Operacion(double num1, double num2, string tipo)
        {
            Num1 = num1;
            Num2 = num2;
            Tipo = tipo;
        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Tipo { get; set; }

        public double Calcular()
        {
            double resultado = 0;
            switch (Tipo)
            {
                case "+":
                    resultado = Num1+ Num2;
                    break;
                case "-":
                    resultado = Num1 - Num2;
                    break;
                case "x":
                    resultado = Num1 * Num2;
                    break;
                case "/":
                    resultado = Num1 / Num2;
                    break;
                case "^":
                    resultado = Math.Pow(Num1, Num2);
                    break;

                default: throw new Exception("Tipo de operación no valido");             
            }
            return resultado;
        }


    }
}
