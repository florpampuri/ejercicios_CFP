using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Ejercicios_listos
{
    internal class ejercicio_1
    {
        static void Main(string[] args)
        {
            //1. Ingresar el nombre y apellido por consola.

            string nombre;
            string apellido;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine($"Bienvenid@ {nombre} {apellido}");
        }
    }
}