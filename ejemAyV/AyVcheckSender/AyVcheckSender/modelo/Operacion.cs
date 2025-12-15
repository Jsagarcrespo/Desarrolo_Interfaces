using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyVcheckSender.modelo
{
    internal class Operacion
    {
        private string figura;
        private double radio, lado, altura;

        public Operacion(string figura, double radio, double lado, double altura)
        {
            this.figura = figura;
            this.radio = radio;
            this.lado = lado;
            this.altura = altura;

        }

        public string Figura { get => figura; set => figura = value; }
        public double Radio { get => radio; set => radio = value; }
        public double Lado { get => lado; set => lado = value; }
        public double Altura { get => altura; set => altura = value; }


        public double Calcular()
        {
            double resultado = 0;

            switch (figura)
            {
                case "Rectangulo":
                    resultado = Lado * Altura;
                    break;

                case "Circulo":
                    return Math.PI * Math.Pow(Radio, 2);
                    break;

                case "Esfera":
                    resultado = Math.PI * Math.Pow(Radio, 2);
                    break;

                case "Cubo":
                    resultado = Math.PI * Math.Pow(Radio, 2);
                    break;

            }

            return resultado;
        }
    }
}
