using System;

namespace quinto_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, promedio;
            Console.WriteLine("Ingrese la primer nota");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota");
            n3 = float.Parse(Console.ReadLine());
            promedio = (n1+n2+n3)/3;
            Console.WriteLine("El promedio es: " + promedio);
        } 
    }
}
