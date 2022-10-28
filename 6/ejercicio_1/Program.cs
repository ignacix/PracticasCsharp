using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números.
            // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            
           int n, cont=0, prim=0;

            for (int x = 0; x < 10; x++)
            {
                n=int.Parse(Console.ReadLine()); 
                for (int i = 1; i <= n; i++)    
                {
                    if ((n%i)==0)
                    {
                        cont=cont +1;
                    }
                }
                if (cont==2)
                {
                    prim=prim +1;
                    
                }
                cont=0;
            }
            
                
                



            
            Console.WriteLine("La cantidad de primeos es: "+prim);
        }
    }
}
