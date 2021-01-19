using System;

namespace ConcatYFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string primerProducto, segundoProducto, tercerProducto, cuartoProducto, quintoProducto;

            Console.WriteLine("Introduzca el primer Producto: ");
            primerProducto = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo Producto: ");
            segundoProducto = Console.ReadLine();
            Console.WriteLine("Introduzca el tercer Producto: ");
            tercerProducto = Console.ReadLine();
            Console.WriteLine("Introduzca el cuarto Producto: ");
            cuartoProducto = Console.ReadLine();
            Console.WriteLine("Introduzca el quinto Producto: ");
            quintoProducto = Console.ReadLine();

            string textoConcatenado = String.Concat(primerProducto, $"\n{segundoProducto}", $"\n{tercerProducto}", $"\n{cuartoProducto}", $"\n{quintoProducto}");
            string textoFormateado = String.Format("{0}\n{1}\n{2}\n{3}\n{4}",primerProducto, segundoProducto,tercerProducto,cuartoProducto, quintoProducto);
            Console.WriteLine("Resultado de los cinco productos concatenados y añadido un salto de linea usando la funcion Concat:\n{0}\nResultado de los cinco productos concatenados y añadido un salto de linea usando la funcion Format:\n{1}", textoConcatenado, textoFormateado);
        }
    }
}
