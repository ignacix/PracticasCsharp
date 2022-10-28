using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n1, n2, n3;

            Console.WriteLine("Ingrese 3 números");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if((n1+n2)>(n2*n3)){

                Console.WriteLine("Es mayor");

            }
        }

    }
}
