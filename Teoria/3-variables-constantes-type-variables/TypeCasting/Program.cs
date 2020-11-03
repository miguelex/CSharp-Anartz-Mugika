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

            Console.WriteLine("Tipo de conversión con clase convert");

            int myInt = 10;
            double myDouble = 56.234d;
            bool myBool = true;
            char myChar = 'a';

            Console.WriteLine(Convert.ToString(myInt)); //"10"
            Console.WriteLine(Convert.ToDouble(myInt)); // 10
            Console.WriteLine(Convert.ToInt32(myChar)); // 97
            Console.WriteLine(Convert.ToString(myBool)); // "True"
            Console.WriteLine(Convert.ToInt64(myDouble)); // 56
            Console.WriteLine(Convert.ToBoolean(0)); // false
            Console.WriteLine(Convert.ToBoolean(myDouble)); // true
        }   
    }
}
