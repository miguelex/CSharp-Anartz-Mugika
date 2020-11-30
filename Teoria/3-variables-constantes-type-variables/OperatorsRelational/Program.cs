using System;

namespace OperatorsRelational
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores relacionales");
            int x = 78, y = 67, z = 78;
            // Igualdad
            bool result = x == y; // falso
            result = x == z; // true
            // Desigualdad
            result = x != y; // true
            result = x != z; // false
            // Mayor que 
            result = x > y; // true
            result = x > z; // false
            // Menor que 
            result = x < y; // false
            result = x < z; // false
            // Mayor o igual que 
            result = x >= y; // true
            result = x >= z; // true
            // Menor que 
            result = x <= y; // false
            result = x <= z; // true



        }
    }
}
