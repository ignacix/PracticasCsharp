using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero");
            n=int.Parse(Console.ReadLine());

            if(n!=0){

                if(n>0){
                    Console.WriteLine("Positivo");
                }else{
                    Console.WriteLine("Negativo"); 
                }
                
            }else{
                Console.WriteLine("Cero");
            }


        }
    }
}
