using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            
            int n, mayor=0, posicion=0;

            int[] vector= new int[10];

            Console.WriteLine("Ingrese 10 números!");

            for (int i = 0; i < 10; i++)
            {
                n=int.Parse(Console.ReadLine());

                vector[i]=n;
            }

            for(int x=0;x<10;x++){
                
                n= vector[x];
                if (x==0)
                {
                    mayor=n;
                    posicion=x;
                }else if (n>mayor)
                {
                    mayor=n;
                    posicion=x;
                }
            }

            Console.WriteLine("El numero mas alto es el: "+mayor+" con la posición: "+ posicion);
        }
    }
}
