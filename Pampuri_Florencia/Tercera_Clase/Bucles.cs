namespace Tercera_Clase
{
    internal class Bucles
    {
        static void Main(string[] args)
        {
            //mientras --> while
            //repetir --> dowhile
            //para --> for


            int control = 0;


            while (control < 10) {
                Console.WriteLine(control); 
                control++;
            }


            do{
                Console.WriteLine(control);
                control++;

            } while (control < 20);


            //cuando se sabe la cantidad de repeticiones se utiliza for
            for (int i = 20; i < 30; i++) {
                Console.WriteLine(i);
            }







        }
    }
}
