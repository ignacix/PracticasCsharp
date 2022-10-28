using System;

namespace tercer_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            float km , velocidad, tiempo;
            Console.WriteLine("Ingrese los kilómetros!");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad!");
            velocidad = float.Parse(Console.ReadLine());
            tiempo = km/velocidad;        
            Console.WriteLine("Tiempo aproximado de viaje es: "+ tiempo);
        }    
    }
}
