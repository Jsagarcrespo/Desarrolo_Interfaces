using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyV.modelo
{
    internal class Rectangulo
    {
        

        public Rectangulo(double lado, double altura) 
        {
            this.lado = lado; 
            this.altura = altura; 
        }

        public double lado { get; set; }    
        public double altura { get; set; }

        /*
        public double Lado { get => lado; set => lado = value; }
        public double Altura { get => altura; set => altura = value; }
        */

        public double areaRec()
        {
            return lado * altura; 
        }
    }
}
