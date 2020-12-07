using System;

namespace esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159265358979323846;

            double superficie, volumen, radio;

            Console.WriteLine(" Introduzca el radio en metros: ");
            radio = Convert.ToDouble(Console.ReadLine());

            superficie = 4 * PI * (radio * radio);
            volumen = (4/3) * PI * (radio * radio * radio);

            Console.WriteLine($"La superficie de la esfera es: {superficie} metros cuadrado");
            Console.WriteLine($"El volumen de la esfera es: {volumen} metros cubicos");
            {
                
            }

        }
    }
}
