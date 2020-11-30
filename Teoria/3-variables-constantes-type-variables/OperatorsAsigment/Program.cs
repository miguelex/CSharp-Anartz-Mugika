using System;

namespace OperatorsAsigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a asignar el valor");
            int x = 165; // Asignación simple ==> valor que queremos asignar
            Console.WriteLine("Vamos a asignar el valor haciendo suma +=");
            x += 5; // x = x + 5 ==> x = 165 + 5 = 170
            Console.WriteLine("Vamos a asignar el valor haciendo resta -=");
            x -= 10; // x = x - 10  ==> x = 170 - 10  = 160
            Console.WriteLine("Vamos a asignar el valor haciendo multiplicacion *=");
            x *= 5; // x = x * 5 ==> x = 160 * 5 = 800
            Console.WriteLine("Vamos a asignar el valor haciendo división /=");
            x /= 15; // x = x / 15 ==> x = 800 / 5 = 53
            Console.WriteLine("Vamos a asignar el valor haciendo resto %=");
            x %= 10; // x = x % 10 ==> x = 53 % 3 = 3
            Console.WriteLine($"El valor de x es: {x}");
            



        }
    }
}
