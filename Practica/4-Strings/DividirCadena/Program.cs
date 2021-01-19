using System;

namespace DividirCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Estoy en la parte de la clase String del curso de C# de Master Devs con el profesor Anartz Mugika. Luego aprenderé a trabajar con las estructuras de control del flujo de un programa:)";
            string [] subcadenas = cadena.Split(".");

            Console.WriteLine("Número de frases en el texto inicial => {0}", subcadenas.Length);
            Console.WriteLine("Primera frase => {0}", subcadenas[0]);
            Console.WriteLine("Segunda frase => {0}", subcadenas[1]);  
        }
    }
}
