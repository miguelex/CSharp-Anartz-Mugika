using System;

namespace ecuacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int incognita, resultado;

            Console.WriteLine("Introduce el valor de la incognita para realziar la operacion x^2 + 2x +1:");
            incognita = Convert.ToInt32(Console.ReadLine());
            resultado = (incognita * incognita) + (2 * incognita) + 1;
            Console.WriteLine($"El resultado es: {resultado}");
            Console.WriteLine($"¿El resultado {resultado} está dentro del rango -5, 5?: {resultado >= -5 && resultado <= 5}");

        }
    }
}
