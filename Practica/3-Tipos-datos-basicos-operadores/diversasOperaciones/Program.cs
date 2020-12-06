using System;

namespace diversasOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; 

            Console.WriteLine("Introduzca un valor ENTERO para obtener le resultado de la operaciones planteadas");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Con resultados enteros");
            Console.WriteLine($"-6 + {numero} * 10 = {-6 + numero * 10}");
            Console.WriteLine($"(15 - 2) * {numero} = {(15 - 2) * numero}");
            Console.WriteLine($"(({numero} + -2) * (35 / 10) = {(numero + -2) * (35 / 10)}");
            Console.WriteLine($"(13 + {numero}) / (45 - 4) = {(13 + numero) / (45 - 4)}");
            Console.WriteLine("Con resultados decimales");
            Console.WriteLine($"-6 + {numero} * 10 = {-6 + numero * 10}");
            Console.WriteLine($"(15 - 2) * {numero} = {(15 - 2) * numero}");
            Console.WriteLine($"(({numero} + -2) * (35 / 10) = {(numero + -2) * (35 / (double)10)}");
            Console.WriteLine($"(13 + {numero}) / (45 - 4) = {(13 + numero) / (double)(45 - 4)}");
        }
    }
}
