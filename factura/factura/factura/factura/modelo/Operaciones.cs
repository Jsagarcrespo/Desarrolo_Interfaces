using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factura.modelo;
using static factura.General;

namespace factura.modelo
{
    internal class Operaciones
    {
        public Operaciones(double horas, int trabajadores, double aluKg, double hierroKG, double coberKG, double latoKG)
        {
            Horas = horas;
            Trabajadores = trabajadores;
            AluKg = aluKg;
            HierroKG = hierroKG;
            CoberKG = coberKG;
            LatoKG = latoKG;

            precio_hora_trabajador = Horas * General.pagaHora * Trabajadores;
            precioAlu = AluKg * General.precioAlu; 
            preicoHierro = HierroKG * General.preicoHierro;
            preicoCobre = CoberKG * General.precioCobre;
            preicoLaton = LatoKG * General.precioLaton;

            faturaTotal = precio_hora_trabajador + precioAlu  + preicoHierro + preicoCobre + preicoLaton;  

        }

        public double Horas { get; set; }
        public int Trabajadores { get; set; }
        public double AluKg { get; set; }
        public double HierroKG { get; set; }
        public double CoberKG { get; set; }
        public double LatoKG { get; set; }
        public double precio_hora_trabajador { get; private set; }
        public double precioAlu { get; }
        public double preicoHierro { get; }
        public double preicoCobre { get; }
        public double preicoLaton { get; }
        public double faturaTotal { get; }

        public double facturaTotal = 0; 
    }
}
