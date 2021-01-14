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

            result = String.Format("Mi nombre de pila es {0}", name); // "Mi nombre de pila es Migue"
            result = String.Format("Mi nombre de pila es {0} y mis apellidos son {1}", name, lastName); // "Mi nombre de pila es Migue y mis apellidos son Del Mar"
            result = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", 1, 2, 3, 4, 5, 6, 7, 8);

            Console.WriteLine("Concatenación - String Interpolation");
        }
    }
}
