using System;

namespace operar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduce el primer numero:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / (double)numero2}");
            Console.WriteLine($"{numero1} % {numero2} = {numero1 & numero2}");
        }
    }
}
