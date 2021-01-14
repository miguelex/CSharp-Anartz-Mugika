using System;

namespace EscapeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result="";
            Console.WriteLine("Nueva línea");
            result = "Migue\nDel\nMar";
            Console.WriteLine(result);

            Console.WriteLine("Tabulador");
            result = "Migue\tDel\tMar";
            Console.WriteLine(result);

            Console.WriteLine("Contrabarra");
            result = "Migue\\Del\\Mar";
            Console.WriteLine(result);

            Console.WriteLine("Comillas dobles y simpes");
            result = "\"Migue\" 'Del' Mar";
            Console.WriteLine(result);

            Console.WriteLine("retorno de carro");
            result = "Migue\rDel Mar";
            Console.WriteLine(result);

        }
    }
}
