using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            string numero;
            numero = Console.ReadLine();
            int num;
            long resultado = 1;

            if (Esnumero(numero) == true)
            {
                num = int.Parse(numero);
            }
            else
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return;
            }

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(resultado + " X " + i + " = ");
                resultado = resultado * i;
                Console.WriteLine(resultado);
            }

            Console.WriteLine("El factorial de " + num + " es " + resultado);
            Console.ReadLine();



        }

        public static bool Esnumero(string numero)
        {
            try
            {
                int num = int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
