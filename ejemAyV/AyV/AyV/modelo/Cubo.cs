 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyV.modelo
{
    internal class Cubo
    {
        public Cubo(double radio) 
        {
            this.radio = radio;
        }

        public double radio { get; private set; }

        public double voluCirculo()
        {
            return Math.PI * Math.Pow(radio, 2); 
        }

    }
}
