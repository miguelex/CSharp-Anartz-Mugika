using System;

namespace CalcularIVA
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio1, precio2, precio3, precio4, precio5;
            double totalSinIVA, totalConIVA;

            Console.WriteLine("Introduce el precio para el primer producto:");
            precio1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el precio para el segundo producto:");
            precio2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el precio para el tercer producto:");
            precio3= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el precio para el cuarto producto:");
            precio4= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el precio para el quinto producto:");
            precio5= Convert.ToDouble(Console.ReadLine());

            totalSinIVA = precio1+precio2+precio3+precio4+precio5;
            totalConIVA = totalSinIVA + (totalSinIVA*0.21);
            Console.WriteLine("========== Resumen de los productos ==========");
            Console.WriteLine($"TOTAL GASTADO SIN IVA: {totalSinIVA}");
            Console.WriteLine($"TOTAL GASTADO SIN IVA: {totalConIVA}");
            
        }
    }
}
