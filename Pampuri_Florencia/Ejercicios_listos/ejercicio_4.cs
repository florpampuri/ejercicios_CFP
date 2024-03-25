using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listos
{
    internal class ejercicio_4
    {
        static void Main(string[] args)
        {
            //4. Ingresar 5 números enteros, calcular y mostrar el promedio.

            int primerNumero;
            string primerNumeroTexto;
            int segundoNumero;
            string segundoNumeroTexto;
            int tercerNumero;
            string tercerNumeroTexto;
            int cuartoNumero;
            string cuartoNumeroTexto;
            int quintoNumero;
            string quintoNumeroTexto;

            int promedio;

            Console.Write("Ingrese el primer número: ");
            primerNumeroTexto = Console.ReadLine();
            primerNumero = int.Parse(primerNumeroTexto);
            Console.Write("Ingrese el segundo número: ");
            segundoNumeroTexto = Console.ReadLine();
            segundoNumero = int.Parse(segundoNumeroTexto);
            Console.Write("Ingrese el tercer número: ");
            tercerNumeroTexto = Console.ReadLine();
            tercerNumero = int.Parse(tercerNumeroTexto);
            Console.Write("Ingrese el cuarto número: ");
            cuartoNumeroTexto = Console.ReadLine();
            cuartoNumero = int.Parse(cuartoNumeroTexto);
            Console.Write("Ingrese el quinto número: ");
            quintoNumeroTexto = Console.ReadLine();
            quintoNumero = int.Parse(quintoNumeroTexto);

            promedio = (primerNumero + segundoNumero + tercerNumero + cuartoNumero + quintoNumero) / 5;
            Console.WriteLine($"El promedio de los números ingresados es {promedio}");
        }
    }
}
