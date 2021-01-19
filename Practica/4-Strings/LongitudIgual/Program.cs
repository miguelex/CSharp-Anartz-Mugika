using System;

namespace LongitudIgual
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaUna, cadenaDos;
            Console.WriteLine("Introduzca el primer texto: ");
            cadenaUna = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo texto: ");
            cadenaDos = Console.ReadLine();

            Console.WriteLine($"Resultado de los introducido: {cadenaUna}, {cadenaDos}");
            Console.WriteLine("Longitud de {0} es {1} caracteres", cadenaUna, cadenaUna.Length);
            Console.WriteLine("Longitud de {0} es {1} caracteres", cadenaDos, cadenaDos.Length);

            Console.WriteLine("¿Tienen la misma longitud? {0}", cadenaUna.Length == cadenaDos.Length);
            Console.WriteLine("¿Son iguales? {0}", cadenaUna.Equals(cadenaDos));


        }
    }
}
