using System;

namespace OperatorArimetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUMA (+)");
            Console.WriteLine($"5 +4 + 56 + 34 = {5 +4 + 56 + 34}"); //99
            Console.WriteLine($"5.34d + 4.34d + 56 + 34 = {5.34d + 4.34d + 56 + 34}"); // 99.68
            Console.WriteLine($"(-25) +4 + (-56) + 34 = {(-25) +4 + (-56) + 34}"); //-43

            Console.WriteLine("RESTA (-)");
            Console.WriteLine($"5  - 4 - 6 - 4 = {5  - 4 - 6 - 4}"); //-9
            Console.WriteLine($"5.34d - 4.34d - 1.5d = {5.34d - 4.34d - 1.5d}"); // -0.5
            Console.WriteLine($"(-25.5f) + 4.5f + (-56) + 34 = {(-25.5f) + 4.5f + (-56) + 34}"); //-43

            Console.WriteLine("MULTIPLICACION (*)");
            Console.WriteLine($"5  * 4 * 6 = {5  * 4 * 6}"); //120
            Console.WriteLine($"5  * 4 * (-6) = {5  * 4 * (-6)}"); // -120
            Console.WriteLine($"5  * (-4) * (-6) = {5  * (-4) * (-6)}"); //120
            Console.WriteLine($"2.5f * 5 = {2.5f * 5}"); //12.5
            Console.WriteLine($"2.5f * -5 = {2.5f * (-5)}"); //-12.5

            Console.WriteLine("COMBINAR OPERDORES (+, -, *)");
            Console.WriteLine($"((5 * 4) + 65 - 45) * 5 = {((5 * 4) + 65 - 45) * 5}"); //200
            Console.WriteLine($"5 * 4 + 65 - 45 * 5 = {5 * 4 + 65 - 45 * 5}"); //-140

        }
    }
}
