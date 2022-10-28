using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego 
            //calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad, acum =0, promedio, mayores=0;

            Console.WriteLine("Ingrese 20 edades!");

            for (int i = 0; i < 20; i++)
            {
                edad=int.Parse(Console.ReadLine());

                if(edad>18){
                    acum+=edad;
                    mayores++;
                } 

            }

            promedio=acum/mayores;

            Console.WriteLine(promedio);
        }
    }
}
