using System;

namespace DividirCadenaVariosCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Estoy en la parte de la clase String del curso de C# de Master Devs con el profesor Anartz Mugika. Luego aprenderé a trabajar con las estructuras de control del flujo de un programa :) Voy a escribir un correo electrónico a ​anartzmugika@anartz.com​ para preguntar una duda";
            char [] caracteres = {',','.','@','-'};

            string [] subcadenas = cadena.Split(caracteres);

            Console.WriteLine("Frases obtenidas:  {0}", subcadenas.Length);
            Console.WriteLine("Frase 1:{0}", subcadenas[0]);
            Console.WriteLine("Frase 2: {0}", subcadenas[1]);
            Console.WriteLine("Frase 3: {0}", subcadenas[2]);
            Console.WriteLine("Frase 4: {0}", subcadenas[3]);
        }
    }
}
