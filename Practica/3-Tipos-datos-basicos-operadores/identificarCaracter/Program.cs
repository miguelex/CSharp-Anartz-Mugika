using System;

namespace identificarCaracter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            char numeroChar;

            Console.WriteLine("Introduzca un numero para mostrar su caracter");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numeroChar = (char)numero1;
            Console.WriteLine($"Es numero {numero1} corresponde al char {numeroChar}");
        }
    }
}
