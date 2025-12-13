using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomina
{
    internal static class General
    {
        public const int extraSindicato = 50;

        public static readonly Dictionary<Modalidad, double> sueldoModalidad =
            new Dictionary<Modalidad, double>
            {
                { Modalidad.Produccion, 1100.0 },
                { Modalidad.ADMINISTRACION, 1400.0 },
                { Modalidad.TECNICO, 1700.0 },
                { Modalidad.ESPECIALISTA, 2100.0 }

            };

        public const int extraAnios5a10 = 30;
        public const int extraAniosMas10 = 50;
        public const int extraHijos = 100;

        public enum Modalidad
        {
            Produccion,
            ADMINISTRACION,
            TECNICO,
            ESPECIALISTA
        }



    }
}
