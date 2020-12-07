using System;

namespace parImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduce el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Los dos son PARES o IMPARES {(numero1 % 2 == 0 && numero2 % 2 == 0) || (numero1 % 2 != 0 && numero2 % 2 != 0)}");
        }
    }
}
