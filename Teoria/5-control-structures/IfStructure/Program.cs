using System;

namespace IfStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero del 1 al 10");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 10){
                Console.WriteLine("Has introducido el siguiente numero {0} y es mayor que 10", number);
            }

            if (number > 10 || number <0){
                Console.WriteLine("No has escrito un numero valido");
            }

            if (number <= 10 && number >0){
                Console.WriteLine("Numero correcto");
            }
        }
    }
}
