using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nomina.General;

namespace nomina
{
    internal class Nomina
    {
        public Modalidad modalidad { get; set; }
        public bool sindicato { get; set; }
        public int anios { get; set; }
        public int numHijos { get; set; }
        public int sueldoModalidad { get; }
        public int sueldoSindicato { get; }
        public int sueldoHijos { get; }
        public int sueldoAnisTrabajados { get; }




        public Nomina(Modalidad modalidad, bool sindicato, int anios, int numHijos)
        {
            this.modalidad = modalidad;
            this.sindicato = sindicato;
            this.anios = anios;
            this.numHijos = numHijos;

            this.sueldoModalidad = (int)General.sueldoModalidad[modalidad];
            this.sueldoSindicato = sindicato ? General.extraSindicato : 0;
            this.sueldoHijos = numHijos * General.extraHijos;

            if (anios < 5)
            {
                this.sueldoAnisTrabajados = 0;
            }
            else if (anios <= 10)
            {
                this.sueldoAnisTrabajados = anios * General.extraAnios5a10;
            }
            else
            {
                this.sueldoAnisTrabajados = anios * General.extraAniosMas10;
            }
        }

    }
}
