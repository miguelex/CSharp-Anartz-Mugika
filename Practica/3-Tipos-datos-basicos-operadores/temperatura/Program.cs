using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit, Kelvin;

            Console.WriteLine("Introduzca la cantidad de grados Celsisu (Cº) que quieres convertir a Fahrenheit y Kelvin: ");
            Celsius = Convert.ToDouble(Console.ReadLine());

            Fahrenheit = (Celsius * 1.8) + 32;
            Kelvin = Celsius + 273;

            Console.WriteLine($"Celsius: {Celsius}ºC =====> Fahrenheit: {Fahrenheit}ºF");
            Console.WriteLine($"Celsius: {Celsius}ºC =====> Kelvin: {Kelvin}ºK");
        }
    }
}
