using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nomina.Nomina; 

namespace nomina.controlador
{
    internal class Controlador
    {
        public string CalcularNomina(General.Modalidad modalidad,bool sindicato,int trabajado,int hijos)
        {
            if (trabajado < 0 || trabajado > 50)
                throw new Exception("Los años trabajados tienen que ser un numero entero ");

            if (hijos < 0 || hijos > 10)
                throw new Exception("el numero de hijxs tiene que ser un numero entero");

            Nomina nomina = new Nomina(modalidad, sindicato, trabajado, hijos);
            string total = nomina.CalcularNomina();

            return
$@"{nomina.modalidad} : {nomina.sueldoModalidad}€
Estar sindicado: {nomina.sueldoSindicato}€
{nomina.anios} anios trabajados: {nomina.sueldoAnisTrabajados}€
{nomina.numHijos} hijxs: {nomina.sueldoHijos}€
Total: {total}€"; 
        }
    }
}
