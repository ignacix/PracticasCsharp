using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Hello World!");
            n = int.Parse(Console.ReadLine());
            if(n>=18){
                Console.WriteLine("Es mayor");
            }else{
                Console.WriteLine("Es menor");
            }
        }
    }
}
