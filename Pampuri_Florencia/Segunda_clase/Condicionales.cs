using System.ComponentModel.Design;

namespace Segunda_clase
{
    internal class Condicionales
    {
        static void Main(string[] args)
        {
            //Repaso condicionales

            int edad = 29;
            string genero = "mujer";

            if (genero == "mujer")
            {
                if (edad < 18)
                {
                    Console.WriteLine("Es una mujer menor de edad");
                }
                else
                {
                    Console.WriteLine("Es una mujer mayor de edad");
                }
            }
            else
            {
                Console.WriteLine("No es mujer");
            }

        }
    }
}
