using System;

namespace TypeCasting
{
    class Program
    {
        // char -> int -> long -> float -> double
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tipo de conversión implicito");
            
            char character = 'a';
            int characterInt = character;

            Console.WriteLine($"Estamos conviertiendo el caracter '{character}' a un valor entero: {characterInt}"); 

            character = 'm';
            characterInt = character;

            Console.WriteLine($"Estamos conviertiendo el caracter '{character}' a un valor entero: {characterInt}");

            // int -> double / int -> float

            int numberInt = 99;
            double numberDouble = numberInt;
            float numberFloat = numberInt;

            Console.WriteLine($"Numero entero {numberInt} => float {numberFloat} => double {numberDouble}");

            
        }
    }
}
