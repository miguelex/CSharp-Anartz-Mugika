using System;

namespace ComienzoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Estoy haciendo los ejercicios opcionales del curso de C# de Master Devs con el profesorAnartz Mugika";

            Console.WriteLine("¿Comienza con \"Master Devs\"?: {0}", cadena.StartsWith("Master Devs"));
            Console.WriteLine("¿Comienza con \"Estoy haciendo los ejercicios opcionales\"?: {0}", cadena.StartsWith("Estoy haciendo los ejercicios opcionales"));
            Console.WriteLine("¿Es igual a  \"Estoy haciendo ejercicios opcionales\"?: {0}", cadena.Equals("Estoy haciendo ejercicios opcionales"));
            Console.WriteLine("¿Finaliza con  \"Mugika\"?: {0}", cadena.EndsWith("Mugika"));
            Console.WriteLine("¿Finaliza con  \"AnartzMugika\"?: {0}", cadena.EndsWith("AnartzMugika"));
            Console.WriteLine("¿Finaliza con  \"Anartz Mugika\"?: {0}", cadena.EndsWith("Anartz Mugika"));

        }
    }
}
