using System;

namespace cociente
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduzca el dividendo");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el divisor");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Conciente: {numero1 / numero2} / Resto: {numero1 % numero2}");

        }
    }
}
