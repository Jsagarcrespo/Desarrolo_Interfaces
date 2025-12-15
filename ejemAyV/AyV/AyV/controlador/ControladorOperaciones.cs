using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importante para poder usar los modelos
using AyV.modelo; 

namespace AyV.controlador
{
    internal class ControladorOperaciones
    {
        public double calcRectangulo(double lado, double altura)
        {
            if (lado <= 0 || lado >= 300)
                throw new ArgumentOutOfRangeException(nameof(lado), "Lado fuera de rango(0-300)");

            if (altura <= 0 || altura >= 300)
                throw new ArgumentOutOfRangeException(nameof(altura), "Altura fuera de rango(0-300)");

            Rectangulo rectangulo = new Rectangulo(lado, altura);
            return rectangulo.areaRec();


        }

        public double calCirculo(double radio)
        {
            if (radio <= 0 || radio >= 300)
                throw new ArgumentOutOfRangeException(nameof(radio), "radio fuera de rango(0-300)");

            Circulo circulo = new Circulo(radio);
            return circulo.areaCirculo();
        }

        public double calCubo(double lado)
        {
            if (lado <= 0 || lado >= 300)
                throw new ArgumentOutOfRangeException(nameof(lado), "Lado fuera de rango(0-300)");

            Cubo cubo = new Cubo(lado);
            return cubo.voluCirculo();
        }

        public double calcEsfera(double radio)
        {
            if (radio <= 0 || radio >= 300)
                throw new ArgumentOutOfRangeException(nameof(radio), "radio fuera de rango(0-300)");

            Esfera esfera = new Esfera(radio);
            return esfera.volCirculo();
        }



    }

}
