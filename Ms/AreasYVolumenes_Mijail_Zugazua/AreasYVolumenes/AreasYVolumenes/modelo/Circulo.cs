using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasYVolumenes.modelo
{
    internal class Circulo
    {
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double radio { get; set; }

        public double AreaCirculo()
        {
            return Math.PI * radio * radio;
        }




    }
}
