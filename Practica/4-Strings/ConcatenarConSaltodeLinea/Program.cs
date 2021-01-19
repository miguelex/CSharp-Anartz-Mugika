using System;

namespace ConcatenarConSaltodeLinea
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

            string textoConcatenado = String.Concat($"\nprimerTexto", $"\n{segundoTexto}", $"\n{tercerTexto}");
            Console.WriteLine("Resultado de los tres textos concatenados y añadido con salto de linea:  {0}", textoConcatenado);
        }
    }
}
