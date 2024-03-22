namespace Primera_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer ejercicio de prueba
            
            string nombre1;
            Console.Write("Ingrese su nombre: ") ;
            nombre1 = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre1);

            
            //Segundo ejercicio de prueba 
            
            string nombre;
            string apellido;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Bienvenid@ " + nombre +" "+ apellido);
            
            
            //Tercer ejercicio de prueba 

            string nombre3;
            string edadTexto;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre3 = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edad = int.Parse(edadTexto);

            //3 formas de concatenar
            Console.WriteLine("Bienvenid@ " + nombre3 + "! Usted tiene " + edad + " años.");
            Console.WriteLine("Bienvenid@ {0}! Usted tiene {1} años.", nombre3, edad);
            Console.WriteLine($"Bienvenid@ {nombre}! Usted tiene {edad} años.");


        }
    }
}
