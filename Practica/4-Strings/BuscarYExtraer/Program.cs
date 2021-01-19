using System;

namespace BuscarYExtraer
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Estoy haciendo los ejercicios opcionales del curso de C# de Master Devs con el profesorAnartz Mugika";
            int posicion = cadena.IndexOf("Master");

            Console.WriteLine("Encontrado \"Master\" en la posicion: {0}", posicion);
            Console.WriteLine("Extraido correctamente \"Master Devs\": {0}", cadena.Substring(60, "Master Devs".Length));

        }
    }
}
