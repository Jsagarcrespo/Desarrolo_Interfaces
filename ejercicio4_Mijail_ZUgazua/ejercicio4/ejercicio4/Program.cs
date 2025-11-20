using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Departamento> departamentos = new List<Departamento>();

            Console.Write("Num depts? ");
            int numDept = int.Parse(Console.ReadLine());



            for (int i = 0; i < numDept; i++)
            {

                Console.Write("Nombre dpt? ");
                string nombreDpt = Console.ReadLine();


                Console.Write("responsable? ");
                string responsable = Console.ReadLine();

                Departamento dept = new Departamento(nombreDpt, i + 1, responsable);

                Console.Write($"num de  empleados en {nombreDpt}? ");
                int numEmpleados = int.Parse(Console.ReadLine());

                for (int j = 0; j < numEmpleados; j++)
                {
                    Console.WriteLine($"\nEmpleado {j + 1} de {nombreDpt}");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Primer ape: ");
                    string ape1 = Console.ReadLine();

                    Console.Write("Segundo ape: ");
                    string ape2 = Console.ReadLine();

                    Empleado empleado = new Empleado(nombre, ape1, ape2, dept);
                    dept.Empleados.Add(empleado);
                }

                departamentos.Add(dept);
            }

            foreach (var dept in departamentos)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Nombre Dpto:{dept.Nombre} ");
              
                Console.WriteLine($"\nNombre responsable:{dept.Responsable} ");
               

                if (dept.Empleados.Count == 0)
                {
                    Console.WriteLine("Vacio...");
                }
                else
                {
                    Console.WriteLine("Empleados");
                    Console.WriteLine("Nombre | Apellido1 | Apellidodo 2 | Dpto");
                    foreach (var emple in dept.Empleados)
                    {
                        Console.WriteLine(emple.ToString());
                    }
                }

            }


        }
    }
}
