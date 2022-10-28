using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el 
            // máximo de los números pares y el mínimo de los números impares.

            int n, fpar=0, fimp=0, mayor=0, menor=0;

            for (int i = 0; i < 20; i++)
            {   
                n=int.Parse(Console.ReadLine());

                if ((n%2)==0)
                {
                    if (fpar==0)
                    {
                        mayor=n;
                        fpar=1;
                    }else if (n>mayor)
                    {
                        mayor=n;
                    }
                }else if (fimp==0)
                {
                    menor=n;
                    fimp=1;
                }else if (n<menor)
                {
                    menor=n;
                }
                
            }

            Console.WriteLine("El máximo de los pares es: "+mayor+" "+ "Y el menor de los impares es: "+ menor);
        }
    }
}
