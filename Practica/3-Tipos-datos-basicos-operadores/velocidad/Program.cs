using System;

namespace velocidad
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia;
            byte hora, minutos, segundos;
            ushort segundosTotales;
            double velocidadMS, velocidadKH, velocidadMH;

            Console.WriteLine("Introduzca la distancia recorrida (en metros):");
            distancia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca las horas transcurridas:");
            hora = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduzca los minutos transcurridos:");
            minutos = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduzca los segundos transcurridos:");
            segundos = Convert.ToByte(Console.ReadLine());

            segundosTotales = (ushort)((hora * 3600) +  (minutos * 60) + segundos);
            velocidadMS = distancia / segundosTotales;
            Console.WriteLine($"Avanzado {distancia} metros en {hora}:{minutos}:{segundos} a una velocidad de {velocidadMS} m/s");
            velocidadKH = velocidadMS * 3.6;
            velocidadMH = velocidadKH / 1.6;
            Console.WriteLine($"Velocidad en Km/H: {velocidadKH} Km/h");
            Console.WriteLine($"Velocidad en M/H: {velocidadMH} M/h");





        }
    }
}
