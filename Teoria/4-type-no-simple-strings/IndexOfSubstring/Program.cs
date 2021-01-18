using System;

namespace IndexOfSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "-> ¡Hola Anartz! Voy a a aprender C# en Master Devs (https://formacion.masterdevs.es/) ¡Animate!";
            
            int posInicial = message.IndexOf("Voy");
            int posFinal = message.IndexOf(" ¡Animate!");

            string subMessage = message.Substring(posInicial, posFinal-posInicial);
            Console.WriteLine(subMessage);
        }
    }
}
