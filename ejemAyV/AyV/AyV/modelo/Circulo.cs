using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyV.modelo
{
    internal class Circulo
    {
        public double radio { get; private set; }

        public Circulo(double radio) 
        {
            this.radio = radio; 
        }

        public double areaCirculo()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
       

    }
}
