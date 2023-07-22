using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTVAzteca
{
    public class Operaciones
    {
        static string cadena = "";
        public static void Fibonacci(int n)
        {
            int auxiliar, a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                cadena += a + " ";
            }
            Console.WriteLine(cadena);
        }

        public static void SumaDigitos(int valor)
        {
            int suma = 0;
            for (int i = 0; i < valor.ToString().Length; i++)
            {
                suma += Convert.ToInt32(valor.ToString().Substring(i, 1));
            }
            Console.WriteLine($"La suma del número {valor} es {suma}");
        }

        public static void NumerosPrimos(int inicio, int final)
        {
            for(int i = inicio; i <= final; i++){
                if(EsPrimo(i)) cadena += i + " ";
            }
            Console.WriteLine(cadena);
        }

        public static bool EsPrimo(int valor) {
            for (int i = 2; i < valor; i++)
            {
                if ((valor % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void OrdenarPalabras(string oracion) {
            List<string> palabras = oracion.Trim().Split(' ').ToList();
            palabras.Sort();
            string oracionOrdenada = String.Join(" ", palabras);
            Console.WriteLine(oracionOrdenada);
        }

    }
}
