using System;

namespace mayorIgual
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
            Console.WriteLine($"El valor {numero1} es igual al valor {numero2}? {numero1 == numero2}");
            Console.WriteLine($"El valor {numero1} es mayor o igual que el valor {numero2}? {numero1 >= numero2}");
        }
    }
}
