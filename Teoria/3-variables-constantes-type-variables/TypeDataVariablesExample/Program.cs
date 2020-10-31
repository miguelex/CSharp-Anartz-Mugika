using System;

namespace TypeDataVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de datos númericos - Enteros - Con signo");

            // sbyte
            //sbyte sbyteInvalid = 130; <--- ERROR... seria un short
            sbyte sbyteValid = 120;
            Console.WriteLine(sbyteValid);

            //short
            //short shortValue = 32900; <--- ERROR... seria un int
            short shortValue = 32368;
            Console.WriteLine(shortValue);

            //int
            //int intValue = 329000000000; <--- ERROR... seria un Long
            int intValue = 3560000;
            Console.WriteLine(intValue);

            //long
            //long longValue = 329000000000000000000; <--- ERROR
            long longValue = 3560000000000000000;
            Console.WriteLine(longValue);

            Console.WriteLine("Tipos de datos númericos - Enteros - Sin signo");

            // byte
            //byte byteInvalid = 256; <--- ERROR... seria un ushort
            byte byteValid = 255;
            Console.WriteLine(byteValid);

            //ushort
            //ushort shortValue = 66369; <--- ERROR... seria un uint
            ushort ushortValue = 65535;
            Console.WriteLine(ushortValue);

            //uint
            //uint intValue = 4698963258; <--- ERROR... seria un uLong
            uint uintValue = 4294967295;
            Console.WriteLine(uintValue);

            //ulong
            //ulong longValue = 9896326987521478962; <--- ERROR
            ulong ulongValue = 18446744073709551615;
            Console.WriteLine(ulongValue);

            Console.WriteLine("Tipos de datos númericos - No Enteros");

            // Float
            float floatValue = 125889924445484548566658481523333333333.03f;
            Console.WriteLine(floatValue);

            // Double
            double doubleValue = 125889924445484548566658481523339999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999993333333.03d;
            Console.WriteLine(doubleValue);

            Console.WriteLine("Tipos de datos no númericos - Booleanos");

            bool startGame = true;
            Console.WriteLine($"¿Juego iniciado? {startGame}");

            startGame = false;
            Console.WriteLine($"¿Juego iniciado? {startGame}"); 

            startGame = Convert.ToBoolean(1);  
            Console.WriteLine($"¿Juego iniciado? {startGame}"); 
            
            startGame = Convert.ToBoolean(0);  
            Console.WriteLine($"¿Juego iniciado? {startGame}");      
        }
    }
}
