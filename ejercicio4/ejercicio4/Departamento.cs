using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Departamento
    {
        private List<Empleado> empleados = new List<Empleado>();

        private String nom;
        private String responsable;
        private int ID;
        private static double sumarandom = 0;



        public Departamento(string nom, int iD, string responsable)
        {
            this.nom = nom;
            ID = iD;
            this.responsable = responsable;
            sumarandom += 1.5; 
            

        }

        public string Nombre { get => nom; set => nom = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        internal List<Empleado> Empl { get => empleados; set => empleados = value; }

        public double Sumarandom { get => sumarandom; set => sumarandom = value; }

    }
}
