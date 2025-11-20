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


        private String nom, ape1, ape2;

        public Empleado(string nom, string ape1, string ape2, Departamento dept)
        {
            this.nom = nom;
            this.ape1 = ape1;
            this.ape2 = ape2;
            this.dept = dept;
        }


        internal Departamento Dept { get => dept; set => dept = value; }

        public override string ToString()
        {
            return string.Format("nombre: {0}, primer apellido: {1}, segundo apellido: {2}, departamento: {3}", nom, ape1, ape2, dept.Nombre);

        }

    }
}
