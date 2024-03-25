using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listos
{
    internal class ejercicio_2
    {
        static void Main(string[] args)
        {
            //2. Ingresar el nombre, apellido y edad por consola.

            string nombre2;
            string apellido2;
            int edad;
            string edadTexto;

            Console.Write("Ingrese su nombre: ");
            nombre2 = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido2 = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edad = int.Parse(edadTexto);

            Console.WriteLine($"Bienvenid@ {nombre2} {apellido2}. Usted tiene {edad} años.");

        }
    }
}
