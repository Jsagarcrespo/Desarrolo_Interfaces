using Nominas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nominas.Controlador.Operacion;

namespace Nominas.Controlador
{
    internal class Operacion
    {
        public const int extraSindicato = 50;
        public const int extraAnios5a10 = 30;
        public const int extraAniosMas10 = 50;
        public const int extraHijos = 100;
        public enum Modalidad
        {
            PRODUCCION,
            ADMINISTRACION,
            TECNICO,
            ESPECIALISTA
        }

        public static readonly Dictionary<Modalidad, double> sueldoModalidad =
            new Dictionary<Modalidad, double>
        {
                { Modalidad.PRODUCCION, 1100 },
                { Modalidad.ADMINISTRACION, 1400 },
                { Modalidad.TECNICO, 1700 },
                { Modalidad.ESPECIALISTA, 2100 },


        };

   
    


     public string CalcularNomina(Operacion.Modalidad modalidad, bool sindicato, int anios, int numHijos)
        {
            if (anios < 0 || anios > 50)
            {
                throw new Exception("Los años trabajados tienen que ser num positivos");
            }
            if (numHijos < 0 || numHijos > 10)
            {
                throw new Exception("Num hijos positivo");

            }

            Nomina nomina = new Nomina(modalidad, sindicato, numHijos, anios);
            String total = nomina.CalcularNomina();

            return $@"{nomina.Modalidad}: {nomina.SueldoModalidad1}€
             Estar sindicado: {nomina.SueldoSindicato1}€
             {nomina.NumAñosTrabajo} años trabajados: {nomina.SueldoAniosTrabajados1}€
               {nomina.NumHijos} hij2s: {nomina.SueldoHijos1}€
                Total: {total}€";

        }









    } 
}

