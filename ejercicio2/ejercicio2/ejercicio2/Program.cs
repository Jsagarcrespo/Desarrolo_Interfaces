using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion; 
            int num1 , num2 ;


            do
            {

                Console.WriteLine("1. sumar\n" +
                    "2. restar\n" +
                    "3. multiplicar\n" +
                    "4. dividir\n" +
                    "5. salir\n" +
                    "opcion:");
                opcion = int.Parse(Console.ReadLine());

                if(opcion == 5){
                    Console.WriteLine("Saliendo...");
                    break; 
                }

                Console.WriteLine("introduce el primer numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("introduce el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado de la suma: {sumar(num1, num2)}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado de la resta: {restar(num1, num2)}");
                        break;


                    case 3:
                        Console.WriteLine($"Resultado de la multiplicacion: {multi(num1, num2)}");
                        break;

                    case 4:
                        Console.WriteLine($"Resultado de la division: {dividir(num1, num2)}");
                        break;

                    default:
                        Console.WriteLine("Opcion no valido");
                        break;

                }

                


            } while (opcion != 5);

        }

        static int sumar(int num1, int num2)
        {
           return num1 + num2;
        }

        static int restar(int num1, int num2)
        {
            return num1 - num2;
        }

        static int multi(int num1, int num2)
        {
            return num1 * num2;
        }

        static int dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
