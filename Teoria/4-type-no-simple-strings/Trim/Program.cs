using System;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "  ¡Soy Anartz!  ";
            Console.WriteLine(text);
            Console.WriteLine(text.TrimStart()+"=>");
            Console.WriteLine(text.TrimEnd()+"=>");
            Console.WriteLine(text.Trim()+"=>");
        }
    }
}
