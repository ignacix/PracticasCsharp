using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 5  números enteros y los guarde en un vector.
            //   Luego recorrer ese vector para calcular el promedio. 
            //   Mostrar por pantalla los valores que son mayores al promedio.
            
            int n, promedio=0,acum=0;

            int[] vector = new int[5];

            Console.WriteLine("Ingrese 5 números!");

            for (int i = 0; i < 5; i++)
            {
                n=int.Parse(Console.ReadLine());
                vector[i]=n;
            }

            for(int i=0;i<5;i++){
                acum+=vector[i];
            }

            promedio=acum/5;

            Console.WriteLine("El promedio es: "+promedio);
            Console.Write("Los numeros mayores al promedio son: ");
            for (int i = 0; i < 5; i++)
            {
                if (vector[i]>promedio)
                {
                    Console.Write("("+vector[i]+")");
                }
            }

        }
    }
}
