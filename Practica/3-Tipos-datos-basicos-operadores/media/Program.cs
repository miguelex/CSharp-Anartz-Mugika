using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;

            Console.WriteLine("Introduzca la nota de Matematicas I:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la nota de AMC:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la nota de Desarrollo de Interfaces:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la nota de Elaboración de Proyectos Informáticos:");
            nota4 = Convert.ToDouble(Console.ReadLine());
            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"La nota media obtenida de las notas del curso es: {media}");
        }
    }
}
