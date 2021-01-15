using System;

namespace ToUpperLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = "aaaaaaaeeeeeEEEE";
            string textTwo = "AAJKAAAAAAfifififififjsk";
            string textThree = "AAUSSOSSPPSSMJDJKD";
            string result ="";

            Console.WriteLine("Convertir a mayusculas");
            result = textOne.ToUpper();
            result = textTwo.ToUpper();
            result = textThree.ToUpper();

            Console.WriteLine("Convertir a minusculas");
            result = textOne.ToLower();
            result = textTwo.ToLower();
            result = textThree.ToLower();
        }
    }
}
