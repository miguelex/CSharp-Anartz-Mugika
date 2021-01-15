using System;

namespace ContentFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Migue";
            bool result = false;

            Console.WriteLine("Equals");
            result = name.Equals("Migue"); // true
            result = name.Equals("MiguE"); // false
            result = name.Equals("migue"); // false

            Console.WriteLine("Comienza con");
            result = name.StartsWith("Migue"); // true
            result = name.StartsWith("M"); // true
            result = name.StartsWith("mi"); // false

            Console.WriteLine("Termina con");
            result = name.EndsWith("Migue"); // true
            result = name.EndsWith("ue"); // true
            result = name.EndsWith("E"); // false

        }
    }
}
