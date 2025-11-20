using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nDept;
            int Nemp; 
            List<Departamento> departamentos = new List<Departamento>();

            Console.Write("Cantidad de departamentos ");
            while (!int.TryParse(Console.ReadLine(), out  nDept))
            {
                Console.WriteLine($"No has insertado una numero valida.");
            }


            for (int i = 0; i < nDept; i++)
            {
                Console.WriteLine($"\nDepartamento {i + 1}"); 
                Console.Write("Nombre:  ");
                string nomDept = Console.ReadLine();


                Console.Write("Responsable:  ");
                string responsable = Console.ReadLine();

                Departamento dept = new Departamento(nomDept, i + 1, responsable);

                Console.Write("Cantidad empleados: ");
                while (!int.TryParse(Console.ReadLine(), out Nemp))
                {
                    Console.WriteLine($"No has insertado una numero valida.");
                }

                for (int j = 0; j < Nemp; j++)
                {
                    Console.WriteLine($"\nEmpleado {j + 1} de {nomDept}");
                    Console.Write("Nombre: ");
                    string nom = Console.ReadLine();

                    Console.Write("Primer apellido: ");
                    string ape1 = Console.ReadLine();

                    Console.Write("Segundo apellido: ");
                    string ape2 = Console.ReadLine();

                    Empleado empleado = new Empleado(nom, ape1, ape2, dept);
                    dept.Empleados.Add(empleado);
                }

                departamentos.Add(dept);
            }

            foreach (var dept in departamentos)
            {
                Console.WriteLine("\n");
                Console.Write($"Nombre del departamento:{dept.Nombre} ");
                Console.WriteLine($"\nNombre del responsable:{dept.Responsable} ");


                if (dept.Empleados.Count != 0)
                {
                    Console.WriteLine("Empleados");
                    foreach (var emple in dept.Empleados)
                    {
                        Console.WriteLine(emple.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No hay empleados");
                }

            }


        }
    }
}
