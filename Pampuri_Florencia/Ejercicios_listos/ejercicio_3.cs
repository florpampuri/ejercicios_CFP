using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listos
{
    internal class ejercicio_3
    {
        static void Main(string[] args)
        {
            //3. Ingresar 2 números y mostrar la suma de los mismos.

            int numeroUno;
            string numeroUnoTexto;
            int numeroDos;
            string numeroDosTexto;
            int suma;

            Console.Write("Ingrese un número: ");
            numeroUnoTexto = Console.ReadLine();
            numeroUno = int.Parse(numeroUnoTexto);
            Console.Write("Ingrese otro número: ");
            numeroDosTexto = Console.ReadLine();
            numeroDos = int.Parse(numeroDosTexto);

            suma = numeroUno + numeroDos;
            Console.WriteLine($"La suma de {numeroUno} y {numeroDos} es {suma}");
        }
    }
}
