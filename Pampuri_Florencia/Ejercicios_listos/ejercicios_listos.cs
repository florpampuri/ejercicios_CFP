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

    internal class ejercicio_5
    {
        static void Main(string[] args)
        {
            //5. En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
            //Área                Porcentaje del presupuesto
            //Cardiología         40 %
            //Pediatría           45 %
            //Traumatología       15 %


        }
    }

    internal class ejercicio_6
    {
        static void Main(string[] args)
        {
            //6. Una empresa que se dedica a la comercialización de lamparitas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.
            //El precio de cada lamparita es de $150 (Sin importar la marca).
            //El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            //A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.
            //B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca, el descuento es del 30 %.
            //C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %, y si es de otra marca el descuento es del 20 %.
            //D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15 %, si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
            //E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
            //Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.


            double precio = 150;
            int cantidad = 10;
            string marca = "ArgentinaLuz";
            double descuento = 0;
            double precioFinal;
            double porcentaje;
            double precioTotal;
            double precioSinDescuento;

            if (cantidad >= 6)
            {
                descuento = 0.50;
            }           
            else
            {
                if (cantidad == 5)
                {
                     if (marca == "ArgentinaLuz")
                     {
                        descuento = 0.40;
                     }
                     else
                     {
                        descuento = 0.30;
                     }
                }
                else
                {
                    if (cantidad == 4)
                    {
                        if (marca == "ArgentinaLuz" || marca == "FelipeLamparas")
                        {
                            descuento = 0.25;
                        }
                        else
                        {
                            descuento = 0.20;
                        }
                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            if (marca == "ArgentinaLuz")
                            {
                                descuento = 0.15;
                            }
                            else
                            {
                                if (marca == "FelipeLamparas")
                                {
                                    descuento = 0.10;
                                }
                                else
                                {
                                    descuento = 0.05;
                                }
                            }
                        }
                    }
                }
            }

            precioFinal = precio * (1 - descuento);
            porcentaje = descuento * 100;
            precioTotal = precioFinal * cantidad;
            precioSinDescuento = precio * cantidad;

            if (precioTotal > 950)
            {
            precioTotal = (precioTotal * 0.10) + precioTotal;
            }


            Console.WriteLine($"El descuento es del %{porcentaje} y el precio por unidad es ${precioFinal}. " +
            $"El precio total por {cantidad} lamparitas de la marca {marca} es ${precioTotal}. " +
            $"Sin el descuento el precio total sería ${precioSinDescuento}.");
        }
    }

}