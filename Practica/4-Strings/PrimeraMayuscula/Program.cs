using System;

namespace PrimeraMayuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Introduzca el texto");
            texto = Console.ReadLine();

            string primeraLetra, restoLetras;
            primeraLetra = (texto.Substring(0,1)).ToUpper();
            restoLetras = (texto.Substring(1)).ToLower();

            Console.WriteLine("La palabra \"{0}\" que hemos introducido, despues de hacer la conversión será lo siguiente: {1}", texto, String.Concat(primeraLetra,restoLetras));

        }
    }
}
