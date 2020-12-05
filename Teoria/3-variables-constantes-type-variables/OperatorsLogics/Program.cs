using System;

namespace OperatorsLogics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valor = true;
            bool result = false;

            Console.WriteLine("AND");
            int x = 5, y = 9, z = 10;
            result = (x < y) && (y < z); // true
            result = (x < y) && (y < z) && valor; // true
            Console.WriteLine("OR");
            x = 130; y = -1; z = -67;
            result = (x < y)|| (y < z); // false
            result = (x < y) || (y < z) || valor; // true
            Console.WriteLine("NOT");
            result = !((x < y)|| (y < z)); // true

            Console.WriteLine("Mezcla de operadores lógicos");
            result = (x < y) && (y < z) && false; // false
            result = (x < y) && (y < z) && false || x == 130; // true
            result = !((x < y) && (y < z) && false || x == 130); // false

        }
    }
}
