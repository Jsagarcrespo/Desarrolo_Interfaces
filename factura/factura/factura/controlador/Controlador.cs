using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factura.modelo;

namespace factura.controlador
{
    internal class Controlador
    {
        public string CalcFactura(double hora, int trabajador, double alu, double hierro, double cobre, double laton)
        {
            if (0.00 >= hora)
            {
                throw new ArgumentException("La hora tiene que ser mayor de 0");
            }

            if (trabajador < 1 || trabajador > 10)
            {
                throw new ArgumentException("rango de trabajadores entre 1-10");
            }

            Operaciones operaciones = new Operaciones(hora, trabajador, alu, hierro, cobre, laton);
            

            return 
$@"horas por trabjador: {operaciones.precio_hora_trabajador}€
Aluminio: {operaciones.precioAlu}€
Hierro: {operaciones.preicoHierro}€
Cobre: {operaciones.preicoCobre}€
Laton: {operaciones.preicoLaton}€
el total de la factura asciende a: {operaciones.faturaTotal}

";
        }
    }
}
