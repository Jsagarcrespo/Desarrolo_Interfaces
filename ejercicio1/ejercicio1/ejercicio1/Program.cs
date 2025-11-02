using System;
using System.Collections.Generic;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nota;
            string nombre;
            int NMax = 0; 
            int NMin = 10;
            String nonMax = "";
            String nomMin = "";

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Escribe un nombre");
                nombre = Console.ReadLine();

                Console.WriteLine($"Escribe la nota de {nombre}"); 
                while (!int.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine($"No has insertado una nota valida."); 
                }
                if (nota > NMax)
                {
                    NMax = nota;
                    nonMax = nombre;
                }
                if (nota < NMin)
                {
                    NMin = nota;
                    nomMin = nombre;
                }

                Console.WriteLine($"La nota maxima es {NMax} y ha sacado {nonMax}");
                Console.WriteLine($"La nota minima es {NMin} y ha sacado {nomMin}");

                Console.ReadLine();

            }

        }
    }
}
