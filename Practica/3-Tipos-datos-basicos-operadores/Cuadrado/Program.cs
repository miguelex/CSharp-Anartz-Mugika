using System;

namespace Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero para calcualr su cuadrado");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado del cuadrado de {x} es {x*x}");
        }
    }
}
