using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "-> ¡Hola Anartz! Voy a aprender C# en Master Devs ";

            int findAnartz = message.IndexOf("Anartz", 3); // 9 

            findAnartz =  message.IndexOf("Anartz", 3); // 9
            findAnartz =  message.IndexOf("Anartz", 15); // -1

            int findMaster = message.IndexOf("Master Devs");

            findMaster = message.IndexOf("Master Devs", 40);
            findMaster = message.IndexOf("Master Devs", 38, 9);
        }
    }
}
