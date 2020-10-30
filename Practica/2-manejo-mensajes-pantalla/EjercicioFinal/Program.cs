using System;

namespace EjercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            String apellidos = Console.ReadLine();
            Console.WriteLine("Edad: ");
            String edad = Console.ReadLine();
            Console.WriteLine("Afición: ");
            String aficion = Console.ReadLine();

            Console.WriteLine("=== INFORMACICIÓN BÁSICA ===");
            Console.WriteLine($"Eres {nombre} {apellidos}.");
            Console.WriteLine($"Tienes {edad} años.");
            Console.WriteLine($"Hobby: {aficion}.");
            Console.WriteLine("============================");
        }
    }
}
