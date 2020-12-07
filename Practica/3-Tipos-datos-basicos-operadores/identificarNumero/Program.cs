using System;

namespace identificarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            char numeroChar;

            Console.WriteLine("Introduzca un caracter para mostrar su digito");
            numeroChar = Convert.ToChar(Console.ReadLine());
            numero1 = numeroChar;
            Console.WriteLine($"Es numero {numeroChar} corresponde al char {numero1}");
        }
    }
}
