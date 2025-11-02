using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        var listaNum=new List<int>();
        Console.WriteLine("Introduce numero o djea vacio");

        while (true)
        {
            string entrada=Console.ReadLine();

            if(string.IsNullOrWhiteSpace(entrada))
            {
                break;
            }
            else if(int.TryParse(entrada, out int n))
            {
                listaNum.Add(n);
            }
            else
            {
                Console.WriteLine("No hay numero valido");
            }   
        }

        int opcion=0;

        do { 


      

        Console.WriteLine("1.- Multiplicar por tres los números pares");
        Console.WriteLine("2.- Multiplicar por dos todos los números");
        Console.WriteLine("3.- Añadir un número al final");
        Console.WriteLine("4.- Añadir un número al principio");
        Console.WriteLine("5.- Añadir un número en una posición concreta");
        Console.WriteLine("6.- Borrar el último elemento");
        Console.WriteLine("7.- Borrar el primer elemento");
        Console.WriteLine("8.- Borrar un elemento en una posición concreta");
        Console.WriteLine("9.- Buscar un elemento");
        Console.WriteLine("10.- Ordenar los elementos");
        Console.WriteLine("11.- Salir\n");

        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Opción no válida. Prueba de nuevo.");
            continue;
           
        }


        switch (opcion) // menú con switch
        {
            case 1: 
                opcion1(listaNum); 
                
            break;

            case 2:
                opcion2(listaNum); 
            break;

            case 3:
                opcion3(listaNum);
            break;

            case 4:
                opcion4(listaNum);
            break;

            case 5:
                opcion5(listaNum);
            break;

            case 6:
                opcion6(listaNum);
            break;

            case 7:
                opcion7(listaNum);
            break;

            case 8:
                opcion8(listaNum);
            break;

            case 9:
                opcion9(listaNum);
            break;

            case 10:
                opcion10(listaNum);
            break;

            case 11:
                Console.WriteLine("saliendo...");
            break;

           default:
               Console.WriteLine("opción invalida");
           break;
            }

            if (opcion != 11)
            {
                Console.WriteLine("Lista actual: [" + string.Join(", ", listaNum) + "]");
            }

        } while (opcion != 11);


    }

    static void opcion1(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
                numeros[i] *= 3;
        }

       
    }

    static void opcion2(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count; i++)
            numeros[i] *= 2;
    
    }


    static void opcion3(List<int> numeros)

    {
        int num;

        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Opción no válida. Prueba de nuevo.");

        }

        numeros.Add(num);

    }

    static void opcion4(List<int> numeros)

    {
        int num;

        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Opción no válida. Prueba de nuevo.");

        }

        numeros.Insert(0,num);

    }

    static void opcion5(List<int> numeros)

    {
        Console.Write($"Posición para insertar (0..{numeros.Count}): ");

        if (!int.TryParse(Console.ReadLine(), out int pos) || pos < 0 || pos > numeros.Count)
        {
            Console.WriteLine( "fuera de rango");
            return;
        }

        Console.Write("Número a insertar: ");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("No se añadió nada");
            return;
        }

        numeros.Insert(pos, num);
     
    }

    static void opcion6(List<int> numeros)
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("lista vacía");
            return;
        }
        numeros.RemoveAt(numeros.Count - 1);
      
    }

    static void opcion7(List<int> numeros)
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("lista vacía");
            return;
        }
        numeros.RemoveAt(0);
       
    }

    static void opcion8(List<int> numeros)
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("lista vacía");
            return;
        }

        Console.Write($"Posición a eliminar (0..{numeros.Count - 1}): ");

        if (!int.TryParse(Console.ReadLine(), out int pos) || pos < 0 || pos >= numeros.Count)
        {
            Console.WriteLine("fuera de rango");
            return;
        }
        numeros.RemoveAt(pos);
      
    }

    static void opcion9(List<int> numeros)
    {
        Console.Write("buscar num ");

        if (!int.TryParse(Console.ReadLine(), out int buscado))
        {
            Console.WriteLine("num invalida");
            return;
        }

        var posiciones = new List<int>();

        for (int i = 0; i < numeros.Count; i++)
            if (numeros[i] == buscado) posiciones.Add(i);

        if (posiciones.Count == 0)
            Console.WriteLine($"{buscado} no está en la lista.");
        else
            Console.WriteLine($"{buscado} encontrado en posiciones: {string.Join(", ", posiciones)}");
    }

    static void opcion10(List<int> numeros)
    {
        numeros.Sort();
   
    }


}