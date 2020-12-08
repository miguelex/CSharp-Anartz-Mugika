using System;

namespace eurosPesetas
{
    class Program
    {
        static void Main(string[] args)
        {
            const double EURO = 166.386;
            double eurosConvertir;

            Console.WriteLine("Introduzca la cantidad de Euros que quiere convertir:");
            eurosConvertir = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La cantidad de de {eurosConvertir} euros equivale a {eurosConvertir * EURO} ptas. ");
        }
    }
}
