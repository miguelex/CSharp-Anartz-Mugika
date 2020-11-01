using System;

namespace TypeCasting
{
    class Program
    {
        // char -> int -> long -> float -> double
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tipo de conversión implicita");
            
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

            Console.WriteLine("Tipo de conversión explicita");
            // double -> float -> long -> int -> char

            double valorInicial = 97.8d;
            Console.WriteLine($"Estamos conviertiendo el valor double {valorInicial} a un valor float {(float)valorInicial}");
            Console.WriteLine($"Estamos conviertiendo el valor double {valorInicial} a un valor long  {(long)valorInicial}");
Console.WriteLine($"Estamos conviertiendo el valor double {valorInicial} a un valor char  {(char)valorInicial}");

        }
    }
}
