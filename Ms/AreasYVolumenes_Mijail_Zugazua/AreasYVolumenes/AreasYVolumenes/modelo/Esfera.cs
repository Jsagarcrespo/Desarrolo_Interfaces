using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasYVolumenes.modelo
{
    internal class Esfera
    {
        public Esfera(double radio)
        {
            this.radio = radio;
        }

        public double radio { get; set; }

        public double VolumenEsfera()
        {
            return (4.0 / 3.0) * Math.PI * radio * radio * radio;
        }



    }
}
