using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasYVolumenes.modelo
{
    internal class Cubo
    {
        public Cubo(double lado)
        {
            this.lado = lado;
        }

        public double lado {  get; set; }


        public double VolumenCubo()
        {
            return lado * lado * lado;
        }

    }
}
