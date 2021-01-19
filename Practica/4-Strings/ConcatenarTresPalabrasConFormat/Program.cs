using System;

namespace ConcatenarTresPalabrasConFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string primerTexto, segundoTexto, tercerTexto;

            Console.WriteLine("Introduzca el primer texto: ");
            primerTexto = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo texto: ");
            segundoTexto = Console.ReadLine();
            Console.WriteLine("Introduzca el tercer texto: ");
            tercerTexto = Console.ReadLine();

            string textoConcatenado = String.Format("{0}\t{1}\t{2}",primerTexto, segundoTexto, tercerTexto);
            Console.WriteLine("Resultado de los tres textos concatenados y añadido con tabulacion:  {0}", textoConcatenado);
        }
    }
}
