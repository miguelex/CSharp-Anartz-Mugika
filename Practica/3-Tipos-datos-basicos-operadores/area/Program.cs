using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            double alto, ancho;

            Console.WriteLine("Vamos a calcular el area y el perimetro de un rectangulo");
            Console.WriteLine("Introduzca el alto del rectangulo: ");
            alto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el ancho del rectangulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El rectangulo tiene {alto} de alto y {ancho} de ancho ");
            Console.WriteLine($"El perimetro del rectangulo es: {(2*ancho) + (2*alto)} ");
            Console.WriteLine($"El área del rectangulo es: {ancho*alto} ");



        }
    }
}
