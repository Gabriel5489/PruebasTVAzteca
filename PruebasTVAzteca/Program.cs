using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTVAzteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = Presentacion();
            int n, inicio, final;
            while (opcion.ToUpper() != "F")
            {
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Escribe la cantidad de numeros a mostrar");
                        n = Convert.ToInt32(Console.ReadLine());
                        Operaciones.Fibonacci(n);
                        break;
                    case "2":
                        Console.WriteLine("Escribe un número");
                        n = Convert.ToInt32(Console.ReadLine());
                        Operaciones.SumaDigitos(n);
                        break;
                    case "3":
                        Console.WriteLine("Escribe el inicio del rango");
                        inicio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escribe el final del rango");
                        final = Convert.ToInt32(Console.ReadLine());
                        Operaciones.NumerosPrimos(inicio, final);
                        break;
                    case "4":
                        Console.WriteLine("Escribe la frase a ordenar");
                        string frase = Console.ReadLine();
                        Operaciones.OrdenarPalabras(frase);
                        break;
                    default:
                        Console.WriteLine("Elije una opción de la lista.");
                        break;
                }
                Console.WriteLine("Presiona Enter para continuar...");
                Console.ReadKey();
                Console.Clear();
                opcion = Presentacion();
            }
            Console.WriteLine("Has salido del menú");
            Console.WriteLine("Presiona Enter para salir de la consola...");
            Console.ReadKey();
        }

        static string Presentacion()
        {
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("1.- Fibonacci");
            Console.WriteLine("2.- Suma de Dígitos");
            Console.WriteLine("3.- Encuentra numeros primos");
            Console.WriteLine("4.- Ordenar frase");
            Console.WriteLine("F.- Termina");
            return Console.ReadLine();
        }
    }
}
