using System;

namespace pesetasEuros
{
    class Program
    {
        static void Main(string[] args)
        {
            const double EURO = 166.386;
            double pesetasConvertir;

            Console.WriteLine("Introduzca la cantidad de pesetas que quiere convertir:");
            pesetasConvertir = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La cantidad de de {pesetasConvertir} pesetas equivale a {pesetasConvertir / EURO} eur. ");
        }
    }
}
