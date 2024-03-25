using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listos
{
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
