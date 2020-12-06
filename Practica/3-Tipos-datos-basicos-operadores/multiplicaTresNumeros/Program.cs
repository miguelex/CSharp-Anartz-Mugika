using System;

namespace multiplicaTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("INTRODUZCA EL PRIMER VALOR ENTERO");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INTRODUZCA EL SEGUNDO VALOR ENTERO");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INTRODUZCA EL TERCER VALOR ENTERO");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la multiplicacion de {num1} * {num2} * {num3} es: {num1*num2*num3} ");
        }
    }
}
