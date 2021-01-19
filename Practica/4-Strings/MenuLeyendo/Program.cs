using System;

namespace MenuLeyendo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("============================================================");
            Console.WriteLine("\t\tAHORCADO - OPCIONES DEL JUEGO");
            Console.WriteLine("============================================================");
            Console.WriteLine("1) Jugar a acertar una palabra aleatoria.");
            Console.WriteLine("2) Jugar a acertar 5 palabras aleatorias.");
            Console.WriteLine("3) Jugar a acertar una palabra de un tema seleccionado.");
            Console.WriteLine("4) Jugar a acertar 5 palabras de un tema seleccionado.");
            Console.WriteLine("5) Salir.");
            Console.WriteLine("============================================================");

            Console.Write("Seleccione la opcion deseada: ");
            opcion = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("¿Está entre 1 y 4 (incluidos)? {0}", opcion >=1 && opcion <=4);
            Console.WriteLine("¿Hemos seleccionado salir? {0}", opcion == 5);
        }
    }
}
