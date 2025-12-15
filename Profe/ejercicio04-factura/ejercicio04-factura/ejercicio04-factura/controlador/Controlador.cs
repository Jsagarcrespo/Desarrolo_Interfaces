using ejercicio04_factura.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04_factura.controlador
{
    internal class Controlador
    {
        public string CalcularFactura(
            double numHoras,
            int numTrabajadores,
            bool cAluminio, double aluminio,
            bool cHierro, double hierro,
            bool cCobre, double cobre,
            bool cLaton, double laton)
        {
            if (numHoras <= 0)
                throw new Exception("El número de horas no puede ser menor o igual a 0");

            if (numTrabajadores <= 0 || numTrabajadores > General.maxTrabajadores)
                throw new Exception("El número de trabajadores tiene que estar entre 1 y 10");

            // Validación de materiales
                validarMaterial(cAluminio,aluminio);
                validarMaterial(cHierro,hierro);
                validarMaterial(cCobre, cobre);
                validarMaterial(cLaton, laton);
            
            // Crear factura
            Factura factura = new Factura(numHoras, numTrabajadores);

            // Añadir materiales seleccionados
            if (cAluminio)
                factura.SumarMaterial(new Material("Aluminio", General.precioAlumnio, aluminio));
            if (cHierro)
                factura.SumarMaterial(new Material("Hierro", General.precioHierro, hierro));
            if (cCobre)
                factura.SumarMaterial(new Material("Cobre", General.precioCobre, cobre));
            if (cLaton)
                factura.SumarMaterial(new Material("Laton", General.precioLaton, laton));

            // Devolver resultado
            return $"El total de la factura asciende a {factura.CalcularFactura()}€";
        }

        public static void validarMaterial(bool seleccionado, double cantidad)
        {
            if (seleccionado)
                if (cantidad <= 0 || cantidad > General.maxMaterial)
                    throw new Exception("Los materiales seleccionados tienen que ser mayor que 0 y menor o igual a 200");
        }

    }
}
