using System;

namespace StringConcatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenación - Operador sumar");

            int x = 10, y = 29;
            string helloMessage = "Hola!";
            string result = "";

            result = Convert.ToString(x + y); // "39" == OBJ : "1029"
            result = Convert.ToString(x) + y; //"1029"
            result = helloMessage + " " + x; // "Hola! 10"
            result = x + "" + y; //"1029"

            Console.WriteLine("Concatenación - Funcion Concat");

            string name = "Migue", lastName = "Del Mar";
            // Concatenar name y lastName
            result = String.Concat(name, lastName); // "MigueDel Mar"
            // Separando nombre y apellido

            result = String.Concat(name, " " , lastName); // "MigueDel Mar"

            // Concatenamos muchos valores
            result = String.Concat(name, " ", lastName, x, y, helloMessage); // "MigueDel Mar1029Hola!"

            Console.WriteLine("Concatenación - Funcion Format");
            Console.WriteLine("Concatenación - String Interpolation");
        }
    }
}
