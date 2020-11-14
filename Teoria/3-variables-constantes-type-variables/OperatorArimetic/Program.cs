using System;

namespace OperatorArimetic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("SUMA (+)");
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

            Console.WriteLine("DIVISIONES (/)");
            Console.WriteLine($"20 / 5 = {20 / 5}"); // 4
            Console.WriteLine($"20 / 5 / 5  = {20 / 5 / 5}"); // 0
            Console.WriteLine($"20 / 5 / 5d  = {20 / 5 / 5d}"); // 0.8
            Console.WriteLine($"-20 / 5 / 5d  = {-20 / 5 / 5d}"); // -0.8
            Console.WriteLine($"-20 / 5 / -5d  = {-20 / 5 / -5d}"); // 0.8

            Console.WriteLine("MODULO (resto) (%)");
            Console.WriteLine($"20 % 5 = {20 % 5}"); // 0
            Console.WriteLine($"20 % 6 = {20 % 6}"); // 2

            Console.WriteLine("COMBINAR OPERDORES (+, -, *, /, %)");
            Console.WriteLine($"(((5 * 4) + 65 - 45) * 5) % 40 = {(((5 * 4) + 65 - 45) * 5) % 40}"); //0
            Console.WriteLine($"5 * 4 + 65 - 45 * 5 = {5 * 4 + 65 - 45 * 5}"); //-140*/

            Console.WriteLine("OPERADORES UNARIOS");
            // Postfijo x++ x--
            // Prefijo ++x --x
            // Valor existente +
            // Negación -
            int valor = 34;
            Console.WriteLine($"Vamos a mostrar el valor inicializado: {valor}"); // 34
            Console.WriteLine($"Prefijo --: {--valor}"); // 33
            Console.WriteLine($"Postfijo --: {valor--}"); // 33 (lo que se muestra) => valor real 32
            Console.WriteLine($"Valor actual: {valor}"); // 32
            Console.WriteLine($"Prefijo ++: {++valor}"); // 33
            Console.WriteLine($"Postfijo ++: {valor++}"); // 33 (lo que se muestra) => valor real 34
            Console.WriteLine($"Valor actual: {valor}"); // 34
            valor = +valor;
            Console.WriteLine($"Valor actual: {valor}"); // 34
            valor = -valor;
            Console.WriteLine($"Valor actual: {valor}"); // 34
            valor = +valor;
            Console.WriteLine($"Valor actual: {valor}"); // 34
            

        }
    }
}
