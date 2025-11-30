using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Empleado
    {
        private Departamento dept;
        
        
        private String Nombre, Apellido1, Apellido2;

        public Empleado(string nombre, string apellido1, string apellido2, Departamento dept )
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            this.dept = dept;
        }


        internal Departamento Dept { get => dept; set => dept = value; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido1} {Apellido2} {dept.Nombre}";
        }

    }
}
