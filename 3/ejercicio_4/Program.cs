using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, minimo;
            Console.WriteLine("ingrese 4 numeros");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            
            if(n1<n2){
                minimo= n1;
            }else{
                minimo=n2;
            }

            if(n3<minimo){
                minimo= n3;
            }
            
            if(n4<minimo){
                minimo= n4;
            }
            Console.WriteLine(minimo);
        }
    }
}
