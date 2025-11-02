using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listNum = new List<int>();
            var entrada = "";
            int suma = 0;
            int num;
            int posicion; 

            do
            {
                Console.WriteLine("Introduce un numero o vacio para salir: ");
                entrada = Console.ReadLine();
                
                if(int.TryParse(entrada, out int n))
                {
                    /*
                    suma += n; 
                    Console.WriteLine("la suma da: " + suma); 
                    */
                    listNum.Add(n);
                }
                else
                {
                    Console.WriteLine("Opcion no valida o Campo vacio."); 
                }

            } while (!string.IsNullOrWhiteSpace(entrada));

            int opcion = 0;

            do
            {
                Console.Write(" \r\n1.- Multiplicar por tres los números pares.\r\n2.- Multiplicar por dos todos los números.\r\n3.- Añadir un número al final \r\n4.- Añadir un número al principio \r\n5.- Añadir un número en una posición concreta.\r\n6.- Borrar el último elemento \r\n7.- Borrar el primer elemento \r\n8.- Borrar un elemento en una posición concreta.\r\n9.- Buscar un elemento.\r\n10.- Ordenar los elementos de un array.\r\n11.- Salir.\r\n Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        for (int i = 0; i < listNum.Count; i++)
                        {

                            if (listNum[i] % 2 == 0)
                            {
                                Console.WriteLine("la posicion " + i);
                                int multi3 = listNum[i] * 3;
                                Console.WriteLine(multi3);
                            }
                        }
                        break;

                    case 2:
                        for (int i = 0; i < listNum.Count; i++)
                        {
                            int multi2 = listNum[i] * 2;
                            Console.WriteLine(multi2);
                        }
                        break;

                    case 3:
                        Console.Write("Introducir un numero: "); 

                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"No has insertado una numero valida.");
                        }
                      
                        listNum.Add(num); 
                        break; 

                    case 4:
                        Console.Write("Introducir un numero al principio: ");

                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"No has insertado una numero valida.");
                        }

                        listNum.Insert(0, num);


                        break;

                    case 5:

                        Console.Write("Introducir la posicion del 1 a " + listNum.Count);

                        while (!int.TryParse(Console.ReadLine(), out posicion) || posicion < 0 || posicion >= listNum.Count)
                        {
                            Console.WriteLine($"No has insertado una posicion valida.");
                        }

                        Console.Write("Introducir un numero: ");

                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"No has insertado una numero valida.");
                        }

                        listNum.Insert(posicion - 1, num);

                        break;

                    case 6:
                        listNum.RemoveAt(listNum.Count - 1);
                        break;

                    case 7:
                        listNum.RemoveAt(0);
                        break; 

                    
                    case 8:
                        Console.Write("Introducir la posicion a eliminar del 1 a " + listNum.Count);

                        while (!int.TryParse(Console.ReadLine(), out posicion) || posicion < 0 || posicion >= listNum.Count)
                        {
                            Console.WriteLine($"No has insertado una posicion valida.");
                        }

                        listNum.RemoveAt(posicion - 1);

                        break; 

                    
                    case 9:
                        Console.Write("Introduce el numero a buscar: ");

                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"No has insertado una numero valida.");
                        }

                        for (int i = 0; i < listNum.Count; i++)
                        {
                            if (listNum[i] == num)
                            Console.WriteLine("en la posicion: " + i + " ,esta: " + listNum[i]);

                        }


                        break;
                        
                    case 10:

                        ordenarLista(listNum);
                     
                        Console.WriteLine("Lista actual: [" + string.Join(", ", listNum) + "]");
                        /**
                        Console.WriteLine(" ") ;

                        for (int i = 0; i < listNum.Count; i++)
                        {
                            Console.WriteLine("en la posicion: " + i + " ,esta: " + listNum[i]); 

                        }
                            */
                        break;
                        

                    case 11:
                        Console.WriteLine("Saliendo"); 
                        break;

                }
            } while (opcion != 11); 
        }

        static void ordenarLista(List<int> listNum)
        {
            listNum.Sort();
        }

    }
}
