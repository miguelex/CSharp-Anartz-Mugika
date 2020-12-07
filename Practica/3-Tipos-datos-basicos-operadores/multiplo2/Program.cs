using System;

namespace multiplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduzca el valor a evaluar");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Es multiplo de 2 el valor {numero1}?: {numero1 % 2 == 0}");
        }
    }
}
